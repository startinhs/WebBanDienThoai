using System.Linq;
using WebsiteBanDienThoai23.DAL.Models;

namespace WebsiteBanDienThoai23.Web.Models
{
	public class CartModel
	{
		public string MaSp { get; set; }
		public string TenSp { get; set; }
		public decimal Gia { get; set; }
		public int SoLuong { get; set; }
		public string Hinh { get; set; }
		public short? Ram { get; set; }
		public short? Rom { get; set; }
		public double? ManHinh { get; set; }
		public decimal GiamGia { get; set; }
	}
}