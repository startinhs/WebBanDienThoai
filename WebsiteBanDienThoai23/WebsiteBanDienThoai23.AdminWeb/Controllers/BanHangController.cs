using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebsiteBanDienThoai23.DAL.Models;

namespace WebsiteBanDienThoai23.AdminWeb.Controllers
{
    public class BanHangController : Controller
    {
        private readonly QLBanDienThoaiContext _context = new QLBanDienThoaiContext();
        // GET: BanHang
        public async Task<IActionResult> Index()
        {
            var qLBanDienThoaiContext = _context.HoaDons.Include(h => h.MaKhNavigation).Include(h => h.MaNvNavigation);
            return View(await qLBanDienThoaiContext.ToListAsync());
        }

        // GET: BanHang/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoaDon = await _context.HoaDons
                .Include(h => h.MaKhNavigation)
                .Include(h => h.MaNvNavigation)
                .FirstOrDefaultAsync(m => m.MaHd == id);
            if (hoaDon == null)
            {
                return NotFound();
            }

            return View(hoaDon);
        }

        // GET: BanHang/Create
        public IActionResult Create()
        {
            ViewData["MaKh"] = new SelectList(_context.NguoiDungs, "UserId", "UserId");
            ViewData["MaNv"] = new SelectList(_context.NguoiDungs, "UserId", "UserId");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaHd,MaKh,MaNv,NgayDatHang,DiaChiGiaoHang,TongGiaTri,TrangThaiTt,TrangThaiDh,NgayNhanHang")] HoaDon hoaDon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hoaDon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaKh"] = new SelectList(_context.NguoiDungs, "UserId", "UserId", hoaDon.MaKh);
            ViewData["MaNv"] = new SelectList(_context.NguoiDungs, "UserId", "UserId", hoaDon.MaNv);
            return View(hoaDon);
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
        // GET: BanHang/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            var NhanVienLapDon = await _context.NguoiDungs.FindAsync(GetUserId());
            if (id == null)
            {
                return NotFound();
            }

            var hoaDon = await _context.HoaDons.FindAsync(id);
            if (hoaDon == null)
            {
                return NotFound();
            }
            ViewData["MaKh"] = new SelectList(_context.NguoiDungs, "UserId", "UserId", hoaDon.MaKh);


                ViewBag.NhanVienLapDon = NhanVienLapDon.HoTen;

            ViewData["TrangThaiTt"] = new SelectList(new List<SelectListItem>
            {
                new SelectListItem { Text = "Đã thanh toán", Value = "true", Selected = hoaDon.TrangThaiTt == true },
                new SelectListItem { Text = "Chưa thanh toán", Value = "false", Selected = hoaDon.TrangThaiTt == false }
            }, "Value", "Text");

            ViewData["TrangThaiDh"] = new SelectList(new List<SelectListItem>
            {
                new SelectListItem { Text = "Đang xử lý", Value = "0", Selected = hoaDon.TrangThaiDh == 0 },
                new SelectListItem { Text = "Đang giao hàng", Value = "1", Selected = hoaDon.TrangThaiDh == 1 },
                new SelectListItem { Text = "Giao hàng thành công", Value = "2", Selected = hoaDon.TrangThaiDh == 2 }
            }, "Value", "Text");

            return View(hoaDon);
        }

        // POST: BanHang/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("MaHd,MaKh,MaNv,NgayDatHang,DiaChiGiaoHang,TongGiaTri,TrangThaiTt,TrangThaiDh,NgayNhanHang")] HoaDon hoaDon)
        {
            if (id != hoaDon.MaHd)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hoaDon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HoaDonExists(hoaDon.MaHd))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaKh"] = new SelectList(_context.NguoiDungs, "UserId", "UserId", hoaDon.MaKh);
            ViewData["MaNv"] = new SelectList(_context.NguoiDungs, "UserId", "UserId", hoaDon.MaNv);
            ViewData["TrangThaiTt"] = new SelectList(_context.HoaDons, "MaHd", "MaHd", hoaDon.TrangThaiTt);
            return View(hoaDon);
        }

        // GET: BanHang/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoaDon = await _context.HoaDons
                .Include(h => h.MaKhNavigation)
                .Include(h => h.MaNvNavigation)
                .FirstOrDefaultAsync(m => m.MaHd == id);
            if (hoaDon == null)
            {
                return NotFound();
            }

            return View(hoaDon);
        }

        // POST: BanHang/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var hoaDon = await _context.HoaDons.FindAsync(id);
            _context.HoaDons.Remove(hoaDon);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HoaDonExists(string id)
        {
            return _context.HoaDons.Any(e => e.MaHd == id);
        }
    }
}
