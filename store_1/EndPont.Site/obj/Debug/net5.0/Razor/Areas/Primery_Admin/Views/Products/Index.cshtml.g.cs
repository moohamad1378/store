#pragma checksum "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af274c4a119886f4fa0b6bb0d5bb874bbfcf1931"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Primery_Admin_Views_Products_Index), @"mvc.1.0.view", @"/Areas/Primery_Admin/Views/Products/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 3 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Products\Index.cshtml"
using Store_1.Application.Services.Products.Queries.GetProductForAdmin;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af274c4a119886f4fa0b6bb0d5bb874bbfcf1931", @"/Areas/Primery_Admin/Views/Products/Index.cshtml")]
    public class Areas_Primery_Admin_Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductForAdminDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("query-string-key-page-no", "Page", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("query-string-key-page-size", "PageSize", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::LazZiya.TagHelpers.PagingTagHelper __LazZiya_TagHelpers_PagingTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Products\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Primery_Admin/Views/Shared/_Adminlayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content-wrapper"">
    <div class=""container-fluid"">
        <!-- Zero configuration table -->
        <section id=""configuration"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""card"">

                        <div class=""card-body collapse show"">
                            <div class=""card-block card-dashboard"">
                                <p class=""card-text"">???????? ??????????????</p>
                                <div id=""DataTables_Table_0_wrapper"" class=""dataTables_wrapper container-fluid dt-bootstrap4"">
                                    <div class=""col-sm-12"">
                                        <table class=""table table-striped table-bordered zero-configuration dataTable"" id=""DataTables_Table_0"" role=""grid"" aria-describedby=""DataTables_Table_0_info"">
                                            <thead>
                                                <tr role=""row"">
                                                    <t");
            WriteLiteral(@"h class=""sorting_asc"">??????</th>
                                                    <th class=""sorting_asc"">???????? ????????</th>
                                                    <th class=""sorting_asc"">???????? </th>
                                                    <th class=""sorting_asc"">???????? </th>
                                                    <th class=""sorting_asc"">???????????? </th>
                                                    <th class=""sorting_asc"">?????????? ???? ?????????? </th>
                                                    <th class=""sorting_asc""> </th>
                                                </tr>
                                            </thead>
                                            <tbody>

");
#nullable restore
#line 37 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Products\Index.cshtml"
                                                 foreach (var item in Model.Products)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr role=\"row\">\r\n                                                        <td>");
#nullable restore
#line 40 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Products\Index.cshtml"
                                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 41 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Products\Index.cshtml"
                                                       Write(item.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 42 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Products\Index.cshtml"
                                                       Write(item.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 43 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Products\Index.cshtml"
                                                       Write(item.Price.ToString("n0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 44 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Products\Index.cshtml"
                                                       Write(item.Inventory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 45 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Products\Index.cshtml"
                                                       Write(item.Displayed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>\r\n                                                            <a class=\"btn btn-danger\">??????</a>\r\n                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af274c4a119886f4fa0b6bb0d5bb874bbfcf19319001", async() => {
                WriteLiteral("?????????????? ??????????");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2940, "~/Primery_admin/products/detail/", 2940, 32, true);
#nullable restore
#line 48 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Products\Index.cshtml"
AddHtmlAttributeValue("", 2972, item.Id, 2972, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                        </td>\r\n                                                    </tr>\r\n");
#nullable restore
#line 51 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Products\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </tbody>
                                        </table>
                                    </div>
                                </div>

                                <div class=""  text-center"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("paging", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af274c4a119886f4fa0b6bb0d5bb874bbfcf193111337", async() => {
                WriteLiteral("\r\n                                    ");
            }
            );
            __LazZiya_TagHelpers_PagingTagHelper = CreateTagHelper<global::LazZiya.TagHelpers.PagingTagHelper>();
            __tagHelperExecutionContext.Add(__LazZiya_TagHelpers_PagingTagHelper);
#nullable restore
#line 58 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Products\Index.cshtml"
__LazZiya_TagHelpers_PagingTagHelper.TotalRecords = Model.RowCount;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("total-records", __LazZiya_TagHelpers_PagingTagHelper.TotalRecords, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 59 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Products\Index.cshtml"
__LazZiya_TagHelpers_PagingTagHelper.PageNo = Model.CurrentPage;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-no", __LazZiya_TagHelpers_PagingTagHelper.PageNo, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 60 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Products\Index.cshtml"
__LazZiya_TagHelpers_PagingTagHelper.PageSize = Model.PageSize;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-size", __LazZiya_TagHelpers_PagingTagHelper.PageSize, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 61 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Products\Index.cshtml"
__LazZiya_TagHelpers_PagingTagHelper.ShowPrevNext = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("show-prev-next", __LazZiya_TagHelpers_PagingTagHelper.ShowPrevNext, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 62 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Products\Index.cshtml"
__LazZiya_TagHelpers_PagingTagHelper.ShowTotalPages = false;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("show-total-pages", __LazZiya_TagHelpers_PagingTagHelper.ShowTotalPages, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 63 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Products\Index.cshtml"
__LazZiya_TagHelpers_PagingTagHelper.ShowTotalRecords = false;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("show-total-records", __LazZiya_TagHelpers_PagingTagHelper.ShowTotalRecords, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 64 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Products\Index.cshtml"
__LazZiya_TagHelpers_PagingTagHelper.ShowPageSizeNav = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("show-page-size-nav", __LazZiya_TagHelpers_PagingTagHelper.ShowPageSizeNav, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 65 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Products\Index.cshtml"
__LazZiya_TagHelpers_PagingTagHelper.ShowFirstNumberedPage = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("show-first-numbered-page", __LazZiya_TagHelpers_PagingTagHelper.ShowFirstNumberedPage, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 66 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Products\Index.cshtml"
__LazZiya_TagHelpers_PagingTagHelper.ShowLastNumberedPage = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("show-last-numbered-page", __LazZiya_TagHelpers_PagingTagHelper.ShowLastNumberedPage, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __LazZiya_TagHelpers_PagingTagHelper.QueryStringKeyPageNo = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __LazZiya_TagHelpers_PagingTagHelper.QueryStringKeyPageSize = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 69 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Products\Index.cshtml"
__LazZiya_TagHelpers_PagingTagHelper.GapSize = 2;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("gap-size", __LazZiya_TagHelpers_PagingTagHelper.GapSize, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </section>\r\n    </div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductForAdminDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
