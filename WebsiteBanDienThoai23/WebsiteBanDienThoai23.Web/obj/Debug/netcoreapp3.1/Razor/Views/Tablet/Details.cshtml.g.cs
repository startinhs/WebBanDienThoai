#pragma checksum "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Tablet\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7c51904f4b9ef98f994c4bcf36ec1f0ebffbc59f66519d547aec5fe62afa5f03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tablet_Details), @"mvc.1.0.view", @"/Views/Tablet/Details.cshtml")]
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
#line 1 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\_ViewImports.cshtml"
using WebsiteBanDienThoai23.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\_ViewImports.cshtml"
using WebsiteBanDienThoai23.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"7c51904f4b9ef98f994c4bcf36ec1f0ebffbc59f66519d547aec5fe62afa5f03", @"/Views/Tablet/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"bffacd078e3ebaa0c85b5c20d96c590381f13122720a73ba505ee568c3fddc26", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Tablet_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebsiteBanDienThoai23.DAL.Models.SanPham>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Tablet\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>SanPham</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
#nullable restore
#line 14 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Tablet\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TenSp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 17 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Tablet\Details.cshtml"
       Write(Html.DisplayFor(model => model.TenSp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 20 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Tablet\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Hinh1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 23 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Tablet\Details.cshtml"
       Write(Html.DisplayFor(model => model.Hinh1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 26 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Tablet\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Hinh2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 29 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Tablet\Details.cshtml"
       Write(Html.DisplayFor(model => model.Hinh2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 32 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Tablet\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Hinh3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 35 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Tablet\Details.cshtml"
       Write(Html.DisplayFor(model => model.Hinh3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 38 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Tablet\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MoTa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 41 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Tablet\Details.cshtml"
       Write(Html.DisplayFor(model => model.MoTa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 44 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Tablet\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TonKho));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 47 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Tablet\Details.cshtml"
       Write(Html.DisplayFor(model => model.TonKho));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 50 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Tablet\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SoLuong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 53 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Tablet\Details.cshtml"
       Write(Html.DisplayFor(model => model.SoLuong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 56 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Tablet\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Gia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 59 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Tablet\Details.cshtml"
       Write(Html.DisplayFor(model => model.Gia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 62 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Tablet\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ThoiGianBh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 65 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Tablet\Details.cshtml"
       Write(Html.DisplayFor(model => model.ThoiGianBh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 68 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Tablet\Details.cshtml"
       Write(Html.DisplayNameFor(model => model._5g));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 71 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Tablet\Details.cshtml"
       Write(Html.DisplayFor(model => model._5g));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 74 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Tablet\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cpu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 77 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Tablet\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cpu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 80 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Tablet\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Pin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 83 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Tablet\Details.cshtml"
       Write(Html.DisplayFor(model => model.Pin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 86 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Tablet\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SacNhanh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 89 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Tablet\Details.cshtml"
       Write(Html.DisplayFor(model => model.SacNhanh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 92 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Tablet\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Ram));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 95 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Tablet\Details.cshtml"
       Write(Html.DisplayFor(model => model.Ram));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 98 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Tablet\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Rom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 101 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Tablet\Details.cshtml"
       Write(Html.DisplayFor(model => model.Rom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 104 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Tablet\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ManHinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 107 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Tablet\Details.cshtml"
       Write(Html.DisplayFor(model => model.ManHinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 110 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Tablet\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Fps));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 113 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Tablet\Details.cshtml"
       Write(Html.DisplayFor(model => model.Fps));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 116 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Tablet\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HeDieuHanh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 119 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Tablet\Details.cshtml"
       Write(Html.DisplayFor(model => model.HeDieuHanh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 122 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Tablet\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CameraSau));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 125 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Tablet\Details.cshtml"
       Write(Html.DisplayFor(model => model.CameraSau));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 128 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Tablet\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CameraTruoc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 131 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Tablet\Details.cshtml"
       Write(Html.DisplayFor(model => model.CameraTruoc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 134 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Tablet\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Imel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 137 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Tablet\Details.cshtml"
       Write(Html.DisplayFor(model => model.Imel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 140 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Tablet\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.GiamGia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 143 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Tablet\Details.cshtml"
       Write(Html.DisplayFor(model => model.GiamGia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 146 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Tablet\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaLoaiNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
#nullable restore
#line 149 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Tablet\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaLoaiNavigation.MaLoai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c51904f4b9ef98f994c4bcf36ec1f0ebffbc59f66519d547aec5fe62afa5f0319129", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 154 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\Tablet\Details.cshtml"
                           WriteLiteral(Model.MaSp);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c51904f4b9ef98f994c4bcf36ec1f0ebffbc59f66519d547aec5fe62afa5f0321321", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebsiteBanDienThoai23.DAL.Models.SanPham> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
