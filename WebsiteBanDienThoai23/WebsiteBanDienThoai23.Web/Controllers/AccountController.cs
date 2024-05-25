using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using WebsiteBanDienThoai23.DAL.Models;
using WebsiteBanDienThoai23.Web.Models;
using System.Linq;

namespace WebsiteBanDienThoai23.Web.Controllers
{
	public class AccountController : Controller
	{
		// GET: AccountController
		public ActionResult Index()
		{
			return View();
		}

		private readonly QLBanDienThoaiContext _context;

		public AccountController(QLBanDienThoaiContext context)
		{
			_context = context;
		}

		[HttpGet]
		public IActionResult Login()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Login(LoginModel model)
		{
			if (ModelState.IsValid)
			{
				var user = _context.NguoiDungs
					.FirstOrDefault(u => u.TenTaiKhoan == model.TenDangNhap && u.MatKhau == model.MatKhau);

				if (user != null)
				{
					var claims = new List<Claim>
				{
					new Claim(ClaimTypes.Name, user.TenTaiKhoan),
					new Claim("UserId", user.UserId.ToString())
				};

					var claimsIdentity = new ClaimsIdentity(
						claims, CookieAuthenticationDefaults.AuthenticationScheme);

					await HttpContext.SignInAsync(
						CookieAuthenticationDefaults.AuthenticationScheme,
						new ClaimsPrincipal(claimsIdentity),
						new AuthenticationProperties
						{
							IsPersistent = true
						});

					HttpContext.Session.SetString("UserId", user.UserId.ToString());

					return RedirectToAction("Index", "Home");
				}

				ModelState.AddModelError(string.Empty, "Tên đăng nhập hoặc mật khẩu không đúng.");
			}

			return View(model);
		}

		[HttpGet]
		public async Task<IActionResult> Logout()
		{
			await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
			HttpContext.Session.Remove("UserId");
			return RedirectToAction("Index", "Home");
		}

		// GET: AccountController/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: AccountController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: AccountController/Create
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

		// GET: AccountController/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: AccountController/Edit/5
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

		// GET: AccountController/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: AccountController/Delete/5
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
