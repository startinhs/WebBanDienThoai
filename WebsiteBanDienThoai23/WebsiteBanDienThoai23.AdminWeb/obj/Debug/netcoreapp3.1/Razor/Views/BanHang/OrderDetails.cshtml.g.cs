#pragma checksum "D:\Documents\IM_OU_K21\232\LTCSDL_DBDEV\BTL\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\BanHang\OrderDetails.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1d9a5ecaea141e621ba9346e605af3ec533873c5487bd6e1e5a45e674393d32f"
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
#line 1 "D:\Documents\IM_OU_K21\232\LTCSDL_DBDEV\BTL\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\_ViewImports.cshtml"
using WebsiteBanDienThoai23.AdminWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Documents\IM_OU_K21\232\LTCSDL_DBDEV\BTL\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\_ViewImports.cshtml"
using WebsiteBanDienThoai23.AdminWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"1d9a5ecaea141e621ba9346e605af3ec533873c5487bd6e1e5a45e674393d32f", @"/Views/BanHang/OrderDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"f942ff79975a8863c487f0f09b48db50db3d75ef251b44188a7a2632a0469e0e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_BanHang_OrderDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebsiteBanDienThoai23.DAL.Models.ChiTietHoaDon>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Documents\IM_OU_K21\232\LTCSDL_DBDEV\BTL\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\BanHang\OrderDetails.cshtml"
  
    ViewData["Title"] = "OrderDetails";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Chi tiết hoá đơn</h1>

<table class=""table"">
    <thead>
        <tr>
            <th>Mã sản phẩm</th>
            <th>Tên sản phẩm</th>
            <th>Số lượng đặt hàng</th>
            <th>Đơn giá</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 19 "D:\Documents\IM_OU_K21\232\LTCSDL_DBDEV\BTL\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\BanHang\OrderDetails.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 22 "D:\Documents\IM_OU_K21\232\LTCSDL_DBDEV\BTL\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\BanHang\OrderDetails.cshtml"
               Write(item.MaSpNavigation.MaSp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "D:\Documents\IM_OU_K21\232\LTCSDL_DBDEV\BTL\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\BanHang\OrderDetails.cshtml"
               Write(item.MaSpNavigation.TenSp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "D:\Documents\IM_OU_K21\232\LTCSDL_DBDEV\BTL\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\BanHang\OrderDetails.cshtml"
               Write(item.SoLuongDatHang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "D:\Documents\IM_OU_K21\232\LTCSDL_DBDEV\BTL\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\BanHang\OrderDetails.cshtml"
                Write(item.DonGia.HasValue ? item.DonGia.Value.ToString("N0") + " ₫" : "-");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 27 "D:\Documents\IM_OU_K21\232\LTCSDL_DBDEV\BTL\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\BanHang\OrderDetails.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
