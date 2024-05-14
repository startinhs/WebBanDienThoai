using System;
using System.Collections.Generic;

#nullable disable

namespace WebsiteBanDienThoai23.DAL.Models
{
    public partial class ChiTietBaoHanh
    {
        public int MaBh { get; set; }
        public string MaSp { get; set; }
        public string Imel { get; set; }

        public virtual BaoHanh MaBhNavigation { get; set; }
        public virtual SanPham MaSpNavigation { get; set; }
    }
}
