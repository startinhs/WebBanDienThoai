using System;
using System.Collections.Generic;

#nullable disable

namespace WebsiteBanDienThoai23.DAL.Models
{
    public partial class SanPham
    {
        public SanPham()
        {
            ChiTietBaoHanhs = new HashSet<ChiTietBaoHanh>();
            ChiTietGioHangs = new HashSet<ChiTietGioHang>();
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
            DanhGia = new HashSet<DanhGia>();
        }

        public string MaSp { get; set; }
        public string TenSp { get; set; }
        public string Hinh1 { get; set; }
        public string Hinh2 { get; set; }
        public string Hinh3 { get; set; }
        public string MoTa { get; set; }
        public bool? TonKho { get; set; }
        public int? SoLuong { get; set; }
        public decimal? Gia { get; set; }
        public DateTime? ThoiGianBh { get; set; }
        public bool? _5g { get; set; }
        public string Cpu { get; set; }
        public int? Pin { get; set; }
        public int? SacNhanh { get; set; }
        public int? Ram { get; set; }
        public int? Rom { get; set; }
        public float? ManHinh { get; set; }
        public int? Fps { get; set; }
        public string HeDieuHanh { get; set; }
        public int? CameraSau { get; set; }
        public int? CameraTruoc { get; set; }
        public string Imel { get; set; }

        public virtual ICollection<ChiTietBaoHanh> ChiTietBaoHanhs { get; set; }
        public virtual ICollection<ChiTietGioHang> ChiTietGioHangs { get; set; }
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public virtual ICollection<DanhGia> DanhGia { get; set; }
    }
}
