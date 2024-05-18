using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebsiteBanDienThoai23.DAL.Models;

namespace WebsiteBanDienThoai23.Web.Controllers
{
    public class TabletController : Controller
    {
        private readonly QLBanDienThoaiContext _context = new QLBanDienThoaiContext();

        public async Task<IActionResult> Index(int page = 1)
        {
            const int pageSize = 5;
            var lstSanPham = _context.SanPhams.AsQueryable();
            lstSanPham = lstSanPham.Where(n => n.MaLoai.Contains("TABLET"));
            var totalItems = lstSanPham.Count();
            var totalPages = (int)Math.Ceiling((double)totalItems / pageSize);
            var itemsOnCurrentPage = lstSanPham.Skip((page - 1) * pageSize).Take(pageSize).ToList();
            ViewBag.TotalPages = totalPages;
            ViewBag.CurrentPage = page;
            return View(itemsOnCurrentPage);
        }

        public async Task<IActionResult> Name(string key)
        {
            var lstSanPham = _context.SanPhams.AsQueryable();
            if (!string.IsNullOrEmpty(key))
            {
                lstSanPham = lstSanPham.Where(n => n.TenSp.Contains(key) && n.MaLoai.Contains("TABLET"));
            }
            var items = await lstSanPham.ToListAsync();
            ViewBag.TotalItems = items.Count;
            return View(items);
        }
        public async Task<IActionResult> Price(decimal min, decimal max)
        {
            var lstSanPham = _context.SanPhams.AsQueryable();
            lstSanPham = lstSanPham.Where(n => n.Gia * (1 - (n.GiamGia / 100)) >= min && n.Gia * (1 - (n.GiamGia / 100)) <= max && n.MaLoai.Contains("TABLET"));
            var items = await lstSanPham.ToListAsync();
            ViewBag.TotalItems = items.Count;
            return View(items);
        }

        // GET: Tablet/Details/5
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
