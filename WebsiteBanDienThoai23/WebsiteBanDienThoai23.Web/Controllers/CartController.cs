using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;
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
            List<CartModel> carts = GetListCarts();
            ViewBag.CountProduct = carts.Sum(s => s.SoLuong);
            ViewBag.Total = carts.Sum(s => s.Gia);
            return View(carts);
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
            ViewBag.Total = carts.Sum(s => s.Gia);
            return View(carts);
        }
        public ActionResult AddToCart(string id)
        {
            //Tao moi gio hang
            List<CartModel> carts = GetListCarts();
            //neu Co, lấy về dssp trong gio hang, kiem tra SP co chưa
            CartModel c = carts.Find(s => s.MaSp == id);
            //Co tăng sl
            if (c != null)
            {
                c.SoLuong++;
            }
            //Chua co add vao gio hang
            else
            {
                //Tao moi 1 sp trong gio hang
                c = new Models.CartModel(id);
                carts.Add(c);
            }
            //Hien thi dssp trong gio hang
            return RedirectToAction("ListCarts");
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
