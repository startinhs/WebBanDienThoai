#pragma checksum "D:\LTCSDL\School\Nháp\WebBanDienThoai-main2905\WebBanDienThoai-main\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\BanHang\OrderDetails.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3ba5251591bc68b118007335782bf42714d1bcbbf365cd21cfef5d99895658b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BanHang_OrderDetails), @"mvc.1.0.view", @"/Views/BanHang/OrderDetails.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\LTCSDL\School\Nháp\WebBanDienThoai-main2905\WebBanDienThoai-main\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\_ViewImports.cshtml"
using WebsiteBanDienThoai23.AdminWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\LTCSDL\School\Nháp\WebBanDienThoai-main2905\WebBanDienThoai-main\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\_ViewImports.cshtml"
using WebsiteBanDienThoai23.AdminWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"3ba5251591bc68b118007335782bf42714d1bcbbf365cd21cfef5d99895658b8", @"/Views/BanHang/OrderDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"f942ff79975a8863c487f0f09b48db50db3d75ef251b44188a7a2632a0469e0e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_BanHang_OrderDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebsiteBanDienThoai23.DAL.Models.ChiTietHoaDon>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\LTCSDL\School\Nháp\WebBanDienThoai-main2905\WebBanDienThoai-main\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\BanHang\OrderDetails.cshtml"
  
    ViewData["Title"] = "OrderDetails";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Chi tiết hoá đơn</h1>\n\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>Mã sản phẩm</th>\n            <th>Tên sản phẩm</th>\n            <th>Số lượng đặt hàng</th>\n            <th>Đơn giá</th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 19 "D:\LTCSDL\School\Nháp\WebBanDienThoai-main2905\WebBanDienThoai-main\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\BanHang\OrderDetails.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 22 "D:\LTCSDL\School\Nháp\WebBanDienThoai-main2905\WebBanDienThoai-main\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\BanHang\OrderDetails.cshtml"
               Write(item.MaSpNavigation.MaSp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 23 "D:\LTCSDL\School\Nháp\WebBanDienThoai-main2905\WebBanDienThoai-main\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\BanHang\OrderDetails.cshtml"
               Write(item.MaSpNavigation.TenSp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 24 "D:\LTCSDL\School\Nháp\WebBanDienThoai-main2905\WebBanDienThoai-main\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\BanHang\OrderDetails.cshtml"
               Write(item.SoLuongDatHang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 25 "D:\LTCSDL\School\Nháp\WebBanDienThoai-main2905\WebBanDienThoai-main\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\BanHang\OrderDetails.cshtml"
                Write(item.DonGia.HasValue ? item.DonGia.Value.ToString("N0") + " ₫" : "-");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n");
#nullable restore
#line 27 "D:\LTCSDL\School\Nháp\WebBanDienThoai-main2905\WebBanDienThoai-main\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\BanHang\OrderDetails.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebsiteBanDienThoai23.DAL.Models.ChiTietHoaDon>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
