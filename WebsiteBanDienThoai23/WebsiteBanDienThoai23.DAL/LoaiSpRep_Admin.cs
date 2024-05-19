using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebsiteBanDienThoai23.Common.DAL;
using WebsiteBanDienThoai23.DAL.Models;

namespace WebsiteBanDienThoai23.DAL
{
	public class LoaiSpRep_Admin:GenericRep<QLBanDienThoaiContext,LoaiSp>
	{
		public LoaiSpRep_Admin() 
		{

		}
		public override LoaiSp Read(string maLoai)
		{
			var res = All.FirstOrDefault(l => l.MaLoai == maLoai);
			return res;
		}
	}
}
