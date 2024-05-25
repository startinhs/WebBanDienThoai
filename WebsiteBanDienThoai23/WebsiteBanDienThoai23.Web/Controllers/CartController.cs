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
				// Giả sử thuộc tính GiamGia của sản phẩm là phần trăm giảm giá
				discount += (cart.GiamGia / 100.0m) * (cart.Gia * cart.SoLuong);
			}
			// Gán tổng giá trị sản phẩm vào ViewBag
			ViewBag.Discount = discount;
            ViewBag.Total = subTotal - discount;
			return View(carts);
        }

		public ActionResult AddToCart(string id)
		{
			var product = _context.SanPhams.FirstOrDefault(s => s.MaSp == id);

			if (product != null)
			{
				List<CartModel> carts = GetListCarts();
				CartModel existingProduct = carts.FirstOrDefault(s => s.MaSp == id);

				if (existingProduct != null)
				{
					existingProduct.SoLuong++;
				}
				else
				{
					CartModel newProduct = new CartModel();
					newProduct.MaSp = product.MaSp;
					newProduct.TenSp = product.TenSp;
					newProduct.Gia = product.Gia;
					newProduct.SoLuong = 1;
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

        public string GenerateMaHd()
        {
            // Tạo một chuỗi ngẫu nhiên độ dài 6 ký tự
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, 6)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            return result;
        }

        [Authorize]
        public ActionResult Checkout()
        {
            if (!User.Identity.IsAuthenticated)
            {
                // Ghi nhớ URL hiện tại trước khi chuyển hướng đến trang đăng nhập
                string returnUrl = Url.Action("Checkout", "Cart");

                return RedirectToAction("Login", "Account", new { returnUrl });
            }

            // Lấy danh sách các sản phẩm trong giỏ hàng từ session
            List<CartModel> carts = GetListCarts();

            // Lấy user ID từ session hoặc qua một phương thức
            int? userId = GetUserId();

            if (carts != null && carts.Count > 0 && userId.HasValue)
            {
                var order = new HoaDon
                {
                    MaHd = GenerateMaHd(),
                    MaKh = userId.Value,
                    NgayDatHang = DateTime.Now,
                };


                // Thêm đơn hàng vào cơ sở dữ liệu
                _context.HoaDons.Add(order);
                _context.SaveChanges(); // Lưu thay đổi để có thể lấy được MaHd tự động tạo

                // Thêm từng sản phẩm trong giỏ vào Chi tiết đơn hàng
                foreach (var item in carts)
                {
                    var orderDetail = new ChiTietHoaDon
                    {
                        MaHd = order.MaHd, // Sử dụng MaHd đã được tạo tự động
                        MaSp = item.MaSp,
                        SoLuongDatHang = item.SoLuong
                    };

                    // Thêm chi tiết đơn hàng vào cơ sở dữ liệu
                    _context.ChiTietHoaDons.Add(orderDetail);
                }

                // Lưu thay đổi vào cơ sở dữ liệu
                _context.SaveChanges();

                // Xóa session giỏ hàng sau khi đã thanh toán
                HttpContext.Session.Remove("CartModel");

                return RedirectToAction("CheckoutSuccess");
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
