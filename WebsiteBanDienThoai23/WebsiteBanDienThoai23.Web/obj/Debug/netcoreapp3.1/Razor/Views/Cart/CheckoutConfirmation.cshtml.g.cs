#pragma checksum "D:\LTCSDL\School\Nháp\WebBanDienThoai-main\WebBanDienThoai-main\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Cart\CheckoutConfirmation.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "094375dc0a1b7d7d411638d0f2bac61bc8987ff4fb6bc918cfbf8ee3c0fa7575"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_CheckoutConfirmation), @"mvc.1.0.view", @"/Views/Cart/CheckoutConfirmation.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"094375dc0a1b7d7d411638d0f2bac61bc8987ff4fb6bc918cfbf8ee3c0fa7575", @"/Views/Cart/CheckoutConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"4acdeae80e09822e5d9028166823cf9c4922854768a6ca4d6d267b5359c9ee9d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cart_CheckoutConfirmation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CartModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "TienMat", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Online", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
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
				<h3>Thông tin đơn hàng</h3>
			</div>
");
#nullable restore
#line 14 "D:\LTCSDL\School\Nháp\WebBanDienThoai-main\WebBanDienThoai-main\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Cart\CheckoutConfirmation.cshtml"
    if (Model != null && Model.Count() > 0)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<div class=\"row\">\n\t\t\t\t\t<div class=\"col-md-12 col-lg-6\">\n\t\t\t\t\t\t<div class=\"content\">\n\t\t\t\t\t\t\t<div>\n\t\t\t\t\t\t\t\t<label for=\"Ten\">Tên:</label>\n\t\t\t\t\t\t\t\t<span>");
#nullable restore
#line 21 "D:\LTCSDL\School\Nháp\WebBanDienThoai-main\WebBanDienThoai-main\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Cart\CheckoutConfirmation.cshtml"
         Write(ViewBag.HoTen);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t<div>\n\t\t\t\t\t\t\t\t<label for=\"SDT\">Số điện thoại:</label>\n\t\t\t\t\t\t\t\t<span>");
#nullable restore
#line 25 "D:\LTCSDL\School\Nháp\WebBanDienThoai-main\WebBanDienThoai-main\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Cart\CheckoutConfirmation.cshtml"
         Write(ViewBag.SDT);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t<div>\n\t\t\t\t\t\t\t\t<label for=\"Email\">Email:</label>\n\t\t\t\t\t\t\t\t<span>");
#nullable restore
#line 29 "D:\LTCSDL\School\Nháp\WebBanDienThoai-main\WebBanDienThoai-main\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Cart\CheckoutConfirmation.cshtml"
         Write(ViewBag.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t<div>\n\t\t\t\t\t\t\t\t<label for=\"DiaChi\">Địa chỉ:</label>\n\t\t\t\t\t\t\t\t<span>");
#nullable restore
#line 33 "D:\LTCSDL\School\Nháp\WebBanDienThoai-main\WebBanDienThoai-main\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Cart\CheckoutConfirmation.cshtml"
         Write(ViewBag.DiaChi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\n\t\t\t\t\t\t\t<div>\n\t\t\t\t\t\t\t\t<label for=\"PhuongThucThanhToan\">Phương thức thanh toán:</label>\n\t\t\t\t\t\t\t\t<select id=\"PhuongThucThanhToan\" name=\"PhuongThucThanhToan\" required>\n\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "094375dc0a1b7d7d411638d0f2bac61bc8987ff4fb6bc918cfbf8ee3c0fa75757465", async() => {
                WriteLiteral("Tiền mặt");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "094375dc0a1b7d7d411638d0f2bac61bc8987ff4fb6bc918cfbf8ee3c0fa75758666", async() => {
                WriteLiteral("Chuyển khoản");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\t\t\t\t\t\t\t\t</select>\n\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t</div>\n\t\t\t\t\t</div>\n\t\t\t\t\t<div class=\"col-md-12 col-lg-6\">\n\t\t\t\t\t\t<div class=\"summary\">\n\t\t\t\t\t\t\t<h3>Thông tin thanh toán</h3>\n\t\t\t\t\t\t\t<div class=\"summary-item\"><span class=\"text\">Tổng số lượng: </span><span class=\"price\">");
#nullable restore
#line 48 "D:\LTCSDL\School\Nháp\WebBanDienThoai-main\WebBanDienThoai-main\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Cart\CheckoutConfirmation.cshtml"
                                                                                         Write(ViewBag.CountProduct);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\n\t\t\t\t\t\t\t<div class=\"summary-item\"><span class=\"text\">Tổng Giá sản phẩm: </span><span class=\"price\">");
#nullable restore
#line 49 "D:\LTCSDL\School\Nháp\WebBanDienThoai-main\WebBanDienThoai-main\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Cart\CheckoutConfirmation.cshtml"
                                                                                             Write(ViewBag.SubTotal.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>₫</span></span></div>\n\t\t\t\t\t\t\t<div class=\"summary-item\"><span class=\"text\">Giảm giá: </span><span class=\"price\">");
#nullable restore
#line 50 "D:\LTCSDL\School\Nháp\WebBanDienThoai-main\WebBanDienThoai-main\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Cart\CheckoutConfirmation.cshtml"
                                                                                    Write(ViewBag.Discount.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>₫</span></span></div>\n\t\t\t\t\t\t\t<div class=\"summary-item\"><span class=\"text\">Phí vận chuyển: </span><span class=\"price\">0<span>₫</span></span></div>\n\t\t\t\t\t\t\t<div class=\"summary-item\"><span class=\"text\">Tổng thành tiền: </span><span class=\"price\">");
#nullable restore
#line 52 "D:\LTCSDL\School\Nháp\WebBanDienThoai-main\WebBanDienThoai-main\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Cart\CheckoutConfirmation.cshtml"
                                                                                           Write(ViewBag.Total.ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>₫</span></span></div>\n\t\t\t\t\t\t\t<br />\n\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "094375dc0a1b7d7d411638d0f2bac61bc8987ff4fb6bc918cfbf8ee3c0fa757512332", async() => {
                WriteLiteral("\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 55 "D:\LTCSDL\School\Nháp\WebBanDienThoai-main\WebBanDienThoai-main\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Cart\CheckoutConfirmation.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\t\t\t\t\t\t\t\t<button type=\"submit\" class=\"btn btn-primary\">Đặt hàng</button>\n\t\t\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 54 "D:\LTCSDL\School\Nháp\WebBanDienThoai-main\WebBanDienThoai-main\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Cart\CheckoutConfirmation.cshtml"
AddHtmlAttributeValue("", 2189, Url.Action("Checkout"), 2189, 23, false);

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
            WriteLiteral("\n\t\t\t\t\t\t\t<br /> \n\t\t\t\t\t\t</div>\n\t\t\t\t\t</div>\n\t\t\t\t</div>\n");
#nullable restore
#line 62 "D:\LTCSDL\School\Nháp\WebBanDienThoai-main\WebBanDienThoai-main\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Cart\CheckoutConfirmation.cshtml"
			}
			else
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<p>Giỏ hàng của bạn đang trống.</p>\n\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 2450, "\"", 2485, 1);
#nullable restore
#line 66 "D:\LTCSDL\School\Nháp\WebBanDienThoai-main\WebBanDienThoai-main\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Cart\CheckoutConfirmation.cshtml"
WriteAttributeValue("", 2457, Url.Action("Index", "Home"), 2457, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Tiếp tục mua sắm</a>\n");
#nullable restore
#line 67 "D:\LTCSDL\School\Nháp\WebBanDienThoai-main\WebBanDienThoai-main\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Cart\CheckoutConfirmation.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t</div>\n\t</section>\n</main>\n\n\n<script src=\"https://code.jquery.com/jquery-3.2.1.min.js\"></script>\n<script src=\"https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js\"></script>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CartModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
