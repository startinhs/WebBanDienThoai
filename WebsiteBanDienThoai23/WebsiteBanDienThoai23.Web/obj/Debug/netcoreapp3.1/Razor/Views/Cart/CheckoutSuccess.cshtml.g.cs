#pragma checksum "D:\LTCSDL\School\Nháp\WebBanDienThoai-main\WebBanDienThoai-main\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Cart\CheckoutSuccess.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3014d2b9c1e4243ad46d570f5fc329e1c9fce5d03d86934baa17c9f36a7eea02"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_CheckoutSuccess), @"mvc.1.0.view", @"/Views/Cart/CheckoutSuccess.cshtml")]
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
#line 1 "D:\LTCSDL\School\Nháp\WebBanDienThoai-main\WebBanDienThoai-main\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\_ViewImports.cshtml"
using WebsiteBanDienThoai23.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\LTCSDL\School\Nháp\WebBanDienThoai-main\WebBanDienThoai-main\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\_ViewImports.cshtml"
using WebsiteBanDienThoai23.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"3014d2b9c1e4243ad46d570f5fc329e1c9fce5d03d86934baa17c9f36a7eea02", @"/Views/Cart/CheckoutSuccess.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"4acdeae80e09822e5d9028166823cf9c4922854768a6ca4d6d267b5359c9ee9d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cart_CheckoutSuccess : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"" "">
<link href=""https://fonts.googleapis.com/css?family=Montserrat"" rel=""stylesheet"">
<link rel=""stylesheet"" href=""assets/css/style.css"">

<main class=""page"">
	<section class=""shopping-cart dark"">
		<div class=""container"">
			<div class=""block-heading"">
				<br />
				<h3>Đặt hàng thành công</h3>
			</div>
			<p>Cảm ơn bạn đã mua hàng tại cửa hàng của chúng tôi!</p>
			<a");
            BeginWriteAttribute("href", " href=\"", 474, "\"", 509, 1);
#nullable restore
#line 14 "D:\LTCSDL\School\Nháp\WebBanDienThoai-main\WebBanDienThoai-main\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Cart\CheckoutSuccess.cshtml"
WriteAttributeValue("", 481, Url.Action("Index", "Home"), 481, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Tiếp tục mua sắm</a>\n\t\t</div>\n\t</section>\n</main>\n<br />\n<br />\n\n\n<script src=\"https://code.jquery.com/jquery-3.2.1.min.js\"></script>\n<script src=\"https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js\"></script>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
