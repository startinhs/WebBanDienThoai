using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebsiteBanDienThoai23.DAL.Models;
using WebsiteBanDienThoai23.Web.Models;

namespace WebsiteBanDienThoai23.Web.Controllers
{
    public class MayCuController : Controller
    {
        private readonly QLBanDienThoaiContext _context = new QLBanDienThoaiContext();

        public async Task<IActionResult> Index(int page = 1)
        {
            const int pageSize = 10;
            var lstSanPham = _context.SanPhams.AsQueryable();
            lstSanPham = lstSanPham.Where(n => n.MayCu == true);
            var totalItems = lstSanPham.Count();
            var totalPages = (int)Math.Ceiling((double)totalItems / pageSize);
            var itemsOnCurrentPage = lstSanPham.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            var danhSachLoaiSP = await _context.LoaiSps.ToListAsync(); // Truy vấn danh sách các loại sản phẩm từ cơ sở dữ liệu

            var viewModel = new SanPhamModel
            {
                Items = itemsOnCurrentPage,
                TotalItems = totalItems,
                TotalPages = totalPages,
                CurrentPage = page,
                DanhSachLoaiSP = danhSachLoaiSP // Truyền danh sách loại sản phẩm vào view model
            };

            return View(viewModel);
        }


        public async Task<IActionResult> Name(string key)
        {
            var lstSanPham = _context.SanPhams.AsQueryable();
            if (!string.IsNullOrEmpty(key))
            {
                lstSanPham = lstSanPham.Where(n => n.TenSp.Contains(key) && n.MayCu == true);
            }
            var totalItems = lstSanPham.Count();
            var itemsOnCurrentPage = lstSanPham.ToList();

            var danhSachLoaiSP = await _context.LoaiSps.ToListAsync(); // Truy vấn danh sách các loại sản phẩm từ cơ sở dữ liệu

            var viewModel = new SanPhamModel
            {
                Items = itemsOnCurrentPage,
                TotalItems = totalItems,
                DanhSachLoaiSP = danhSachLoaiSP // Truyền danh sách loại sản phẩm vào view model
            };

            return View("Index", viewModel);
        }

        public async Task<IActionResult> Price(decimal min, decimal max)
        {
            var lstSanPham = _context.SanPhams.AsQueryable();
            lstSanPham = lstSanPham.Where(n => n.Gia * (1 - (n.GiamGia / 100)) >= min && n.Gia * (1 - (n.GiamGia / 100)) <= max && n.MayCu == true);
            var totalItems = lstSanPham.Count();
            var itemsOnCurrentPage = lstSanPham.ToList();

            var danhSachLoaiSP = await _context.LoaiSps.ToListAsync(); // Truy vấn danh sách các loại sản phẩm từ cơ sở dữ liệu

            var viewModel = new SanPhamModel
            {
                Items = itemsOnCurrentPage,
                TotalItems = totalItems,
                DanhSachLoaiSP = danhSachLoaiSP // Truyền danh sách loại sản phẩm vào view model
            };

            return View("Index", viewModel);
        }

        public async Task<IActionResult> Filter(bool pintrau, bool cameradep, bool co5g)
        {
            var lstSanPham = _context.SanPhams.AsQueryable();
            lstSanPham = lstSanPham.Where(n => n.MayCu == true);

            // Áp dụng bộ lọc dựa trên các giá trị của checkbox
            if (pintrau)
            {
                lstSanPham = lstSanPham.Where(n => n.Pin > 3000);
            }

            if (cameradep)
            {
                lstSanPham = lstSanPham.Where(n => n.CameraSau > 12 && n.CameraTruoc > 12);
            }

            if (co5g)
            {
                lstSanPham = lstSanPham.Where(n => n._5g == 1);
            }

            // Lấy danh sách sản phẩm kết quả
            var items = await lstSanPham.ToListAsync();
            var danhSachLoaiSP = await _context.LoaiSps.ToListAsync();

            var viewModel = new SanPhamModel
            {
                Items = items,
                TotalItems = items.Count,
                DanhSachLoaiSP = danhSachLoaiSP
            };

            return View("Index", viewModel);
        }

        // GET: MayCu/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sanPham = await _context.SanPhams
                .Include(s => s.MaLoaiNavigation)
                .FirstOrDefaultAsync(m => m.MaSp == id);
            if (sanPham == null)
            {
                return NotFound();
            }

            return View(sanPham);
        }
    }
}
