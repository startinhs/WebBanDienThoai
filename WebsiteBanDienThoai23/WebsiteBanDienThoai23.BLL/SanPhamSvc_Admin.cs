using System;
using System.Collections.Generic;
using System.Text;
using WebsiteBanDienThoai23.Common.BLL;
using WebsiteBanDienThoai23.DAL.Models;
using WebsiteBanDienThoai23.DAL;
using System.Linq;
using WebsiteBanDienThoai23.Common.Rsp;
using WebsiteBanDienThoai23.Common.Req;

namespace WebsiteBanDienThoai23.BLL
{
	public class SanPhamSvc_Admin : GenericSvc<SanPhamRep_Admin, SanPham>
	{
		private SanPhamRep_Admin sanPhamRep_Admin;
		public SanPhamSvc_Admin()
		{
			sanPhamRep_Admin = new SanPhamRep_Admin();
		}
	

		public override SingleRsp Read(String key)
		{
			var res = new SingleRsp();

			var m = _rep.Read(key);
			res.Data = m;

			return res;
		}

		public override SingleRsp Update(SanPham m)
		{
			var res = new SingleRsp();

			var m1 = m.MaSp!=null ? _rep.Read(m.MaSp) : _rep.Read(m.MaSp);
			if (m1 == null)
			{
				res.SetError("EZ103", "No data.");
			}
			else
			{
				res = base.Update(m);
				res.Data = m;
			}

			return res;
		}

		//public object SearchProduct(SearchProductReq searchProductReq)
		//{
		//	var products = All.Where(x => x.ProductName.Contains(searchProductReq.Keyword));
		//	var offset = (searchProductReq.Page - 1) * searchProductReq.Size;
		//	var total = products.Count();
		//	int totalPage = (total % searchProductReq.Size) == 0 ? (int)(total / searchProductReq.Size) :
		//		(int)(1 + (total / searchProductReq.Size));
		//	var data = products.OrderBy(x => x.ProductName).Skip(offset).Take(searchProductReq.Size).ToList();
		//	var res = new
		//	{
		//		Data = data,
		//		TotalRecord = total,
		//		TotalPages = totalPage,
		//		Page = searchProductReq.Page,
		//		Size = searchProductReq.Size

		//	};

		//	return res;
		//}

		public SingleRsp CreateProduct(SanPhamReq productReq)
		{
			var res = new SingleRsp();
			SanPham product = new SanPham();
			product.MaSp = productReq.MaSp;
			product.TenSp = productReq.TenSp;
			product.Hinh1 = productReq.Hinh1;
			product.Hinh2 = productReq.Hinh2;
			product.Hinh3 = productReq.Hinh3;
			product.MoTa = productReq.MoTa;
			product.TonKho = productReq.TonKho;
			product.SoLuong = productReq.SoLuong;
			product.Gia = productReq.Gia;
			product.ThoiGianBh = productReq.ThoiGianBh;
			product._5g = productReq._5g;
			product.Cpu = productReq.Cpu;
			product.Pin = productReq.Pin;
			product.SacNhanh = productReq.SacNhanh;
			product.Ram = productReq.Ram;
			product.Rom	= productReq.Rom;
			product.ManHinh = productReq.ManHinh;
			product.Fps = productReq.Fps;
			product.HeDieuHanh = productReq.HeDieuHanh;
			product.CameraSau = productReq.CameraSau;
			product.CameraTruoc = productReq.CameraTruoc;
			product.Imel = productReq.Imel;
			product.GiamGia = productReq.GiamGia;
			product.MaLoai = productReq.MaLoai;
			
			res = sanPhamRep_Admin.CreateProduct(product);
			return res;
		}

		public SingleRsp SearchProduct(TimSanPhamReq)
		{
			var res = new SingleRsp();
			return res;
		}
		//public SingleRsp UpdateProduct(ProductReq productReq)
		//{
		//	var res = new SingleRsp();
		//	Product product = new Product();
		//	product.ProductId = productReq.ProductId;
		//	product.ProductName = productReq.ProductName;
		//	product.UnitPrice = productReq.UnitPrice;
		//	product.UnitsInStock = productReq.UnitsInStock;
		//	res = req.UpdateProduct(product);
		//	return res;
		//}

	}
}
