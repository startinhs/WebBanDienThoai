﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebsiteBanDienThoai23.DAL.Models;

namespace WebsiteBanDienThoai23.Web.Controllers
{
    public class DienThoaiController : Controller
    {
        private readonly QLBanDienThoaiContext _context = new QLBanDienThoaiContext();

        // GET: DienThoai
        public async Task<IActionResult> Index(string searchString, int page = 1)
        {
            const int pageSize = 10; // Số sản phẩm trên mỗi trang
            var lstSanPham = _context.SanPhams.AsQueryable(); // Chuyển sang IQueryable

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
        public async Task<IActionResult> TimTheoGia(decimal minPrice, decimal maxPrice, int page = 1)
        {
            const int pageSize = 10; // Số sản phẩm trên mỗi trang
            var lstSanPham = _context.SanPhams.AsQueryable(); // Chuyển sang IQueryable
            // Lọc sản phẩm theo khoảng giá
            lstSanPham = lstSanPham.Where(n => n.Gia * (1 - (n.GiamGia / 100)) >= minPrice && n.Gia * (1 - (n.GiamGia / 100)) <= maxPrice);

            // Tính số trang và lấy danh sách sản phẩm cho trang hiện tại
            var totalItems = lstSanPham.Count();
            var totalPages = (int)Math.Ceiling((double)totalItems / pageSize);
            var itemsOnCurrentPage = lstSanPham.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            // Truyền dữ liệu cần thiết đến view
            ViewBag.TotalPages = totalPages;
            ViewBag.CurrentPage = page;
            ViewBag.MinPrice = minPrice;
            ViewBag.MaxPrice = maxPrice;

            return View(itemsOnCurrentPage);
        }
        // GET: DienThoai/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sanPham = await _context.SanPhams
                .FirstOrDefaultAsync(m => m.MaSp == id);
            if (sanPham == null)
            {
                return NotFound();
            }

            return View(sanPham);
        }
    }
}
