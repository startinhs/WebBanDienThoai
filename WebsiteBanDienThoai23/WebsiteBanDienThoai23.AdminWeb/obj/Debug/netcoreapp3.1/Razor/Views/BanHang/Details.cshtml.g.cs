#pragma checksum "D:\LTCSDL\School\Nháp\WebBanDienThoai-main\WebBanDienThoai-main\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\BanHang\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "de149e023d666c11e3551e852e9adff8c888b749b29032bc8a2cd2314cea420d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BanHang_Details), @"mvc.1.0.view", @"/Views/BanHang/Details.cshtml")]
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
#line 1 "D:\LTCSDL\School\Nháp\WebBanDienThoai-main\WebBanDienThoai-main\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\_ViewImports.cshtml"
using WebsiteBanDienThoai23.AdminWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\LTCSDL\School\Nháp\WebBanDienThoai-main\WebBanDienThoai-main\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\_ViewImports.cshtml"
using WebsiteBanDienThoai23.AdminWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"de149e023d666c11e3551e852e9adff8c888b749b29032bc8a2cd2314cea420d", @"/Views/BanHang/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"f942ff79975a8863c487f0f09b48db50db3d75ef251b44188a7a2632a0469e0e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_BanHang_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebsiteBanDienThoai23.DAL.Models.HoaDon>
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
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\LTCSDL\School\Nháp\WebBanDienThoai-main\WebBanDienThoai-main\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\BanHang\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Details</h1>\n\n<div>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 13 "D:\LTCSDL\School\Nháp\WebBanDienThoai-main\WebBanDienThoai-main\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\BanHang\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NgayDatHang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 16 "D:\LTCSDL\School\Nháp\WebBanDienThoai-main\WebBanDienThoai-main\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\BanHang\Details.cshtml"
       Write(Html.DisplayFor(model => model.NgayDatHang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 19 "D:\LTCSDL\School\Nháp\WebBanDienThoai-main\WebBanDienThoai-main\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\BanHang\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DiaChiGiaoHang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 22 "D:\LTCSDL\School\Nháp\WebBanDienThoai-main\WebBanDienThoai-main\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\BanHang\Details.cshtml"
       Write(Html.DisplayFor(model => model.DiaChiGiaoHang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 25 "D:\LTCSDL\School\Nháp\WebBanDienThoai-main\WebBanDienThoai-main\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\BanHang\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TongGiaTri));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 28 "D:\LTCSDL\School\Nháp\WebBanDienThoai-main\WebBanDienThoai-main\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\BanHang\Details.cshtml"
       Write(Html.DisplayFor(model => model.TongGiaTri));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 31 "D:\LTCSDL\School\Nháp\WebBanDienThoai-main\WebBanDienThoai-main\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\BanHang\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TrangThaiTt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 34 "D:\LTCSDL\School\Nháp\WebBanDienThoai-main\WebBanDienThoai-main\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\BanHang\Details.cshtml"
       Write(Html.DisplayFor(model => model.TrangThaiTt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 37 "D:\LTCSDL\School\Nháp\WebBanDienThoai-main\WebBanDienThoai-main\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\BanHang\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TrangThaiDh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 40 "D:\LTCSDL\School\Nháp\WebBanDienThoai-main\WebBanDienThoai-main\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\BanHang\Details.cshtml"
       Write(Html.DisplayFor(model => model.TrangThaiDh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 43 "D:\LTCSDL\School\Nháp\WebBanDienThoai-main\WebBanDienThoai-main\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\BanHang\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NgayNhanHang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 46 "D:\LTCSDL\School\Nháp\WebBanDienThoai-main\WebBanDienThoai-main\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\BanHang\Details.cshtml"
       Write(Html.DisplayFor(model => model.NgayNhanHang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 49 "D:\LTCSDL\School\Nháp\WebBanDienThoai-main\WebBanDienThoai-main\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\BanHang\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaKhNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 52 "D:\LTCSDL\School\Nháp\WebBanDienThoai-main\WebBanDienThoai-main\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\BanHang\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaKhNavigation.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 55 "D:\LTCSDL\School\Nháp\WebBanDienThoai-main\WebBanDienThoai-main\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\BanHang\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaNvNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 58 "D:\LTCSDL\School\Nháp\WebBanDienThoai-main\WebBanDienThoai-main\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\BanHang\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaNvNavigation.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de149e023d666c11e3551e852e9adff8c888b749b29032bc8a2cd2314cea420d10696", async() => {
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
#line 63 "D:\LTCSDL\School\Nháp\WebBanDienThoai-main\WebBanDienThoai-main\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\BanHang\Details.cshtml"
                           WriteLiteral(Model.MaHd);

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
            WriteLiteral(" |\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de149e023d666c11e3551e852e9adff8c888b749b29032bc8a2cd2314cea420d12929", async() => {
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
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebsiteBanDienThoai23.DAL.Models.HoaDon> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
