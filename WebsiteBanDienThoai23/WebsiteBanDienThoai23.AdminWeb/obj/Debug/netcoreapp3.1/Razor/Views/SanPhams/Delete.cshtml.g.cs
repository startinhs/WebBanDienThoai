#pragma checksum "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\SanPhams\Delete.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "52497d24542520a80ea25e5168c53a39b74c1be09c9d8e91ed943a5c36fab1f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SanPhams_Delete), @"mvc.1.0.view", @"/Views/SanPhams/Delete.cshtml")]
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
#line 1 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\_ViewImports.cshtml"
using WebsiteBanDienThoai23.AdminWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\_ViewImports.cshtml"
using WebsiteBanDienThoai23.AdminWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"52497d24542520a80ea25e5168c53a39b74c1be09c9d8e91ed943a5c36fab1f7", @"/Views/SanPhams/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"a2f9df8eb4a3d205e79b618aba20de64edd991ae6f7f83037e8f59f637467f99", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_SanPhams_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebsiteBanDienThoai23.DAL.Models.SanPham>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\SanPhams\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>SanPham</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TenSp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TenSp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Hinh1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Hinh1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Hinh2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Hinh2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Hinh3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Hinh3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MoTa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MoTa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TonKho));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TonKho));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SoLuong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SoLuong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Gia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Gia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ThoiGianBh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ThoiGianBh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 69 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model._5g));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 72 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayFor(model => model._5g));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 75 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Cpu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 78 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Cpu));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 81 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Pin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 84 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Pin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 87 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SacNhanh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 90 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SacNhanh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 93 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Ram));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 96 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Ram));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 99 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Rom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 102 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Rom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 105 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ManHinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 108 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ManHinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 111 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Fps));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 114 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Fps));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 117 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.HeDieuHanh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 120 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayFor(model => model.HeDieuHanh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 123 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CameraSau));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 126 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CameraSau));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 129 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CameraTruoc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 132 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CameraTruoc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 135 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Imel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 138 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Imel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 141 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.GiamGia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 144 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayFor(model => model.GiamGia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 147 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MaLoaiNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 150 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\SanPhams\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MaLoaiNavigation.MaLoai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52497d24542520a80ea25e5168c53a39b74c1be09c9d8e91ed943a5c36fab1f721172", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "52497d24542520a80ea25e5168c53a39b74c1be09c9d8e91ed943a5c36fab1f721463", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 155 "D:\GitHub\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.AdminWeb\Views\SanPhams\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.MaSp);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52497d24542520a80ea25e5168c53a39b74c1be09c9d8e91ed943a5c36fab1f723305", async() => {
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
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
