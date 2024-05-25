using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using WebsiteBanDienThoai23.DAL.Models;
using WebsiteBanDienThoai23.Extensions;
using WebsiteBanDienThoai23.Web.Models;

namespace WebsiteBanDienThoai23.Web.Controllers
{
    public class CartController : Controller
    {
        private readonly QLBanDienThoaiContext _context = new QLBanDienThoaiContext();
        // GET: CartController
        public ActionResult Index()
        {
            return View();
        }

        public List<CartModel> GetListCarts()
        {
            // Lấy giỏ hàng từ Session
            var carts = HttpContext.Session.GetObjectFromJson<List<CartModel>>("CartModel");

            // Nếu chưa có giỏ hàng thì tạo mới
            if (carts == null)
            {
                carts = new List<CartModel>();
                HttpContext.Session.SetObjectAsJson("CartModel", carts);
            }
            return carts;
        }

        public ActionResult ListCarts()
        {
            List<CartModel> carts = GetListCarts();
            ViewBag.CountProduct = carts.Sum(s => s.SoLuong);
            decimal subTotal = carts.Sum(s => s.SoLuong * s.Gia);
            ViewBag.SubTotal = subTotal;
			decimal discount = 0;
			foreach (var cart in carts)
			{
				discount += (cart.GiamGia / 100.0m) * (cart.Gia * cart.SoLuong);
			}

			ViewBag.Discount = discount;
            ViewBag.Total = subTotal - discount;
			return View(carts);
        }

        public ActionResult AddToCart(string id, int quantity)
        {
            var product = _context.SanPhams.FirstOrDefault(s => s.MaSp == id);

            if (product != null && quantity > 0)
            {
                List<CartModel> carts = GetListCarts();
                CartModel existingProduct = carts.FirstOrDefault(s => s.MaSp == id);

                if (existingProduct != null)
                {
                    existingProduct.SoLuong += quantity;
                }
                else
                {
                    CartModel newProduct = new CartModel();
                    newProduct.MaSp = product.MaSp;
                    newProduct.TenSp = product.TenSp;
                    newProduct.Gia = product.Gia;
                    newProduct.SoLuong = quantity; 
                    newProduct.Hinh = product.Hinh;
                    newProduct.Ram = product.Ram;
                    newProduct.Rom = product.Rom;
                    newProduct.ManHinh = product.ManHinh;
                    newProduct.GiamGia = product.GiamGia;
                    carts.Add(newProduct);
                }

                HttpContext.Session.SetObjectAsJson("CartModel", carts);
            }
            return RedirectToAction("ListCarts");
        }

        private int? GetUserId()
        {
            // Lấy user ID từ session
            var userIdString = HttpContext.Session.GetString("UserId");

            if (int.TryParse(userIdString, out int userId))
            {
                return userId;
            }

            return null;
        }
        public string GenerateMaHd()
        {

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, 6)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            return result;
        }
        [Authorize]
        public ActionResult CheckoutConfirmation(string DiaChiGiaoHang)
        {
            if (!User.Identity.IsAuthenticated)
            {

                string returnUrl = Url.Action("CheckoutConfirmation", "Cart");
                return RedirectToAction("DangNhap", "Account", new { returnUrl });
            }

            int? userId = GetUserId();
            var nguoiDung = _context.NguoiDungs.FirstOrDefault(u => u.UserId == userId);

            List<CartModel> carts = GetListCarts();

            decimal subTotal = carts.Sum(s => s.SoLuong * s.Gia);
            decimal discount = carts.Sum(s => (s.GiamGia / 100.0m) * (s.Gia * s.SoLuong));
            decimal total = subTotal - discount;

            ViewBag.HoTen = nguoiDung != null ? nguoiDung.HoTen : "";
            ViewBag.DiaChi = nguoiDung != null ? nguoiDung.DiaChi : "";
            ViewBag.SDT = nguoiDung != null ? nguoiDung.Sdt : "";
            ViewBag.Email = nguoiDung != null ? nguoiDung.Email : "";
            ViewBag.DiaChi = nguoiDung != null ? nguoiDung.DiaChi : "";

            ViewBag.CountProduct = carts.Sum(s => s.SoLuong);
            ViewBag.SubTotal = subTotal;
            ViewBag.Discount = discount;
            ViewBag.Total = total;

            

            return View(carts);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Checkout()
        {
            if (!User.Identity.IsAuthenticated)
            {
                string returnUrl = Url.Action("Checkout", "Cart");

                return RedirectToAction("DangNhap", "Account", new { returnUrl });
            }

            // Lấy danh sách các sản phẩm trong giỏ hàng từ session
            List<CartModel> carts = GetListCarts();

            // Lấy user ID từ session
            int? userId = GetUserId();
            
            decimal subTotal = carts.Sum(s => s.SoLuong * s.Gia);
            decimal discount = carts.Sum(s => (s.GiamGia / 100.0m) * (s.Gia * s.SoLuong));
            decimal total = subTotal - discount;
            if (carts != null && carts.Count > 0 && userId.HasValue)
            {
                var khachHang = _context.NguoiDungs.FirstOrDefault(u => u.UserId == userId);
                var order = new HoaDon
                {
                    MaHd = GenerateMaHd(),
                    MaKh = userId.Value,
                    NgayDatHang = DateTime.Now,
                    TongGiaTri = total,
                    DiaChiGiaoHang = khachHang.DiaChi
                };

                _context.HoaDons.Add(order);
                _context.SaveChanges(); 

                foreach (var item in carts)
                {
                    var orderDetail = new ChiTietHoaDon
                    {
                        MaHd = order.MaHd, 
                        MaSp = item.MaSp,
                        SoLuongDatHang = item.SoLuong,
                        DonGia = item.Gia
                    };
                    _context.ChiTietHoaDons.Add(orderDetail);
                }

                _context.SaveChanges();

                // Xóa session gio hang
                HttpContext.Session.Remove("CartModel");

                return RedirectToAction("CheckoutSuccess");
            }

            return RedirectToAction("ListCarts");
        }


        
		public ActionResult CheckoutSuccess()
		{
			return View();
		}


		// GET: CartController/Details/5
		public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CartController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CartController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CartController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CartController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CartController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CartController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
