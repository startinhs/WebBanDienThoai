using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using WebsiteBanDienThoai23.BLL;
using WebsiteBanDienThoai23.Common.Req;
using WebsiteBanDienThoai23.Common.Rsp;

namespace WebsiteBanDienThoai23.AdminWeb.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class LoaiSpController : ControllerBase
	{
		private LoaiSpSvc_Admin loaiSpSvc_Admin;
		public LoaiSpController() 
		{
			loaiSpSvc_Admin = new LoaiSpSvc_Admin();
		}
		[HttpPost("get-by-maLoai")]
		public IActionResult GetLoaiSpBymaLoai([FromBody] SimpleReq simpleReq)
		{
			var res = new SingleRsp();
			res = loaiSpSvc_Admin.Read(simpleReq.Keyword);
			return Ok(res);
		}
	}
}
