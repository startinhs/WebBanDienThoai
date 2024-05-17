using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using WebsiteBanDienThoai23.DAL.Models;

namespace WebsiteBanDienThoai23.Web.Controllers
{
    public class sDienThoaiController : Controller
    {
        private readonly QLBanDienThoaiContext da = new QLBanDienThoaiContext();
        public IActionResult Index(string searchString, int page = 1)
        {
            const int pageSize = 10; // Số sản phẩm trên mỗi trang
            var lstSanPham = da.SanPhams.AsQueryable(); // Chuyển sang IQueryable

            // Lọc sản phẩm nếu có từ khóa tìm kiếm
            if (!string.IsNullOrEmpty(searchString))
            {
                lstSanPham = lstSanPham.Where(n => n.TenSp.Contains(searchString));
            }

            // Tính số trang và lấy danh sách sản phẩm cho trang hiện tại
            var totalItems = lstSanPham.Count();
            var totalPages = (int)Math.Ceiling((double)totalItems / pageSize);
            var itemsOnCurrentPage = lstSanPham.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            // Truyền dữ liệu cần thiết đến view
            ViewBag.TotalPages = totalPages;
            ViewBag.CurrentPage = page;
            ViewBag.SearchString = searchString;

            return View(itemsOnCurrentPage);
        }
    }
}
