#pragma checksum "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Views\Shared\Components\GetMenue\GetMenue.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "395d32056fee1660193cdd6ce7d737576bfdf5d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_GetMenue_GetMenue), @"mvc.1.0.view", @"/Views/Shared/Components/GetMenue/GetMenue.cshtml")]
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
#line 1 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Views\_ViewImports.cshtml"
using EndPont.Site;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Views\_ViewImports.cshtml"
using EndPont.Site.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Views\Shared\Components\GetMenue\GetMenue.cshtml"
using Store_1.Application.Services.Common.Queries;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"395d32056fee1660193cdd6ce7d737576bfdf5d6", @"/Views/Shared/Components/GetMenue/GetMenue.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4cba601be58da4fca7c9173fe535110203607e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_GetMenue_GetMenue : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MenuItemDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mega-menu-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Views\Shared\Components\GetMenue\GetMenue.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Views\Shared\Components\GetMenue\GetMenue.cshtml"
 foreach (var item in Model)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <li id=\"nav-menu-item\" class=\"menu-item nav-overlay\" style=\"display: inline; list-style: none; \">\r\n        <a href=\"#\" class=\"current-link-menu\">\r\n            ");
#nullable restore
#line 12 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Views\Shared\Components\GetMenue\GetMenue.cshtml"
       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </a>\r\n\r\n");
#nullable restore
#line 15 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Views\Shared\Components\GetMenue\GetMenue.cshtml"
         if (item.Child.Count() > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <ul class=\"sub-menu is-mega-menu-small\">\r\n\r\n");
#nullable restore
#line 19 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Views\Shared\Components\GetMenue\GetMenue.cshtml"
                 foreach (var itemChild in item.Child)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"menu-mega-item menu-item-type-mega-menu item-small\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "395d32056fee1660193cdd6ce7d737576bfdf5d65433", async() => {
                WriteLiteral("\r\n                            ");
#nullable restore
#line 23 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Views\Shared\Components\GetMenue\GetMenue.cshtml"
                       Write(itemChild.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 633, "~/Products/Index?CatId=", 633, 23, true);
#nullable restore
#line 22 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Views\Shared\Components\GetMenue\GetMenue.cshtml"
AddHtmlAttributeValue("", 656, itemChild.CatId, 656, 16, false);

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
            WriteLiteral("\r\n                    </li>\r\n");
#nullable restore
#line 26 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Views\Shared\Components\GetMenue\GetMenue.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n");
#nullable restore
#line 28 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Views\Shared\Components\GetMenue\GetMenue.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </li>\r\n");
#nullable restore
#line 31 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Views\Shared\Components\GetMenue\GetMenue.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MenuItemDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591