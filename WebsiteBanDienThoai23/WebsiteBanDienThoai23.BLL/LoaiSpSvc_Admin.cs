using System;
using System.Collections.Generic;
using System.Text;
using WebsiteBanDienThoai23.Common.BLL;
using WebsiteBanDienThoai23.Common.Rsp;
using WebsiteBanDienThoai23.DAL;
using WebsiteBanDienThoai23.DAL.Models;

namespace WebsiteBanDienThoai23.BLL
{
	public class LoaiSpSvc_Admin:GenericSvc<LoaiSpRep_Admin,LoaiSp>
	{
		private LoaiSpRep_Admin loaiSpRep_Admin;
		public LoaiSpSvc_Admin()
		{ 
			loaiSpRep_Admin = new LoaiSpRep_Admin();
		}
		public override SingleRsp Read(string maLoai)
		{
			var res = new SingleRsp();
			res.Data = _rep.Read(maLoai);
			return res;
		}
	}
}
