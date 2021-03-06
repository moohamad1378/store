#pragma checksum "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Categories\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd33fe5249da3ba226da66f9fc8ad4aeaffa73c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Primery_Admin_Views_Categories_Index), @"mvc.1.0.view", @"/Areas/Primery_Admin/Views/Categories/Index.cshtml")]
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
#line 1 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Categories\Index.cshtml"
using Store_1.Application.Services.Products.Queries.GetCategories;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd33fe5249da3ba226da66f9fc8ad4aeaffa73c7", @"/Areas/Primery_Admin/Views/Categories/Index.cshtml")]
    public class Areas_Primery_Admin_Views_Categories_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CategoriesDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/primery_admin/Categories/AddNewCategory"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Sweetalert2/sweetalert2.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Sweetalert2/sweetalert2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Categories\Index.cshtml"
  
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
                                <h4 class=""card-title"">List of categories</h4>
                            </div>
                        </div>
                        <div class=""card-body collapse show"">
                            <div class=""card-block card-dashboard"">
                                <p class=""card-text"">> Store product categories</p>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd33fe5249da3ba226da66f9fc8ad4aeaffa73c76255", async() => {
                WriteLiteral("Add new categories");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                                <div id=""DataTables_Table_0_wrapper"" class=""dataTables_wrapper container-fluid dt-bootstrap4"">
                                    <div class=""col-sm-12"">
                                        <table class=""table table-striped table-bordered zero-configuration dataTable"" id=""DataTables_Table_0"" role=""grid"" aria-describedby=""DataTables_Table_0_info"">
                                            <thead>
                                                <tr role=""row"">
                                                    <th class=""sorting_asc"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""???????? ????????: activate to sort column descending"" style=""width: 222px;"">???????? ????????</th>
                                                    <th class=""sorting_asc"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""??????: activate to sort column descending"" style=""width: 222px;"">??");
            WriteLiteral(@"????</th>
                                                    <th class=""sorting_asc"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label="": activate to sort column descending"" style=""width: 222px;""></th>

                                                </tr>
                                            </thead>
                                            <tbody>

");
#nullable restore
#line 40 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Categories\Index.cshtml"
                                                 foreach (var item in Model)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr role=\"row\" class=\"odd\">\r\n                                                        <td class=\"sorting_1\">");
#nullable restore
#line 43 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Categories\Index.cshtml"
                                                                         Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>\r\n");
#nullable restore
#line 45 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Categories\Index.cshtml"
                                                              
                                                                string parent = item.Parent != null ? item.Parent.name : "-";
                                                            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                            <text> ");
#nullable restore
#line 49 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Categories\Index.cshtml"
                                                              Write(parent);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </text>\r\n                                                        </td>\r\n                                                        <td>\r\n");
#nullable restore
#line 52 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Categories\Index.cshtml"
                                                             if (item.Parent == null)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd33fe5249da3ba226da66f9fc8ad4aeaffa73c711259", async() => {
                WriteLiteral("Add child");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3592, "~/primery_admin/Categories/AddNewCategory?ParentId=", 3592, 51, true);
#nullable restore
#line 54 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Categories\Index.cshtml"
AddHtmlAttributeValue("", 3643, item.Id, 3643, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 55 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Categories\Index.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 57 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Categories\Index.cshtml"
                                                             if (item.HasChild == true)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd33fe5249da3ba226da66f9fc8ad4aeaffa73c713646", async() => {
                WriteLiteral("View the list of children ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3982, "~/primery_admin/Categories/index?ParentId=", 3982, 42, true);
#nullable restore
#line 59 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Categories\Index.cshtml"
AddHtmlAttributeValue("", 4024, item.Id, 4024, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 60 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Categories\Index.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td>\r\n");
#nullable restore
#line 64 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Categories\Index.cshtml"
                                                             if (item.IsRemoved == true)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <a");
            BeginWriteAttribute("onclick", "  onclick=\"", 4496, "\"", 4532, 3);
            WriteAttributeValue("", 4507, "ChangeStatuse(\'", 4507, 15, true);
#nullable restore
#line 66 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Categories\Index.cshtml"
WriteAttributeValue("", 4522, item.Id, 4522, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4530, "\')", 4530, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Activate</a>\r\n");
#nullable restore
#line 67 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Categories\Index.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 69 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Categories\Index.cshtml"
                                                             if (item.IsRemoved == false)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <a");
            BeginWriteAttribute("onclick", "  onclick=\"", 4856, "\"", 4892, 3);
            WriteAttributeValue("", 4867, "ChangeStatuse(\'", 4867, 15, true);
#nullable restore
#line 71 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Categories\Index.cshtml"
WriteAttributeValue("", 4882, item.Id, 4882, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4890, "\')", 4890, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">to deactivate</a>\r\n");
#nullable restore
#line 72 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Categories\Index.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </td>\r\n                                                    </tr>\r\n");
#nullable restore
#line 76 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Categories\Index.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>


            </div>
        </section>
    </div>
</div>
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dd33fe5249da3ba226da66f9fc8ad4aeaffa73c719193", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd33fe5249da3ba226da66f9fc8ad4aeaffa73c720372", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

    <script>
        function ChangeStatuse(CategoryId){
            swal.fire({
                title: 'ChangeStatuse',
                text: 'Are you sure you want to Change the Statuse?',
                icon: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#d33',
                cancelButtonColor: '#7cacbe',
                confirmButtonText: 'Yes delete user',
                cancelButtonText: 'No'

            }).then((result) => {
                if (result.value) {
                    var postData = {
                        'CategoryId': CategoryId,
                        
                    };
                    $.ajax({
                        contentType: 'application/x-www-form-urlencoded',
                        dataType: 'json',
                        type: ""POST"",
                        url: ""Changethestatus"",
                        data: postData,
                        success: function (data) {
                    ");
                WriteLiteral(@"        if (data.isSuccess == true) {
                                swal.fire(
                                    'success',
                                    data.message,
                                    'success'
                                ).then(function (isConfrim) {
                                    location.reload();
                                });
                            }
                            else {
                                swal.fire(
                                    'warning',
                                    data.message,
                                    'warning'
                                );
                            }
                        },
                        error: function (request, status, error) {
                            alert(request.responseText);
                        }
                    })
                }

            })
            }


    </script>


");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CategoriesDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
