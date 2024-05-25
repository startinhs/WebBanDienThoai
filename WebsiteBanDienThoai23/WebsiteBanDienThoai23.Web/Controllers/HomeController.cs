using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebsiteBanDienThoai23.DAL.Models;
using WebsiteBanDienThoai23.Web.Models;

namespace WebsiteBanDienThoai23.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        private readonly QLBanDienThoaiContext da = new QLBanDienThoaiContext();
        public IActionResult Index()
        {
            List<SanPham> list = da.SanPhams.OrderBy(s => s.MaSp).ToList();
            var viewModel = new SanPhamModel
            {
                Items = list,
                TotalItems = list.Count
            };
            return View(viewModel);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
