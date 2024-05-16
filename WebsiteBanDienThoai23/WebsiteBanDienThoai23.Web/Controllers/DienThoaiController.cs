using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebsiteBanDienThoai23.DAL.Models;

namespace WebsiteBanDienThoai23.Web.Controllers
{
    public class DienThoaiController : Controller
    {
        private readonly QLBanDienThoaiContext da = new QLBanDienThoaiContext();

        public List<SanPham> SoLuongSP(int soluong)
        {
            return da.SanPhams.Take(soluong).ToList();
        }
        public IActionResult Index(string SearchString)
        {
            var lstSanPham = SoLuongSP(9);

            if (!string.IsNullOrEmpty(SearchString))
            {
                lstSanPham = da.SanPhams.Where(n => n.TenSp.Contains(SearchString)).ToList();

            }
            return View(lstSanPham);
        }
    }
}
