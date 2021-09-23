#pragma checksum "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Products\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1268d9b711f354dc51652222151e556fb5f2468a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Primery_Admin_Views_Products_Detail), @"mvc.1.0.view", @"/Areas/Primery_Admin/Views/Products/Detail.cshtml")]
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
#line 1 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Products\Detail.cshtml"
using Store_1.Application.Services.Products.Queries.GetProductDetailForAdmin;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1268d9b711f354dc51652222151e556fb5f2468a", @"/Areas/Primery_Admin/Views/Products/Detail.cshtml")]
    public class Areas_Primery_Admin_Views_Products_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductDetailForAdmindto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnail img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Products\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "~/Areas/Primery_Admin/Views/Shared/_Adminlayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-sm-12"">
    <div class=""card"">
        <div class=""card-header"">
            <div class=""card-title-wrap bar-warning"">
                <div class=""card-title"">More information about the product</div>
            </div>
        </div>
        <div class=""card-body"">
            <div class=""card-block"">
                <div class=""row"">
                    <div class=""col-lg-6 col-md-6 col-sm-12 col-12"">
                        <ul class=""no-list-style"">
                            <li class=""mb-2"">
                                <span class=""primary text-bold-500""><a><i class=""ft-home font-small-3""></i>  the product </a></span>
                                <span class=""line-height-2 display-block overflow-hidden"">");
#nullable restore
#line 22 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Products\Detail.cshtml"
                                                                                     Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            </li>
                            <li class=""mb-2"">
                                <span class=""primary text-bold-500""><a><i class=""ft-briefcase font-small-3""></i> brand </a></span>
                                <span class=""line-height-2 display-block overflow-hidden""> ");
#nullable restore
#line 26 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Products\Detail.cshtml"
                                                                                      Write(Model.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            </li>
                        </ul>
                    </div>
                    <div class=""col-lg-6 col-md-6 col-sm-12 col-12"">
                        <ul class=""no-list-style"">
                            <li class=""mb-2"">
                                <span class=""primary text-bold-500""><a><i class=""ft-home font-small-3""></i> Grouping </a></span>
                                <span class=""line-height-2 display-block overflow-hidden"">");
#nullable restore
#line 34 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Products\Detail.cshtml"
                                                                                     Write(Model.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            </li>
                            <li class=""mb-2"">
                                <span class=""primary text-bold-500""><a><i class=""ft-home font-small-3""></i>Price</a></span>
                                <span class=""line-height-2 display-block overflow-hidden""> ");
#nullable restore
#line 38 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Products\Detail.cshtml"
                                                                                      Write(Model.Price.ToString("n0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            </li>
                        </ul>
                    </div>
                    <div class=""col-lg-6 col-md-6 col-sm-12 col-12"">
                        <ul class=""no-list-style"">
                            <li class=""mb-2"">
                                <span class=""primary text-bold-500""><a><i class=""ft-home font-small-3""></i>Inventory</a></span>
                                <span class=""line-height-2 display-block overflow-hidden"">");
#nullable restore
#line 46 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Products\Detail.cshtml"
                                                                                     Write(Model.Inventory);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            </li>
                            <li class=""mb-2"">
                                <span class=""primary text-bold-500""><a><i class=""ft-home font-small-3""></i>Show on site?</a></span>
                                <span class=""line-height-2 display-block overflow-hidden""> ");
#nullable restore
#line 50 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Products\Detail.cshtml"
                                                                                      Write(Model.Displayed);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            </li>
                        </ul>
                    </div>
                    <div class=""col-lg-12 col-md-12 col-sm-12 col-12"">
                        <ul class=""no-list-style"">
                            <li");
            BeginWriteAttribute("class", " class=\"", 3258, "\"", 3266, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <span class=\"primary text-bold-500\"><a><i class=\"ft-home font-small-3\"></i>Description</a></span>\r\n                                <span class=\"line-height-2 display-block overflow-hidden\">");
#nullable restore
#line 58 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Products\Detail.cshtml"
                                                                                     Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            </li>

                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>






<div class=""card mb-4"">
    <div class=""card-header"">
        <div class=""card-title-wrap bar-success"">
            <div class=""card-title"">Product images and features</div>
        </div>
    </div>
    <div class=""card-body"">
        <div class=""card-block"">
            <div class=""row"">
                <div class=""col-4 col-sm-4"">
                    <ul class=""no-list-style pr-0 text-right fa-bold"">
");
#nullable restore
#line 85 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Products\Detail.cshtml"
                         foreach (var item in Model.Features)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"mb-2\">\r\n                                <span class=\"text-bold-500 primary\"><a><i class=\"icon-frame font-small-3\"></i> ");
#nullable restore
#line 88 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Products\Detail.cshtml"
                                                                                                          Write(item.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" :</a></span>\r\n                                <span class=\"display-block overflow-hidden\"> ");
#nullable restore
#line 89 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Products\Detail.cshtml"
                                                                        Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </li>\r\n");
#nullable restore
#line 91 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Products\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </div>\r\n                <div class=\"col-8 col-sm-8 text-center\">\r\n\r\n");
#nullable restore
#line 96 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Products\Detail.cshtml"
                     foreach (var item in Model.Images)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <figure class=\"col-xl-6 col-lg-4 col-sm-6 col-12\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1268d9b711f354dc51652222151e556fb5f2468a12982", async() => {
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1268d9b711f354dc51652222151e556fb5f2468a13270", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 4997, "~/", 4997, 2, true);
#nullable restore
#line 100 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Products\Detail.cshtml"
AddHtmlAttributeValue("", 4999, item.Src, 4999, 9, false);

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
                WriteLiteral("\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4883, "~/", 4883, 2, true);
#nullable restore
#line 99 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Products\Detail.cshtml"
AddHtmlAttributeValue("", 4885, item.Src, 4885, 9, false);

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
            WriteLiteral("\r\n                        </figure>\r\n");
#nullable restore
#line 103 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Areas\Primery_Admin\Views\Products\Detail.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n\r\n            </div>\r\n\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductDetailForAdmindto> Html { get; private set; }
    }
}
#pragma warning restore 1591