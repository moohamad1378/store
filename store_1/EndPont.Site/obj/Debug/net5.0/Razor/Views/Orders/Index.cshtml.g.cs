#pragma checksum "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Views\Orders\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bde232603c33459801984f3b12ad78612b1a501b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Index), @"mvc.1.0.view", @"/Views/Orders/Index.cshtml")]
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
#line 1 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Views\Orders\Index.cshtml"
using Store_1.Application.Services.Orders.Queries.GetUserOrders;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bde232603c33459801984f3b12ad78612b1a501b", @"/Views/Orders/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4cba601be58da4fca7c9173fe535110203607e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GetUserOrdersDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Views\Orders\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Your Orders</h1>
<table style=""border:dashed"" class=""table table-responsive table-active table-bordered"">
    <thead>
        <tr style=""border:solid"">
            <th>Order number</th>
            <th>Invoice number</th>
            <th>Order status</th>
            <th>Products in this order</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 19 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Views\Orders\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr style=\"border:solid\">\r\n                <td>");
#nullable restore
#line 22 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Views\Orders\Index.cshtml"
               Write(item.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Views\Orders\Index.cshtml"
               Write(item.OrderState);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Views\Orders\Index.cshtml"
               Write(item.RequestPayId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n\r\n                <td>\r\n                    <table>\r\n");
#nullable restore
#line 28 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Views\Orders\Index.cshtml"
                         foreach (var detail in item.orderDetails)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr style=\"border:outset\">\r\n                                <td> ");
#nullable restore
#line 31 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Views\Orders\Index.cshtml"
                                Write(detail.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td> ");
#nullable restore
#line 32 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Views\Orders\Index.cshtml"
                                Write(detail.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td> ");
#nullable restore
#line 33 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Views\Orders\Index.cshtml"
                                Write(detail.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 35 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Views\Orders\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </table>\r\n\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 40 "C:\Users\Lohetaban\source\repos\store_1\EndPont.Site\Views\Orders\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GetUserOrdersDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
