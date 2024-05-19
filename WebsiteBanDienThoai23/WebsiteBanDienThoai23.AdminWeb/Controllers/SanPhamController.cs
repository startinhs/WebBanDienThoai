using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebsiteBanDienThoai23.BLL;
using WebsiteBanDienThoai23.Common.Req;
using WebsiteBanDienThoai23.Common.Rsp;

namespace WebsiteBanDienThoai23.AdminWeb.Controllers
{
	[Route("api/[controller]")]
	[ApiController]

	public class SanPhamController : ControllerBase
	{
		private SanPhamSvc_Admin sanPhamSvc_Admin;
		
		public SanPhamController()
		{
			sanPhamSvc_Admin = new SanPhamSvc_Admin();
		}
		[HttpPost("Create-SanPham")]
		public IActionResult CreateSanPham([FromBody] SanPhamReq sanPhamReq)
		{
			var res = new SingleRsp();
			res = sanPhamSvc_Admin.CreateProduct(sanPhamReq);
			return Ok(res);
		}
		[HttpPost("Search-SanPham")]
		public IActionResult SearchSanPham([FromBody] TimSanPhamReq timSanPhamReq)
		{
			var res = new SingleRsp();
			res = sanPhamSvc_Admin.SearchProduct(timSanPhamReq);
			return Ok(res);
		}
	}
	
}
