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
		public override SanPham Read(string key)
		{
			var res = All.FirstOrDefault(p => p.MaSp == key);
			return res;
		}

		public string Remove(string key)
		{
			var m = base.All.First(i => i.MaSp == key);
			m = base.Delete(m);
			return m.MaSp;
		}

		public SingleRsp CreateProduct(SanPham product)
		{
			var res = new SingleRsp();
			using (var context = new QLBanDienThoaiContext())
			{
				using (var tran = context.Database.BeginTransaction())
				{
					try
					{
						var p = context.SanPhams.Add(product);
						context.SaveChanges();
						tran.Commit();
					}
					catch (Exception ex)
					{
						tran.Rollback();
						res.SetError(ex.StackTrace);
					}
				}
			}
			return res;
		}
		public SingleRsp UpdateProduct(SanPham product)
		{
			var res = new SingleRsp();
			using (var context = new QLBanDienThoaiContext())
			{
				using (var tran = context.Database.BeginTransaction())
				{
					try
					{
						var p = context.SanPhams.Update(product);
						context.SaveChanges();
						tran.Commit();
					}
					catch (Exception ex)
					{
						tran.Rollback();
						res.SetError(ex.StackTrace);
					}
				}
			}
			return res;
		}
		public List<SanPham> SearchProduct(string keyWord)
		{
			
			return All.Where(x => x.TenSp.Contains(keyWord)).ToList();
		}

	}
}
