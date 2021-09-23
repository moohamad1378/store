#pragma checksum "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\RequestPay\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a163be631c46b96d2afc0eb190d3168f1754d439"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Primery_Admin_Views_RequestPay_Index), @"mvc.1.0.view", @"/Areas/Primery_Admin/Views/RequestPay/Index.cshtml")]
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
#line 1 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\RequestPay\Index.cshtml"
using Store_1.Application.Services.Fainances.Queries.GetRequestPayForAdmin;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a163be631c46b96d2afc0eb190d3168f1754d439", @"/Areas/Primery_Admin/Views/RequestPay/Index.cshtml")]
    public class Areas_Primery_Admin_Views_RequestPay_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<RequestPayDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\RequestPay\Index.cshtml"
  
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
                        <div class=""card-header"">
                            <div class=""card-title-wrap bar-success"">
                                <h4 class=""card-title"">Invoices</h4>
                            </div>
                        </div>
                        <div class=""card-body collapse show"">
                            <div class=""card-block card-dashboard"">
                                <p class=""card-text"">List of store invoices</p>

                                <form method=""get"" class=""col-xl-4 col-lg-6 col-md-12 mb-1"">
                                    <fieldset class=""form-group"">
                                        <input type=""text"" class=""form-control"" name=""serchkey"">
                              ");
            WriteLiteral(@"          <button class=""btn btn-success"">Search</button>
                                    </fieldset>
                                </form>

                                <div id=""DataTables_Table_0_wrapper"" class=""dataTables_wrapper container-fluid dt-bootstrap4"">
                                    <div class=""col-sm-12"">
                                        <table class=""table table-striped table-bordered zero-configuration dataTable"" id=""DataTables_Table_0"" role=""grid"" aria-describedby=""DataTables_Table_0_info"">
                                            <thead>
                                                <tr role=""row"">
                                                    <th class=""sorting_asc"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""  activate to sort column descending"" style=""width: 222px;""> Invoice number</th>
                                                    <th class=""sorting_asc"" tabindex=""0"" aria-controls");
            WriteLiteral(@"=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""  activate to sort column descending"" style=""width: 222px;""> Amount</th>
                                                    <th class=""sorting_asc"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""  activate to sort column descending"" style=""width: 222px;""> User</th>
                                                    <th class=""sorting_asc"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""  activate to sort column descending"" style=""width: 222px;""> Paid?</th>
                                                    <th class=""sorting_asc"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""  activate to sort column descending"" style=""width: 222px;""> date of payment</th>
                                                    <th class=""sorting_asc"" tabindex=""0"" aria-co");
            WriteLiteral(@"ntrols=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""  activate to sort column descending"" style=""width: 222px;"">  RefId </th>
                                                    <th class=""sorting_asc"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""  activate to sort column descending"" style=""width: 222px;"">  Authority </th>
                                                    <th class=""sorting_asc"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""  activate to sort column descending"" style=""width: 222px;"">    </th>
                                                </tr>
                                            </thead>
                                            <tbody>

");
#nullable restore
#line 49 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\RequestPay\Index.cshtml"
                                                 foreach (var item in Model)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr role=\"row\" class=\"odd\">\r\n                                                        <td class=\"sorting_1\">");
#nullable restore
#line 52 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\RequestPay\Index.cshtml"
                                                                         Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 53 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\RequestPay\Index.cshtml"
                                                       Write(item.Amount.ToString("n0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 54 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\RequestPay\Index.cshtml"
                                                       Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 55 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\RequestPay\Index.cshtml"
                                                       Write(item.IsPay);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 56 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\RequestPay\Index.cshtml"
                                                       Write(item.PayDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 57 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\RequestPay\Index.cshtml"
                                                       Write(item.RefId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 58 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\RequestPay\Index.cshtml"
                                                       Write(item.Authority);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>\r\n                                                        </td>\r\n                                                    </tr>\r\n");
#nullable restore
#line 62 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\RequestPay\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </tbody>
                                        </table>
                                    </div>
                                </div><div class=""row""><div class=""col-sm-12 col-md-5""><div class=""dataTables_info"" id=""DataTables_Table_0_info"" role=""status"" aria-live=""polite"">Showing 1 to 10 of 57 lines</div></div><div class=""col-sm-12 col-md-7""><div class=""dataTables_paginate paging_simple_numbers"" id=""DataTables_Table_0_paginate""><ul class=""pagination""><li class=""paginate_button page-item previous disabled"" id=""DataTables_Table_0_previous""><a href=""#"" aria-controls=""DataTables_Table_0"" data-dt-idx=""0"" tabindex=""0"" class=""page-link"">Previous</a></li><li class=""paginate_button page-item active""><a href=""#"" aria-controls=""DataTables_Table_0"" data-dt-idx=""1"" tabindex=""0"" class=""page-link"">1</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""DataTables_Table_0"" data-dt-idx=""2"" tabindex=""0"" class=""page-link"">2</a></li><li class=""paginate_butt");
            WriteLiteral(@"on page-item ""><a href=""#"" aria-controls=""DataTables_Table_0"" data-dt-idx=""3"" tabindex=""0"" class=""page-link"">3</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""DataTables_Table_0"" data-dt-idx=""4"" tabindex=""0"" class=""page-link"">4</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""DataTables_Table_0"" data-dt-idx=""5"" tabindex=""0"" class=""page-link"">5</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""DataTables_Table_0"" data-dt-idx=""6"" tabindex=""0"" class=""page-link"">6</a></li><li class=""paginate_button page-item next"" id=""DataTables_Table_0_next""><a href=""#"" aria-controls=""DataTables_Table_0"" data-dt-idx=""7"" tabindex=""0"" class=""page-link"">Next</a></li></ul></div></div></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

        </section>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<RequestPayDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
