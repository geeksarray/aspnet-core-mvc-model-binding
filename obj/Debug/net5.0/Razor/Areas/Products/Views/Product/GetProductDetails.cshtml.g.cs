#pragma checksum "L:\Laxmikant\applications\GeeksApps\MVC Model Binding\Areas\Products\Views\Product\GetProductDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19a6f366bc499af78c22f8c2e1e01fbac0a3390d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Products_Views_Product_GetProductDetails), @"mvc.1.0.view", @"/Areas/Products/Views/Product/GetProductDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19a6f366bc499af78c22f8c2e1e01fbac0a3390d", @"/Areas/Products/Views/Product/GetProductDetails.cshtml")]
    public class Areas_Products_Views_Product_GetProductDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVC5Tutorial.Areas.Products.Models.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "L:\Laxmikant\applications\GeeksApps\MVC Model Binding\Areas\Products\Views\Product\GetProductDetails.cshtml"
  
    ViewData["Title"] = "GetProductDetails";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Product Details: ");
#nullable restore
#line 8 "L:\Laxmikant\applications\GeeksApps\MVC Model Binding\Areas\Products\Views\Product\GetProductDetails.cshtml"
                Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<div>\r\n    <table class=\"table table-sm table-bordered table-striped\">\r\n        <tr><th>ID: </th><td>");
#nullable restore
#line 11 "L:\Laxmikant\applications\GeeksApps\MVC Model Binding\Areas\Products\Views\Product\GetProductDetails.cshtml"
                        Write(Model.ProductID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n        <tr><th>Name: </th><td>");
#nullable restore
#line 12 "L:\Laxmikant\applications\GeeksApps\MVC Model Binding\Areas\Products\Views\Product\GetProductDetails.cshtml"
                          Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n        <tr><th>Code: </th><td>");
#nullable restore
#line 13 "L:\Laxmikant\applications\GeeksApps\MVC Model Binding\Areas\Products\Views\Product\GetProductDetails.cshtml"
                          Write(Model.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n        <tr><th>Qty: </th><td>");
#nullable restore
#line 14 "L:\Laxmikant\applications\GeeksApps\MVC Model Binding\Areas\Products\Views\Product\GetProductDetails.cshtml"
                         Write(Model.Qty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n        <tr><th>Reorder Qty: </th><td>");
#nullable restore
#line 15 "L:\Laxmikant\applications\GeeksApps\MVC Model Binding\Areas\Products\Views\Product\GetProductDetails.cshtml"
                                 Write(Model.ReorderQty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n        <tr><th>Price: </th><td>");
#nullable restore
#line 16 "L:\Laxmikant\applications\GeeksApps\MVC Model Binding\Areas\Products\Views\Product\GetProductDetails.cshtml"
                           Write(Model.ListPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n        <tr><th>Size: </th><td>");
#nullable restore
#line 17 "L:\Laxmikant\applications\GeeksApps\MVC Model Binding\Areas\Products\Views\Product\GetProductDetails.cshtml"
                          Write(Model.Size);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVC5Tutorial.Areas.Products.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
