#pragma checksum "F:\New folder (3)\mvc-ecommerce\e-commerce-project\Views\ShowProduct\getProductById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16b334ae7eeace8f952946f93b038452a88e29e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShowProduct_getProductById), @"mvc.1.0.view", @"/Views/ShowProduct/getProductById.cshtml")]
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
#line 1 "F:\New folder (3)\mvc-ecommerce\e-commerce-project\Views\_ViewImports.cshtml"
using e_commerce_project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\New folder (3)\mvc-ecommerce\e-commerce-project\Views\_ViewImports.cshtml"
using e_commerce_project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16b334ae7eeace8f952946f93b038452a88e29e1", @"/Views/ShowProduct/getProductById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43d2b6c0324bc10d943d4faa178708e7e5b2a33a", @"/Views/_ViewImports.cshtml")]
    public class Views_ShowProduct_getProductById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "F:\New folder (3)\mvc-ecommerce\e-commerce-project\Views\ShowProduct\getProductById.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n\r\n<div");
            BeginWriteAttribute("class", " class=\"", 86, "\"", 94, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n    <main role=\"main\" class=\"pb-3\">\r\n\r\n        <div class=\"container-fluid py-5\">\r\n            <div class=\"row  px-xl-5\">\r\n\r\n                <div class=\"col-lg-7 pb-5 text-center\" style=\"height: 500px;\" >\r\n                    <img style=\"width:500px\"");
            BeginWriteAttribute("src", " src=\"", 348, "\"", 379, 2);
            WriteAttributeValue("", 354, "/productImages/", 354, 15, true);
#nullable restore
#line 17 "F:\New folder (3)\mvc-ecommerce\e-commerce-project\Views\ShowProduct\getProductById.cshtml"
WriteAttributeValue("", 369, Model.img, 369, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n\r\n                <div class=\"col-lg-5  align-self-center\">\r\n                    <h3 class=\"font-weight-semi-bold\">");
#nullable restore
#line 21 "F:\New folder (3)\mvc-ecommerce\e-commerce-project\Views\ShowProduct\getProductById.cshtml"
                                                 Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                    <div class=""d-flex mb-3"">
                        <div class=""text-primary mr-2"">
                            <small class=""fas fa-star""></small>
                            <small class=""fas fa-star""></small>
                            <small class=""fas fa-star""></small>
                            <small class=""fas fa-star-half-alt""></small>
                            <small class=""far fa-star""></small>
                        </div>
                        <small class=""pt-1"">(50 Reviews)</small>
                    </div>
                    <h3 class=""font-weight-semi-bold mb-4"">");
#nullable restore
#line 32 "F:\New folder (3)\mvc-ecommerce\e-commerce-project\Views\ShowProduct\getProductById.cshtml"
                                                      Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <p class=\"mb-4\">\r\n                        ");
#nullable restore
#line 34 "F:\New folder (3)\mvc-ecommerce\e-commerce-project\Views\ShowProduct\getProductById.cshtml"
                   Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </p>

                    <div class=""d-flex align-items-center mb-4 pt-2"">
                        <button class=""btn btn-primary px-3""><i class=""fa fa-shopping-cart mr-1""></i> Add To Cart</button>
                    </div>
                    <div class=""d-flex pt-2"">
                        <p class=""text-dark font-weight-medium mb-0 mr-2"">Share on:</p>
                        <div class=""d-inline-flex"">
                            <a class=""text-dark px-2""");
            BeginWriteAttribute("href", " href=\"", 1759, "\"", 1766, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <i class=\"fab fa-facebook-f\"></i>\r\n                            </a>\r\n                            <a class=\"text-dark px-2\"");
            BeginWriteAttribute("href", " href=\"", 1924, "\"", 1931, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <i class=\"fab fa-twitter\"></i>\r\n                            </a>\r\n                            <a class=\"text-dark px-2\"");
            BeginWriteAttribute("href", " href=\"", 2086, "\"", 2093, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <i class=\"fab fa-linkedin-in\"></i>\r\n                            </a>\r\n                            <a class=\"text-dark px-2\"");
            BeginWriteAttribute("href", " href=\"", 2252, "\"", 2259, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <i class=\"fab fa-pinterest\"></i>\r\n                            </a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </main>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
