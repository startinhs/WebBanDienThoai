#pragma checksum "D:\Documents\IM_OU_K21\232\LTCSDL_DBDEV\BTL\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\DienThoai\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "af5f5b7b9b3b5b7558e29bddcd63b8390e6d93a9fe56c948f7b769eea7e506b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DienThoai_Details), @"mvc.1.0.view", @"/Views/DienThoai/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"af5f5b7b9b3b5b7558e29bddcd63b8390e6d93a9fe56c948f7b769eea7e506b1", @"/Views/DienThoai/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"4acdeae80e09822e5d9028166823cf9c4922854768a6ca4d6d267b5359c9ee9d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_DienThoai_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebsiteBanDienThoai23.DAL.Models.SanPham>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af5f5b7b9b3b5b7558e29bddcd63b8390e6d93a9fe56c948f7b769eea7e506b14131", async() => {
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""css/DienThoai_style.css"">
    <link rel=""stylesheet"" href=""css/Home_style.css"">
    <link rel=""stylesheet"" href=""css/bootstrap-theme.css"">
    <link rel=""stylesheet"" href=""css/bootstrap.css"">
    <link rel=""stylesheet"" href=""css/slick.css"">
    <link rel=""stylesheet"" href=""css/slick-theme.css"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af5f5b7b9b3b5b7558e29bddcd63b8390e6d93a9fe56c948f7b769eea7e506b15483", async() => {
                WriteLiteral(@"
    <section>
        <div class=""container-fluid section"">
            <div class=""row type_dien_thoai"">
                <div class=""col-md-12"">
                    <ul class=""list_type_dien_thoai"">
                        <li><a href=""/DienThoai/TimTheoTen?SearchString=iphone""><img src=""images/88.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 768, "\"", 774, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"img-responsive\"></a></li>\r\n                        <li><a href=\"/DienThoai/TimTheoTen?SearchString=samsung\"><img src=\"images/89.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 915, "\"", 921, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"img-responsive\"></a></li>\r\n                        <li><a href=\"/DienThoai/TimTheoTen?SearchString=oppo\"><img src=\"images/90.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 1059, "\"", 1065, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"img-responsive\"></a></li>\r\n                        <li><a href=\"/DienThoai/TimTheoTen?SearchString=xiaomi\"><img src=\"images/91.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 1205, "\"", 1211, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"img-responsive\"></a></li>\r\n                        <li><a href=\"/DienThoai/TimTheoTen?SearchString=vivo\"><img src=\"images/92.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 1349, "\"", 1355, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"img-responsive\"></a></li>\r\n                        <li><a href=\"/DienThoai/TimTheoTen?SearchString=huawei\"><img src=\"images/93.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 1495, "\"", 1501, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"img-responsive\"></a></li>\r\n                        <li><a href=\"/DienThoai/TimTheoTen?SearchString=realme\"><img src=\"images/94.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 1641, "\"", 1647, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"img-responsive\"></a></li>\r\n                        <li><a href=\"/DienThoai/TimTheoTen?SearchString=oneplus\"><img src=\"images/oneplus.png\"");
                BeginWriteAttribute("alt", " alt=\"", 1793, "\"", 1799, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"img-responsive\"></a></li>\r\n                        <li><a href=\"/DienThoai/TimTheoTen?SearchString=poco\"><img src=\"images/poco.png\"");
                BeginWriteAttribute("alt", " alt=\"", 1939, "\"", 1945, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""img-responsive""></a></li>
                        <li class=""seemore_dien_thoai""><a href=""/DienThoai"">Xem thêm</a></li>
                    </ul>
                </div>
            </div>
            <div class=""row filter_dien_thoai"">
                <div class=""col-md-12"">
                    <ul class=""list_filter_dien_thoai"">
                        <li>Chọn mức giá: </li>
                        <li><a href=""/DienThoai/TimTheoGia?minPrice=0&maxPrice=12000000"">Dưới 12 triệu</a></li>
                        <li><a href=""/DienThoai/TimTheoGia?minPrice=12000000&maxPrice=14000000"">Từ 12 - 14 triệu</a></li>
                        <li><a href=""/DienThoai/TimTheoGia?minPrice=14000000&maxPrice=17000000"">Từ 14 - 17 triệu</a></li>
                        <li><a href=""/DienThoai/TimTheoGia?minPrice=17000000&maxPrice=23000000"">Từ 17 - 23 triệu</a></li>
                        <li><a href=""/DienThoai/TimTheoGia?minPrice=23000000&maxPrice=50000000"">Trên 23 triệu</a></li>
                        <");
                WriteLiteral(@"li><a href=""#""></a></li>
                    </ul>
                </div>
            </div>
            <div class=""row phones_dien_thoai"">
                <div class=""col-md-12 title_dien_thoai"">
                    <h3>danh sách điện thoại</h3>
                </div>
                <div class=""row filter_dien_thoai"">
                    <div class=""col-md-12"">
                        <ul class=""list_filter_dien_thoai"">
                            <li>Bộ lọc: </li>
                            <li><input type=""checkbox"" name=""new_dien_thoai""> Pin trâu</li>
                            <li><input type=""checkbox"" name=""installment_dien_thoai""> Camera đẹp</li>
                            <li><input type=""checkbox"" name=""only_sell_online_dien_thoai""> Hỗ trợ 5G</li>
                            <li><button>Lọc</button></li>
                        </ul>
                    </div>
                </div>
                <div class=""col-md-12 main_list_dien_thoai"">
                    <ul class=""l");
                WriteLiteral("ist_dien_thoai\">\r\n");
#nullable restore
#line 62 "D:\Documents\IM_OU_K21\232\LTCSDL_DBDEV\BTL\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\DienThoai\Details.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <li>\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af5f5b7b9b3b5b7558e29bddcd63b8390e6d93a9fe56c948f7b769eea7e506b111204", async() => {
                    WriteLiteral("\r\n                                    <div class=\"phone_dien_thoai\">\r\n                                        <img");
                    BeginWriteAttribute("src", " src=\"", 4323, "\"", 4351, 2);
                    WriteAttributeValue("", 4329, "imgProduct/", 4329, 11, true);
#nullable restore
#line 67 "D:\Documents\IM_OU_K21\232\LTCSDL_DBDEV\BTL\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\DienThoai\Details.cshtml"
WriteAttributeValue("", 4340, item.Hinh1, 4340, 11, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    BeginWriteAttribute("alt", " alt=\"", 4352, "\"", 4358, 0);
                    EndWriteAttribute();
                    WriteLiteral(" class=\"img-responsive\">\r\n                                        <div class=\"sub_title\">\r\n                                            <h4>\r\n                                                <a");
                    BeginWriteAttribute("href", " href=\"", 4550, "\"", 4621, 1);
#nullable restore
#line 70 "D:\Documents\IM_OU_K21\232\LTCSDL_DBDEV\BTL\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\DienThoai\Details.cshtml"
WriteAttributeValue("", 4557, Url.Action("Details", "DetailsProduct", new { id = item.MaSp }), 4557, 64, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">");
#nullable restore
#line 70 "D:\Documents\IM_OU_K21\232\LTCSDL_DBDEV\BTL\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\DienThoai\Details.cshtml"
                                                                                                                      Write(item.TenSp);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</a>\r\n                                            </h4>\r\n                                            <p class=\"price\">");
#nullable restore
#line 72 "D:\Documents\IM_OU_K21\232\LTCSDL_DBDEV\BTL\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\DienThoai\Details.cshtml"
                                                        Write(Math.Round(item.Gia * (1 - (item.GiamGia / 100))).ToString("N0"));

#line default
#line hidden
#nullable disable
                    WriteLiteral("<span>₫</span>\r\n                                            <p class=\"old_price\">");
#nullable restore
#line 73 "D:\Documents\IM_OU_K21\232\LTCSDL_DBDEV\BTL\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\DienThoai\Details.cshtml"
                                                            Write(item.Gia.ToString("N0"));

#line default
#line hidden
#nullable disable
                    WriteLiteral("</p>\r\n                                        </div>\r\n                                    </div>\r\n                                ");
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
#line 65 "D:\Documents\IM_OU_K21\232\LTCSDL_DBDEV\BTL\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\DienThoai\Details.cshtml"
                                                          WriteLiteral(item.MaSp);

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
                WriteLiteral("\r\n                            </li>\r\n");
#nullable restore
#line 78 "D:\Documents\IM_OU_K21\232\LTCSDL_DBDEV\BTL\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\DienThoai\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </ul>\r\n                </div>\r\n                <div style=\"text-align:center; font-family:Consolas\">\r\n");
#nullable restore
#line 82 "D:\Documents\IM_OU_K21\232\LTCSDL_DBDEV\BTL\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\DienThoai\Details.cshtml"
                      
                        if (ViewBag.TotalPages > 1)
                        {
                            for (int i = 1; i <= ViewBag.TotalPages; i++)
                            {
                                if (i == ViewBag.CurrentPage)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <span>");
#nullable restore
#line 89 "D:\Documents\IM_OU_K21\232\LTCSDL_DBDEV\BTL\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\DienThoai\Details.cshtml"
                                     Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n");
#nullable restore
#line 90 "D:\Documents\IM_OU_K21\232\LTCSDL_DBDEV\BTL\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\DienThoai\Details.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <a style=\"font-size: 17px\"");
                BeginWriteAttribute("href", " href=\"", 5773, "\"", 5798, 2);
                WriteAttributeValue("", 5780, "/DienThoai?page=", 5780, 16, true);
#nullable restore
#line 93 "D:\Documents\IM_OU_K21\232\LTCSDL_DBDEV\BTL\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\DienThoai\Details.cshtml"
WriteAttributeValue("", 5796, i, 5796, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 93 "D:\Documents\IM_OU_K21\232\LTCSDL_DBDEV\BTL\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\DienThoai\Details.cshtml"
                                                                                    Write(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n");
#nullable restore
#line 94 "D:\Documents\IM_OU_K21\232\LTCSDL_DBDEV\BTL\WebBanDienThoai\WebsiteBanDienThoai23\WebsiteBanDienThoai23.Web\Views\DienThoai\Details.cshtml"
                                }
                            }
                        }
                    

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </div>

            </div>
        </div>
        <div class=""container-fluid main_shipper_dien_thoai"">
            <div class=""row"" style=""max-width: 1300px; margin: 0 auto;"">
                <div class=""col-md-12"">
                    <ul class=""list_shipper_dien_thoai"">
                        <li>
                            <p>Giao hàng hoả tốc trong 1 giờ</p>
                        </li>
                        <li>
                            <p>Thanh toán linh hoạt: tiền mặt, visa / master, trả góp</p>
                        </li>
                        <li>
                            <p>Trải nghiệm sản phẩm tại nhà</p>
                        </li>
                        <li>
                            <p>Lỗi đổi tại nhà trong 1 ngày</p>
                        </li>
                        <li>
                            <p>Hỗ trợ suốt thời gian sử dụng. Hotline: <a href=""#"">1800.1763</a></p>
                        </li>
                    </ul>
     ");
                WriteLiteral("           </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebsiteBanDienThoai23.DAL.Models.SanPham>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
