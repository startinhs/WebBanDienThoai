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
using WebsiteBanDienThoai23.Web.ViewModels;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WebsiteBanDienThoai23.Web.MailService;

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
        public IActionResult DangKy()
        {
            return View();
        }
		[HttpPost]
        public IActionResult Dangky(DangKy model)
        {
            if (ModelState.IsValid)
            {
                var checkEmail = _context.NguoiDungs.FirstOrDefault(x => x.Email == model.Email);
                var checkTenTK = _context.NguoiDungs.FirstOrDefault(x => x.TenTaiKhoan == model.TenTaiKhoan);
                var checkSDT = _context.NguoiDungs.FirstOrDefault(x => x.Sdt == model.Sdt);
                if (checkEmail != null && checkTenTK == null && checkSDT == null)
                {
                    ViewBag.EmailError = "Email đã tồn tại!";
                    return View();
                }
                else if (checkEmail == null && checkTenTK != null && checkSDT == null)
                {
                    ViewBag.TenTKError = "Tên tài khoản đã tồn tại!";
                    return View();
                }
                else if (checkEmail == null && checkTenTK == null && checkSDT != null)
                {
                    ViewBag.SDTError = "Số điện thoại đã tồn tại!";
                    return View();
                }
                else if (checkEmail != null && checkTenTK != null && checkSDT == null)
                {
                    ViewBag.EmailError = "Email đã tồn tại!";
                    ViewBag.TenTKError = "Tên tài khoản đã tồn tại!";
                    return View();
                }
                else if (checkEmail == null && checkTenTK != null && checkSDT != null)
                {
                    ViewBag.SDTError = "Số điện thoại đã tồn tại!";
                    ViewBag.TenTKError = "Tên tài khoản đã tồn tại!";
                    return View();
                }
                else if (checkEmail != null && checkTenTK == null && checkSDT != null)
                {
                    ViewBag.SDTError = "Số điện thoại đã tồn tại!";
                    ViewBag.EmailError = "Email đã tồn tại!";
                    return View();
                }
                else if (checkEmail != null && checkTenTK != null && checkSDT != null)
                {
                    ViewBag.EmailError = "Email đã tồn tại!";
                    ViewBag.SDTError = "Số điện thoại đã tồn tại!";
                    ViewBag.TenTKError = "Tên tài khoản đã tồn tại!";
                    return View();
                }
                else
                {
                    model.IsAdmin = false;
                    NguoiDung nd = new NguoiDung();
                    nd.HoTen = model.HoTen;
                    nd.Email = model.Email;
                    nd.DiaChi = model.DiaChi;
                    nd.Sdt = model.Sdt;
                    nd.TenTaiKhoan = model.TenTaiKhoan;
                    string salt = BCrypt.Net.BCrypt.GenerateSalt();
                    string mk_hash = BCrypt.Net.BCrypt.HashPassword(model.MatKhau, salt);
                    nd.MatKhau = mk_hash;
                    _context.Add(nd);
                    _context.SaveChanges();
                    return RedirectToAction("DangNhap", "Account");
                }
            }
            return View();
        }
        [HttpGet]
		public IActionResult DangNhap(string? ReturnUrl)
		{
            ViewBag.ReturnUrl = ReturnUrl;
            return View();
		}

		[HttpPost]
		public async Task<IActionResult> DangNhap(DangNhap model, string? ReturnUrl)
		{
            ViewBag.ReturnUrl = ReturnUrl;
            if (ModelState.IsValid)
			{
                var nd = _context.NguoiDungs.SingleOrDefault(kh => kh.TenTaiKhoan == model.TenTaiKhoan);
                if (nd != null)
                {
                    bool passwordMatch = BCrypt.Net.BCrypt.Verify(model.MatKhau, nd.MatKhau);
                    if (passwordMatch)
                    {
                        var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name, nd.TenTaiKhoan),
                            new Claim("UserId", nd.UserId.ToString())
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

                        HttpContext.Session.SetString("UserId", nd.UserId.ToString());
                        if (Url.IsLocalUrl(ReturnUrl))
                        {
                            return Redirect(ReturnUrl);
                        }
                        else
                        {

                            return RedirectToAction("Index", "Home");
                        }
                    }
                    else
                    {
                        ViewBag.UserPassError = "Sai mật khẩu!";
                        return View();
                    }
                }
                else
                {
                    ViewBag.UserNameError = "Tên tài khoản chưa được đăng ký!";
                    return View();
                }
            }
            return RedirectToAction("DangNhap", "Account");
		}
        [HttpGet]
        public IActionResult QuenMatKhau()
        {
            return View();
        }
        [HttpPost]
        public IActionResult QuenMatKhau(string TenTaiKhoan, string Email)
        {
            return View();
        }
        [HttpGet]
		public async Task<IActionResult> DangXuat()
		{
			await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
			HttpContext.Session.Remove("UserId");
			return RedirectToAction("Index", "Home");
		}
	}
}
