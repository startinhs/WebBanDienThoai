using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
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

        public async Task<IActionResult> ListCarts()
        {
            await LoadCartFromDatabase();

            var cartsFromSession = HttpContext.Session.GetObjectFromJson<List<CartModel>>("CartModel");
            Debug.WriteLine("Dữ liệu trong session:");
            Debug.WriteLine(JsonConvert.SerializeObject(cartsFromSession));

            var carts = cartsFromSession ?? new List<CartModel>();

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
                    CartModel newProduct = new CartModel
                    {
                        MaSp = product.MaSp,
                        TenSp = product.TenSp,
                        Gia = product.Gia,
                        SoLuong = quantity,
                        Hinh = product.Hinh,
                        Ram = product.Ram,
                        Rom = product.Rom,
                        ManHinh = product.ManHinh,
                        GiamGia = product.GiamGia
                    };
                    carts.Add(newProduct);
                }
                HttpContext.Session.SetObjectAsJson("CartModel", carts);
                var maKh = GetUserId();
                var gioHang = _context.GioHangs.FirstOrDefault(g => g.MaKh == maKh);

                if (gioHang == null)
                {
                    gioHang = new GioHang { MaKh = maKh };
                    _context.GioHangs.Add(gioHang);
                    _context.SaveChanges();
                }

                var chiTietGioHang = _context.ChiTietGioHangs.FirstOrDefault(c => c.MaGh == gioHang.MaGh && c.MaSp == id);
                if (chiTietGioHang != null)
                {
                    chiTietGioHang.SoLuong += quantity;
                }
                else
                {
                    chiTietGioHang = new ChiTietGioHang
                    {
                        MaGh = gioHang.MaGh,
                        MaSp = id,
                        SoLuong = quantity
                    };
                    _context.ChiTietGioHangs.Add(chiTietGioHang);
                }

                _context.SaveChanges();
            }

            return RedirectToAction("ListCarts");
        }

        private async Task LoadCartFromDatabase()
        {
            var userId = GetUserId();

            if (userId != null)
            {
                var cartItems = await (from gioHang in _context.GioHangs
                                       join chiTietGioHang in _context.ChiTietGioHangs on gioHang.MaGh equals chiTietGioHang.MaGh
                                       join sanPham in _context.SanPhams on chiTietGioHang.MaSp equals sanPham.MaSp
                                       where gioHang.MaKh == userId
                                       select new CartModel
                                       {
                                           MaSp = sanPham.MaSp,
                                           TenSp = sanPham.TenSp,
                                           Gia = sanPham.Gia,
                                           SoLuong = chiTietGioHang.SoLuong ?? 0,
                                           Hinh = sanPham.Hinh,
                                           Ram = sanPham.Ram,
                                           Rom = sanPham.Rom,
                                           ManHinh = sanPham.ManHinh,
                                           GiamGia = sanPham.GiamGia
                                       }).ToListAsync();

                HttpContext.Session.SetObjectAsJson("CartModel", cartItems);
            }
        }

        private int? GetUserId()
        {
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

            List<CartModel> carts = GetListCarts();

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
                    DiaChiGiaoHang = khachHang.DiaChi,
                    TrangThaiTt = false,
                    TrangThaiDh = 0
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

                    // Giảm số lượng sản phẩm trong cơ sở dữ liệu
                    var product = _context.SanPhams.FirstOrDefault(p => p.MaSp == item.MaSp);
                    if (product != null)
                    {
                        product.SoLuong -= (short)item.SoLuong;
                        if (product.SoLuong < 0)
                        {
                            product.SoLuong = 0;
                        }
                    }
                }

                _context.SaveChanges();

                HttpContext.Session.Remove("CartModel");

                return RedirectToAction("CheckoutSuccess");
            }

            return RedirectToAction("ListCarts");
        }

        public ActionResult CheckoutSuccess()
        {
            return View();
        }



        [Authorize]
        public ActionResult DonMua()
        {
            int? userId = GetUserId();
            if (userId == null)
            {
                return RedirectToAction("DangNhap", "Account");
            }

            var DonMua = (from hd in _context.HoaDons
                          join ct in _context.ChiTietHoaDons on hd.MaHd equals ct.MaHd
                          join sp in _context.SanPhams on ct.MaSp equals sp.MaSp
                          where hd.MaKh == userId.Value
                          select new DonMuaModel
                          {
                              MaSp = sp.MaSp,
                              TenSp = sp.TenSp,
                              SoLuongDatHang = ct.SoLuongDatHang,
                              DonGia = ct.DonGia,
                              NgayDatHang = hd.NgayDatHang,
                              TongGiaTri = hd.TongGiaTri,
                              DiaChiGiaoHang = hd.DiaChiGiaoHang,
                              TrangThaiThanhToan = hd.TrangThaiTt,
                              TrangThaiDonHang = hd.TrangThaiDh,
                              NgayNhanHang = hd.NgayNhanHang
                          }).ToList();

            return View(DonMua);
        }




        public ActionResult Delete(string id)
        {
            var carts = GetListCarts();
            var productToRemove = carts.FirstOrDefault(p => p.MaSp == id);
            if (productToRemove != null)
            {
                carts.Remove(productToRemove);
                HttpContext.Session.SetObjectAsJson("CartModel", carts);

                var userId = GetUserId();
                if (userId != null)
                {
                    var gioHang = _context.GioHangs.FirstOrDefault(g => g.MaKh == userId);
                    if (gioHang != null)
                    {
                        var chiTietGioHang = _context.ChiTietGioHangs.FirstOrDefault(c => c.MaGh == gioHang.MaGh && c.MaSp == id);
                        if (chiTietGioHang != null)
                        {
                            _context.ChiTietGioHangs.Remove(chiTietGioHang);
                            _context.SaveChanges();
                        }
                    }
                }
            }

            return RedirectToAction("ListCarts");
        }


    }
}
