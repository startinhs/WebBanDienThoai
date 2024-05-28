using System.Collections.Generic;
using System;
using WebsiteBanDienThoai23.DAL.Models;

namespace WebsiteBanDienThoai23.AdminWeb.Models
{
    public class BaoHanhModel
    {
        public int MaBh { get; set; }
        public int? MaKh { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public bool? TinhTrangBh { get; set; }

        public List<ChiTietBaoHanh> ChiTietBaoHanh { get; set; }

    }
}
