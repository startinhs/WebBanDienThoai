using System.ComponentModel.DataAnnotations;

namespace WebsiteBanDienThoai23.Web.Models
{
    public class DangKy
    {
        [Required(ErrorMessage = "Vui lòng nhập họ và tên của bạn!")]
        public string HoTen { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập email của bạn!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập địa chỉ của bạn!")]
        public string DiaChi { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập số điện thoại của bạn!")]
        public string Sdt { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập tên tài khoản của bạn!")]
        public string TenTaiKhoan { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập mật khẩu của bạn!")]
        public string MatKhau { get; set; }
        public bool IsAdmin { get; set; }
    }
}
