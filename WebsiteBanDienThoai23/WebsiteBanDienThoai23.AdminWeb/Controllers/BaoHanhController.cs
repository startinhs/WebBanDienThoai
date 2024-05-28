using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebsiteBanDienThoai23.AdminWeb.Controllers
{
    public class BaoHanhController : Controller
    {
        // GET: BaoHanhController
        public ActionResult Index()
        {
            return View();
        }

        // GET: BaoHanhController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BaoHanhController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BaoHanhController/Create
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

        // GET: BaoHanhController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BaoHanhController/Edit/5
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

        // GET: BaoHanhController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BaoHanhController/Delete/5
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
