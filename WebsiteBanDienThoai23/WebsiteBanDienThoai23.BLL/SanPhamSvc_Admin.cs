//using System;
//using System.Collections.Generic;
//using System.Text;
//using WebsiteBanDienThoai23.Common.BLL;
//using WebsiteBanDienThoai23.DAL.Models;
//using WebsiteBanDienThoai23.DAL;
//using System.Linq;
//using WebsiteBanDienThoai23.Common.Rsp;
//using WebsiteBanDienThoai23.Common.Req;

//namespace WebsiteBanDienThoai23.BLL
//{
//	public class SanPhamSvc_Admin : GenericSvc<SanPhamRep_Admin, SanPham>
//	{
//		private SanPhamRep_Admin sanPhamRep_Admin;
//		public SanPhamSvc_Admin()
//		{
//			sanPhamRep_Admin = new SanPhamRep_Admin();
//		}

//        public override SingleRsp Read(string maSp)
//        {
//            var res = new SingleRsp();
//            res.Data = _rep.Read(maSp);
//            return res;

//        }
//        //public override SingleRsp Read(String key)
//        //{
//        //          var res = new SingleRsp();
//        //          res.Data = _rep.Read(key);
//        //          return res;
//        //      }

//        public override SingleRsp Update(SanPham m)
//		{
//			var res = new SingleRsp();

//			var m1 = m.MaSp!=null ? _rep.Read(m.MaSp) : _rep.Read(m.MaSp);
//			if (m1 == null)
//			{
//				res.SetError("EZ103", "No data.");
//			}
//			else
//			{
//				res = base.Update(m);
//				res.Data = m;
//			}

//			return res;
//		}

//		public SingleRsp CreateProduct(SanPhamReq productReq)
//		{
//			var res = new SingleRsp();
//			SanPham product = new SanPham();
//			product.MaSp = productReq.MaSp;
//			product.TenSp = productReq.TenSp;
//			product.Hinh1 = productReq.Hinh1;
//			product.MoTa = productReq.MoTa;
//			product.TonKho = (bool)productReq.TonKho;
//			product.SoLuong = (short)productReq.SoLuong;
//			product.Gia = (decimal)productReq.Gia;
//			product.ThoiGianBh = productReq.ThoiGianBh;
//			product._5g = productReq._5g;
//			product.Cpu = productReq.Cpu;
//			product.Pin = productReq.Pin;
//			product.SacNhanh = productReq.SacNhanh;
//			product.Ram = productReq.Ram;
//			product.Rom	= productReq.Rom;
//			product.ManHinh = productReq.ManHinh;
//			product.Fps = productReq.Fps;
//			product.HeDieuHanh = productReq.HeDieuHanh;
//			product.CameraSau = productReq.CameraSau;
//			product.CameraTruoc = productReq.CameraTruoc;
//			product.Imel = productReq.Imel;
//			product.GiamGia = (decimal)productReq.GiamGia;
//			product.MaLoai = productReq.MaLoai;

//			res = sanPhamRep_Admin.CreateProduct(product);
//			return res;
//		}

//		public SingleRsp PhanTrangSanPham(TimSanPhamReq s)
//		{
//			var res = new SingleRsp();

//			var product = sanPhamRep_Admin.PhanTrangSanPham(s.keyWord);
//			int pCount, totalPages,offset;
//			offset = s.size * (s.page - 1);
//			pCount = product.Count;
//			totalPages = (pCount % s.size) == 0 ? pCount / s.size : 1 + (pCount / s.size);
//			var p = new
//			{
//				Data = product.Skip(offset).Take(s.size).ToList(),
//				page = s.page,
//				size = s.size
//			};
//			res.Data = p;
//			return res;
//		}

//        public SingleRsp GetAllProducts()
//        {
//            var res = new SingleRsp();
//            var products = sanPhamRep_Admin.GetAllProducts();
//            res.Data = products;
//            return res;
//        }

//        public SingleRsp RemoveProduct(string maSp)
//        {
//            var res = new SingleRsp();

//            res.Data = sanPhamRep_Admin.Remove(maSp);

//            return res;
//        }
//        public SingleRsp UpdateProduct(SanPhamReq productReq)
//        {
//            var res = new SingleRsp();
//            var product = sanPhamRep_Admin.Read(productReq.MaSp);
//            if (product == null)
//            {
//                res.SetError("EZ106", "No data found for the specified product ID.");
//            }
//            else
//            {
//                product.TenSp = productReq.TenSp;
//                product.Hinh1 = productReq.Hinh1;
//                product.Hinh2 = productReq.Hinh2;
//                product.Hinh3 = productReq.Hinh3;
//                product.MoTa = productReq.MoTa;
//                product.TonKho = (bool)productReq.TonKho;
//                product.SoLuong = (short)productReq.SoLuong;
//                product.Gia = (decimal)productReq.Gia;
//                product.ThoiGianBh = productReq.ThoiGianBh;
//                product._5g = productReq._5g;
//                product.Cpu = productReq.Cpu;
//                product.Pin = productReq.Pin;
//                product.SacNhanh = productReq.SacNhanh;
//                product.Ram = productReq.Ram;
//                product.Rom = productReq.Rom;
//                product.ManHinh = productReq.ManHinh;
//                product.Fps = productReq.Fps;
//                product.HeDieuHanh = productReq.HeDieuHanh;
//                product.CameraSau = productReq.CameraSau;
//                product.CameraTruoc = productReq.CameraTruoc;
//                product.Imel = productReq.Imel;
//                product.GiamGia = (decimal)productReq.GiamGia;
//                product.MaLoai = productReq.MaLoai;

//                res = sanPhamRep_Admin.UpdateProduct(product);
//            }
//            return res;
//        }




//    }
//}
using System;
using System.Collections.Generic;
using System.Linq;
using WebsiteBanDienThoai23.Common.BLL;
using WebsiteBanDienThoai23.Common.Rsp;
using WebsiteBanDienThoai23.Common.Req;
using WebsiteBanDienThoai23.DAL.Models;
using WebsiteBanDienThoai23.DAL;

namespace WebsiteBanDienThoai23.BLL
{
    public class SanPhamSvc_Admin : GenericSvc<SanPhamRep_Admin, SanPham>
    {
        private SanPhamRep_Admin sanPhamRep_Admin;

        public SanPhamSvc_Admin()
        {
            sanPhamRep_Admin = new SanPhamRep_Admin();
        }

        public override SingleRsp Read(string maSp)
        {
            var res = new SingleRsp();
            res.Data = _rep.Read(maSp);
            return res;
        }


        public SingleRsp CreateProduct(SanPhamReq productReq)
        {
            var res = new SingleRsp();
            var product = new SanPham
            {
                MaSp = productReq.MaSp,
                TenSp = productReq.TenSp,
                Hinh1 = productReq.Hinh1,
                Hinh2 = productReq.Hinh2,
                Hinh3 = productReq.Hinh3,
                MoTa = productReq.MoTa,
                TonKho = productReq.TonKho,
                SoLuong = productReq.SoLuong,
                Gia = productReq.Gia,
                ThoiGianBh = productReq.ThoiGianBh,
                _5g = productReq._5g,
                Cpu = productReq.Cpu,
                Pin = productReq.Pin,
                SacNhanh = productReq.SacNhanh,
                Ram = productReq.Ram,
                Rom = productReq.Rom,
                ManHinh = productReq.ManHinh,
                Fps = productReq.Fps,
                HeDieuHanh = productReq.HeDieuHanh,
                CameraSau = productReq.CameraSau,
                CameraTruoc = productReq.CameraTruoc,
                Imel = productReq.Imel,
                GiamGia = productReq.GiamGia,
                MaLoai = productReq.MaLoai
            };

            if (!_rep.IsMaLoaiExists(product.MaLoai))
            {
                res.SetError("Mã loại sản phẩm không tồn tại.");
                return res;
            }

            if (_rep.IsMaSpExists(product.MaSp))
            {
                res.SetError("Mã sản phẩm đã tồn tại.");
                return res;
            }

            try
            {
                _rep.CreateProduct(product);
                res.Data = product;
                res.SetMessage("Đã thêm thành công sản phẩm!");
            }
            catch (Exception ex)
            {
                res.SetError($"Lỗi: {ex.Message}, Inner Exception: {ex.InnerException?.Message}, StackTrace: {ex.StackTrace}");
            }

            return res;
        }

        //public SingleRsp PhanTrangSanPham(TimSanPhamReq s)
        //{
        //    var res = new SingleRsp();

        //    var product = sanPhamRep_Admin.PhanTrangSanPham(s.keyWord);
        //    int pCount, totalPages, offset;
        //    offset = s.size * (s.page - 1);
        //    pCount = product.Count;
        //    totalPages = (pCount % s.size) == 0 ? pCount / s.size : 1 + (pCount / s.size);
        //    var p = new
        //    {
        //        Data = product.Skip(offset).Take(s.size).ToList(),
        //        page = s.page,
        //        size = s.size
        //    };
        //    res.Data = p;
        //    res.Success(")
        //    return res;
        //}
        public SingleRsp PhanTrangSanPham(int pageIndex, int pageSize)
        {
            var res = new SingleRsp();

            // Gọi phương thức PhanTrangSanPham từ DAL để lấy danh sách sản phẩm phân trang
            var products = _rep.PhanTrangSanPham(pageIndex, pageSize);

            // Chuẩn bị dữ liệu trả về
            var p = new
            {
                Data = products,
                PageIndex = pageIndex,
                PageSize = pageSize
            };

            // Gán dữ liệu vào đối tượng SingleRsp
            res.Data = p;

            return res;
        }


        public SingleRsp GetAllProducts()
        {
            var res = new SingleRsp();
            var products = _rep.GetAllProducts();
            res.Data = products;
            return res;
        }

        public SingleRsp RemoveProduct(string maSp)
        {
            var res = new SingleRsp();
            var product = _rep.Read(maSp);
            if (product == null)
            {
                res.SetError("Không tìm thấy mã sản phẩm cần xóa");
            }
            else
            {
                try
                {
                    _rep.Remove(product);
                    res.SetMessage("Xóa sản phẩm thành công.");
                }
                catch (Exception ex)
                {
                    res.SetError($"Lỗi: {ex.Message}, Inner Exception: {ex.InnerException?.Message}, StackTrace: {ex.StackTrace}");
                }
            }
            return res;
        }

        public SingleRsp UpdateProduct(SanPhamReq productReq)
        {
            var res = new SingleRsp();
            var product = _rep.Read(productReq.MaSp);
            if (product == null)
            {
                res.SetError("EZ106", "Không tìm thấy dữ liệu cho mã sản phẩm được chỉ định.");
            }
            else
            {
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
                product.Rom = productReq.Rom;
                product.ManHinh = productReq.ManHinh;
                product.Fps = productReq.Fps;
                product.HeDieuHanh = productReq.HeDieuHanh;
                product.CameraSau = productReq.CameraSau;
                product.CameraTruoc = productReq.CameraTruoc;
                product.Imel = productReq.Imel;
                product.GiamGia = productReq.GiamGia;
                product.MaLoai = productReq.MaLoai;
                if (!sanPhamRep_Admin.IsMaLoaiExists(productReq.MaLoai))
                {
                    res.SetError("Mã loại sản phẩm không tồn tại.");
                    return res;
                }

                try
                {
                    _rep.UpdateProduct(product);
                    res.SetMessage("Cập nhật sản phẩm thành công");
                }
                catch (Exception ex)
                {
                    res.SetError($"Lỗi: {ex.Message}, Inner Exception: {ex.InnerException?.Message}, StackTrace: {ex.StackTrace}");
                }
            }
            return res;
        }
        public SingleRsp GetSanPhamByMaSp(string maSp)
        {
            var res = new SingleRsp();
            var sanPham = sanPhamRep_Admin.GetSanPhamByMaSp(maSp);

            if (sanPham == null)
            {
                res.SetError("Không tìm thấy sản phẩm với mã sản phẩm được chỉ định.");
            }
            else
            {
                res.Data = sanPham;
                res.SetMessage("Tìm thấy sản phẩm!");
                
            }
            return res;


        }
    }
}

