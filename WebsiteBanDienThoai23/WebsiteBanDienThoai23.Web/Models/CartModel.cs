using System.Linq;
using WebsiteBanDienThoai23.DAL.Models;

namespace WebsiteBanDienThoai23.Web.Models
{
    public class CartModel
    {
        private readonly QLBanDienThoaiContext da = new QLBanDienThoaiContext();
        public string MaSp { get; set; }
        public string TenSp { get; set; }
        public decimal Gia { get; set; }
        public short SoLuong { get; set; }
        public decimal Tong { get { return Gia * SoLuong; } }
        public CartModel(string id)
        {
            SanPham p = da.Products.FirstOrDefault(s => s.MaSp == id);
            MaSp = p.MaSp;
            TenSp = p.TenSp;
            Gia = p.Gia;
            SoLuong = 1;
        }

    }
}