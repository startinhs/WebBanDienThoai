#pragma checksum "D:\Documents\IM_OU_K21\232\LTCSDL_DBDEV\BTL\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Cart\ListCarts.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "15301968fbdea3e58f7940ec75429a14a26e51401148732f63474c2ef5ba0438"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_ListCarts), @"mvc.1.0.view", @"/Views/Cart/ListCarts.cshtml")]
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
#line 1 "D:\Documents\IM_OU_K21\232\LTCSDL_DBDEV\BTL\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\_ViewImports.cshtml"
using WebsiteBanDienThoai23.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Documents\IM_OU_K21\232\LTCSDL_DBDEV\BTL\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\_ViewImports.cshtml"
using WebsiteBanDienThoai23.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"15301968fbdea3e58f7940ec75429a14a26e51401148732f63474c2ef5ba0438", @"/Views/Cart/ListCarts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"4acdeae80e09822e5d9028166823cf9c4922854768a6ca4d6d267b5359c9ee9d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cart_ListCarts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebsiteBanDienThoai23.Web.Models.CartModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid mx-auto d-block image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
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
				<h2>Giỏ hàng của bạn</h2>
			</div>
");
#nullable restore
#line 15 "D:\Documents\IM_OU_K21\232\LTCSDL_DBDEV\BTL\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Cart\ListCarts.cshtml"
    if (Model != null && Model.Count() > 0)
			{ 

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<div class=\"content\">\n\t\t\t\t<div class=\"row\">\n\t\t\t\t\t<div class=\"col-md-12 col-lg-8\">\n\t\t\t\t\t\t<div class=\"items\">\n\t\t\t\t\t\t\t<br />\n");
#nullable restore
#line 22 "D:\Documents\IM_OU_K21\232\LTCSDL_DBDEV\BTL\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Cart\ListCarts.cshtml"
        foreach (var item in Model)
							{


#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<div class=\"product\">\n\t\t\t\t\t\t\t\t\t<div class=\"row\">\n\t\t\t\t\t\t\t\t\t\t<div class=\"col-md-3\">\n\t\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "15301968fbdea3e58f7940ec75429a14a26e51401148732f63474c2ef5ba04385223", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 841, "~/imgProduct/", 841, 13, true);
#nullable restore
#line 28 "D:\Documents\IM_OU_K21\232\LTCSDL_DBDEV\BTL\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Cart\ListCarts.cshtml"
AddHtmlAttributeValue("", 854, item.Hinh, 854, 10, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\t\t\t\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t\t\t\t<div class=\"col-md-8\">\n\t\t\t\t\t\t\t\t\t\t\t<div class=\"info\">\n\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"row\">\n\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"col-md-5 product-name\">\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"product-name\">\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<a href=\"#\">");
#nullable restore
#line 35 "D:\Documents\IM_OU_K21\232\LTCSDL_DBDEV\BTL\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Cart\ListCarts.cshtml"
                      Write(item.TenSp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"product-info\">\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<div>Màn hình: <span class=\"value\">");
#nullable restore
#line 37 "D:\Documents\IM_OU_K21\232\LTCSDL_DBDEV\BTL\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Cart\ListCarts.cshtml"
                                              Write(Math.Round(item.ManHinh.Value, 1));

#line default
#line hidden
#nullable disable
            WriteLiteral(" inch</span></div>\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<div>RAM: <span class=\"value\">");
#nullable restore
#line 38 "D:\Documents\IM_OU_K21\232\LTCSDL_DBDEV\BTL\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Cart\ListCarts.cshtml"
                                         Write(item.Ram);

#line default
#line hidden
#nullable disable
            WriteLiteral(" GB</span></div>\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<div>ROM: <span class=\"value\">");
#nullable restore
#line 39 "D:\Documents\IM_OU_K21\232\LTCSDL_DBDEV\BTL\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Cart\ListCarts.cshtml"
                                         Write(item.Rom);

#line default
#line hidden
#nullable disable
            WriteLiteral(" GB</span></div>\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"col-md-4 quantity\">\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<label for=\"quantity\">Số lượng:</label>\n");
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t\t<span>");
#nullable restore
#line 46 "D:\Documents\IM_OU_K21\232\LTCSDL_DBDEV\BTL\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Cart\ListCarts.cshtml"
               Write(item.SoLuong);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"col-md-3 price\">\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<label for=\"quantity\">Giá:</label>\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<span>");
#nullable restore
#line 50 "D:\Documents\IM_OU_K21\232\LTCSDL_DBDEV\BTL\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Cart\ListCarts.cshtml"
               Write(item.Gia.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>₫</span></span>\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t\t<br>\n");
#nullable restore
#line 58 "D:\Documents\IM_OU_K21\232\LTCSDL_DBDEV\BTL\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Cart\ListCarts.cshtml"
							}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t</div>\n\t\t\t\t\t</div>\n\t\t\t\t\t<div class=\"col-md-12 col-lg-4\">\n\t\t\t\t\t\t<div class=\"summary\">\n\t\t\t\t\t\t\t<h3>Thông tin cần thanh toán</h3>\n\t\t\t\t\t\t\t<br />\n\t\t\t\t\t\t\t<div class=\"summary-item\"><span class=\"text\">Tổng số lượng: </span><span class=\"price\">");
#nullable restore
#line 65 "D:\Documents\IM_OU_K21\232\LTCSDL_DBDEV\BTL\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Cart\ListCarts.cshtml"
                                                                                         Write(ViewBag.CountProduct);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\n\t\t\t\t\t\t\t<div class=\"summary-item\"><span class=\"text\">Tổng Giá sản phẩm: </span><span class=\"price\">");
#nullable restore
#line 66 "D:\Documents\IM_OU_K21\232\LTCSDL_DBDEV\BTL\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Cart\ListCarts.cshtml"
                                                                                             Write(ViewBag.SubTotal.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>₫</span></span></div>\n\t\t\t\t\t\t\t<div class=\"summary-item\"><span class=\"text\">Giảm giá: </span><span class=\"price\">");
#nullable restore
#line 67 "D:\Documents\IM_OU_K21\232\LTCSDL_DBDEV\BTL\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Cart\ListCarts.cshtml"
                                                                                    Write(ViewBag.Discount.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>₫</span></span></div>\n\t\t\t\t\t\t\t<div class=\"summary-item\"><span class=\"text\">Phí vận chuyển: </span><span class=\"price\">0<span>₫</span></span></div>\n\t\t\t\t\t\t\t<div class=\"summary-item\"><span class=\"text\">Tổng thành tiền: </span><span class=\"price\">");
#nullable restore
#line 69 "D:\Documents\IM_OU_K21\232\LTCSDL_DBDEV\BTL\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Cart\ListCarts.cshtml"
                                                                                           Write(ViewBag.Total.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>₫</span></span></div>\n\t\t\t\t\t\t\t<br /> <br />\n");
#nullable restore
#line 72 "D:\Documents\IM_OU_K21\232\LTCSDL_DBDEV\BTL\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Cart\ListCarts.cshtml"
         if (User.Identity.IsAuthenticated)
								{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t<!-- Nút để chuyển hướng đến trang Checkout -->\n\t\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 3109, "\"", 3147, 1);
#nullable restore
#line 75 "D:\Documents\IM_OU_K21\232\LTCSDL_DBDEV\BTL\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Cart\ListCarts.cshtml"
WriteAttributeValue("", 3116, Url.Action("Checkout", "Cart"), 3116, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Thanh toán</a>\n");
#nullable restore
#line 76 "D:\Documents\IM_OU_K21\232\LTCSDL_DBDEV\BTL\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Cart\ListCarts.cshtml"
								}
								else
								{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t<!-- Nút để chuyển hướng đến trang đăng nhập -->\n\t\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 3292, "\"", 3386, 1);
#nullable restore
#line 80 "D:\Documents\IM_OU_K21\232\LTCSDL_DBDEV\BTL\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Cart\ListCarts.cshtml"
WriteAttributeValue("", 3299, Url.Action("DangNhap", "Account", new { ReturnUrl = Url.Action("ListCarts", "Cart") }), 3299, 87, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Đăng nhập để thanh toán</a>\n");
#nullable restore
#line 81 "D:\Documents\IM_OU_K21\232\LTCSDL_DBDEV\BTL\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Cart\ListCarts.cshtml"
								}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<br /> <br />\n\t\t\t\t\t\t</div>\n\t\t\t\t\t</div>\n\t\t\t\t</div>\n\t\t\t</div>\n");
#nullable restore
#line 87 "D:\Documents\IM_OU_K21\232\LTCSDL_DBDEV\BTL\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Cart\ListCarts.cshtml"
			}
			else
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<p>Giỏ hàng của bạn đang trống.</p>\n\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 3582, "\"", 3617, 1);
#nullable restore
#line 91 "D:\Documents\IM_OU_K21\232\LTCSDL_DBDEV\BTL\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Cart\ListCarts.cshtml"
WriteAttributeValue("", 3589, Url.Action("Index", "Home"), 3589, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Tiếp tục mua sắm</a>\n");
#nullable restore
#line 92 "D:\Documents\IM_OU_K21\232\LTCSDL_DBDEV\BTL\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Cart\ListCarts.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t</div>\n\t</section>\n</main>\n\n<script src=\"https://code.jquery.com/jquery-3.2.1.min.js\"></script>\n<script src=\"https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js\"></script>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebsiteBanDienThoai23.Web.Models.CartModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
