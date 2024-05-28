using System;
using System.Collections.Generic;
using System.Text;

namespace WebsiteBanDienThoai23.Common.Req
{
    public class BaoHanhReq
    {
        public int MaBh { get; set; }
        public int? MaKh { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public bool? TinhTrangBh { get; set; }
    }
}
