using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebsiteBanDienThoai23.Common.DAL;
using WebsiteBanDienThoai23.Common.Rsp;
using WebsiteBanDienThoai23.DAL.Models;

namespace WebsiteBanDienThoai23.DAL
{
	public class SanPhamRep_Admin:GenericRep<QLBanDienThoaiContext, SanPham>
	{

        //      public override SanPham Read(string key)
        //{
        //	var res = All.FirstOrDefault(p => p.MaSp == key);
        //	return res;
        //}

        //      public string Remove(string key)
        //      {
        //          var m = All.FirstOrDefault(i => i.MaSp == key);
        //          if (m != null)
        //          {
        //              Context.SanPhams.Remove(m);
        //              Context.SaveChanges();
        //              return m.MaSp;
        //          }
        //          return null;
        //      }
        //      public SingleRsp Remove(string key)
        //      {
        //          var res = new SingleRsp();
        //          try
        //          {
        //              var m = All.FirstOrDefault(i => i.MaSp == key);
        //              if (m != null)
        //              {
        //                  Context.SanPhams.Remove(m);
        //                  Context.SaveChanges();
        //                  res.Data = m.MaSp;
        //                  res.SetMessage("Xóa sản phẩm thành công.");
        //              }
        //              else
        //              {
        //                  res.SetError("Mã sản phẩm không tồn tại.");
        //              }
        //          }
        //          catch (Exception ex)
        //          {
        //              res.SetError($"Lỗi: {ex.Message}, Inner Exception: {ex.InnerException?.Message}, StackTrace: {ex.StackTrace}");
        //          }
        //          return res;
        //      }

        //          public SingleRsp CreateProduct(SanPham product)
        //      {
        //          var res = new SingleRsp();
        //          if (!IsMaLoaiExists(product.MaLoai))
        //          {
        //              res.SetError("Mã loại sản phẩm không tồn tại");
        //              return res;
        //          }
        //          if (IsMaSpExists(product.MaSp))
        //          {
        //              res.SetError("Mã sản phẩm đã tồn tại.");
        //              return res;
        //          }

        //          using (var context = new QLBanDienThoaiContext())
        //          {
        //              using (var tran = context.Database.BeginTransaction())
        //              {
        //                  try
        //                  {
        //                      context.SanPhams.Add(product);
        //                      context.SaveChanges();
        //                      tran.Commit();
        //                  }
        //                  catch (Exception ex)
        //                  {
        //                      tran.Rollback();
        //                      res.SetError($"Lỗi: {ex.Message}, Inner Exception: {ex.InnerException?.Message}, StackTrace: {ex.StackTrace}");
        //                  }
        //              }
        //          }
        //          return res;
        //      }
        //      public SingleRsp UpdateProduct(SanPham product)
        //{
        //	var res = new SingleRsp();
        //	using (var context = new QLBanDienThoaiContext())
        //	{
        //		using (var tran = context.Database.BeginTransaction())
        //		{
        //			try
        //			{
        //				var p = context.SanPhams.Update(product);
        //				context.SaveChanges();
        //				tran.Commit();
        //			}
        //			catch (Exception ex)
        //			{
        //				tran.Rollback();
        //				res.SetError(ex.StackTrace);
        //			}
        //		}
        //	}
        //	return res;
        //}
        //public List<SanPham> PhanTrangSanPham(string keyWord)
        //{

        //	return All.Where(x => x.TenSp.Contains(keyWord)).ToList();
        //}

        //      public List<SanPham> GetAllProducts()
        //      {
        //          return All.ToList();
        //      }
        //      public bool IsMaLoaiExists(string maLoai)
        //      {
        //          return Context.LoaiSps.Any(l => l.MaLoai == maLoai);
        //      }
        //      public bool IsMaSpExists(string maSp)
        //      {
        //          return Context.SanPhams.Any(p => p.MaSp == maSp);
        //      }
        public override SanPham Read(string key)
        {
            var res = All.FirstOrDefault(p => p.MaSp == key);
            return res;
        }
        public SanPham GetSanPhamByMaSp(string maSp)
        {
            SanPham sanPham = null;
            var conn = (SqlConnection)Context.Database.GetDbConnection();
            try
            {
                conn.Open();
                using (var command = conn.CreateCommand())
                {
                    command.CommandText = "sp_GetSanPhamByMaSp";
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@MaSp", maSp));

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            sanPham = new SanPham
                            {
                                MaSp = reader["MaSp"].ToString(),
                                TenSp = reader["TenSp"].ToString(),
                                Hinh1 = reader["Hinh1"].ToString(),
                                Hinh2 = reader["Hinh2"].ToString(),
                                Hinh3 = reader["Hinh3"].ToString(),
                                MoTa = reader["MoTa"].ToString(),
                                TonKho = (bool)reader["TonKho"],
                                SoLuong = (short)reader["SoLuong"],
                                Gia = (decimal)reader["Gia"],
                                ThoiGianBh = (byte)reader["ThoiGianBh"],
                                _5g = (int)reader["_5g"],
                                Cpu = reader["Cpu"].ToString(),
                                Pin = (short)reader["Pin"],
                                SacNhanh = (short)reader["SacNhanh"],
                                Ram = (short)reader["Ram"],
                                Rom = (short)reader["Rom"],
                                ManHinh = (double)reader["ManHinh"],
                                Fps = (short)reader["Fps"],
                                HeDieuHanh = reader["HeDieuHanh"].ToString(),
                                CameraSau = (short)reader["CameraSau"],
                                CameraTruoc = (short)reader["CameraTruoc"],
                                Imel = reader["Imel"].ToString(),
                                GiamGia = (decimal)reader["GiamGia"],
                                MaLoai = reader["MaLoai"].ToString()
                            };
                        }
                    }
                }
            }
            finally
            {
                conn.Close();
            }

            return sanPham;
        }

        public void Remove(SanPham product)
        {
            Context.SanPhams.Remove(product);
            Context.SaveChanges();
        }

        public void CreateProduct(SanPham product)
        {
            Context.SanPhams.Add(product);
            Context.SaveChanges();
        }

        public void UpdateProduct(SanPham product)
        {
            Context.SanPhams.Update(product);
            Context.SaveChanges();
        }

        public bool IsMaSpExists(string maSp)
        {
            return Context.SanPhams.Any(p => p.MaSp == maSp);
        }

        public bool IsMaLoaiExists(string maLoai)
        {
            return Context.LoaiSps.Any(l => l.MaLoai == maLoai);
        }

        public List<SanPham> PhanTrangSanPham(int pageIndex, int pageSize)
        {
            // Tính toán offset (vị trí bắt đầu của sản phẩm trên trang)
            int offset = (pageIndex - 1) * pageSize;

            // Lấy danh sách sản phẩm từ cơ sở dữ liệu và áp dụng phân trang
            return All.Skip(offset).Take(pageSize).ToList();
        }

        public List<SanPham> GetAllProducts()
        {
            return All.ToList();
        }
    }
}
