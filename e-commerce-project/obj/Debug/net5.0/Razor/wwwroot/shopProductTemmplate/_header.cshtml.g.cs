#pragma checksum "F:\New folder (3)\mvc-ecommerce\e-commerce-project\wwwroot\shopProductTemmplate\_header.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5430a92548702060f0c6275500e652e5d3e0a58d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.wwwroot_shopProductTemmplate__header), @"mvc.1.0.view", @"/wwwroot/shopProductTemmplate/_header.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5430a92548702060f0c6275500e652e5d3e0a58d", @"/wwwroot/shopProductTemmplate/_header.cshtml")]
    public class wwwroot_shopProductTemmplate__header : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <!-- Topbar Start -->
    <div class=""container-fluid"">
        <div class=""row bg-secondary py-2 px-xl-5"">
            <div class=""col-lg-6 d-none d-lg-block"">
                <div class=""d-inline-flex align-items-center"">
                    <a class=""text-dark""");
            BeginWriteAttribute("href", " href=\"", 273, "\"", 280, 0);
            EndWriteAttribute();
            WriteLiteral(">FAQs</a>\r\n                    <span class=\"text-muted px-2\">|</span>\r\n                    <a class=\"text-dark\"");
            BeginWriteAttribute("href", " href=\"", 392, "\"", 399, 0);
            EndWriteAttribute();
            WriteLiteral(">Help</a>\r\n                    <span class=\"text-muted px-2\">|</span>\r\n                    <a class=\"text-dark\"");
            BeginWriteAttribute("href", " href=\"", 511, "\"", 518, 0);
            EndWriteAttribute();
            WriteLiteral(">Support</a>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-6 text-center text-lg-right\">\r\n                <div class=\"d-inline-flex align-items-center\">\r\n                    <a class=\"text-dark px-2\"");
            BeginWriteAttribute("href", " href=\"", 748, "\"", 755, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <i class=\"fab fa-facebook-f\"></i>\r\n                    </a>\r\n                    <a class=\"text-dark px-2\"");
            BeginWriteAttribute("href", " href=\"", 889, "\"", 896, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <i class=\"fab fa-twitter\"></i>\r\n                    </a>\r\n                    <a class=\"text-dark px-2\"");
            BeginWriteAttribute("href", " href=\"", 1027, "\"", 1034, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <i class=\"fab fa-linkedin-in\"></i>\r\n                    </a>\r\n                    <a class=\"text-dark px-2\"");
            BeginWriteAttribute("href", " href=\"", 1169, "\"", 1176, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <i class=\"fab fa-instagram\"></i>\r\n                    </a>\r\n                    <a class=\"text-dark pl-2\"");
            BeginWriteAttribute("href", " href=\"", 1309, "\"", 1316, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <i class=""fab fa-youtube""></i>
                    </a>
                </div>
            </div>
        </div>
        <div class=""row align-items-center py-3 px-xl-5"">
            <div class=""col-lg-3 d-none d-lg-block"">
                <a");
            BeginWriteAttribute("href", " href=\"", 1593, "\"", 1600, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""text-decoration-none"">
                    <h1 class=""m-0 display-5 font-weight-semi-bold""><span class=""text-primary font-weight-bold border px-3 mr-1"">E</span>Shopper</h1>
                </a>
            </div>
            <div class=""col-lg-6 col-6 text-left"">
                <form");
            BeginWriteAttribute("action", " action=\"", 1899, "\"", 1908, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""input-group"" id=""search"">
                        <input oninput=""whenInput(event)"" type=""text"" class=""form-control"" placeholder=""Search for products"">
                        <div class=""input-group-append"">
                            <span class=""input-group-text bg-transparent text-primary"">
                                <i class=""fa fa-search""></i>
                            </span>
                        </div>
                        <div class=""search-result""></div>
                    </div>
                </form>
            </div>
            <div class=""col-lg-3 col-6 text-right"">
");
#nullable restore
#line 53 "F:\New folder (3)\mvc-ecommerce\e-commerce-project\wwwroot\shopProductTemmplate\_header.cshtml"
                  
                     if(User.Identity.IsAuthenticated == true){

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=\"", 2672, "\"", 2679, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn border\">\r\n                            <i class=\"fas fa-user text-primary\"></i>\r\n                            ");
#nullable restore
#line 57 "F:\New folder (3)\mvc-ecommerce\e-commerce-project\wwwroot\shopProductTemmplate\_header.cshtml"
                       Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </a>\r\n");
#nullable restore
#line 59 "F:\New folder (3)\mvc-ecommerce\e-commerce-project\wwwroot\shopProductTemmplate\_header.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <a href=""/Cart/ShowOrder"" class=""btn border"">
                <i class=""fas fa-shopping-cart text-primary""></i>
                <span id=""cartIcon"" class=""badge"">0</span>
            </a>
        </div>
    </div>
</div>
<!-- Topbar End -->


<!-- Navbar Start -->
<div class=""container-fluid"">
    <div class=""row border-top px-xl-5"">
        <div class=""col-lg-3 d-none d-lg-block"">
            <a class=""btn shadow-none d-flex align-items-center justify-content-between bg-primary text-white w-100"" data-toggle=""collapse"" href=""#navbar-vertical"" style=""height: 65px; margin-top: -1px; padding: 0 30px;"">
                <h6 class=""m-0"">Categories</h6>
                <i class=""fa fa-angle-down text-dark""></i>
            </a>
            <nav class=""collapse position-absolute navbar navbar-vertical navbar-light align-items-start p-0 border border-top-0 border-bottom-0 bg-light"" id=""navbar-vertical"" style=""width: calc(100% - 30px); z-index: 1;"">
                <div class=""navbar-nav ");
            WriteLiteral(@"w-100 overflow-hidden"" style=""height: 410px"">
                    <div class=""nav-item dropdown"">
                        <a href=""#"" class=""nav-link"" data-toggle=""dropdown"">Dresses <i class=""fa fa-angle-down float-right mt-1""></i></a>
                        <div class=""dropdown-menu position-absolute bg-secondary border-0 rounded-0 w-100 m-0"">
                            <a");
            BeginWriteAttribute("href", " href=\"", 4287, "\"", 4294, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"dropdown-item\">Men\'s Dresses</a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 4367, "\"", 4374, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"dropdown-item\">Women\'s Dresses</a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 4449, "\"", 4456, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"dropdown-item\">Baby\'s Dresses</a>\r\n                        </div>\r\n                    </div>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 4582, "\"", 4589, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-item nav-link\">Shirts</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 4651, "\"", 4658, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-item nav-link\">Jeans</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 4719, "\"", 4726, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-item nav-link\">Swimwear</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 4790, "\"", 4797, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-item nav-link\">Sleepwear</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 4862, "\"", 4869, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-item nav-link\">Sportswear</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 4935, "\"", 4942, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-item nav-link\">Jumpsuits</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 5007, "\"", 5014, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-item nav-link\">Blazers</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 5077, "\"", 5084, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-item nav-link\">Jackets</a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 5147, "\"", 5154, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-item nav-link\">Shoes</a>\r\n                </div>\r\n            </nav>\r\n        </div>\r\n        <div class=\"col-lg-9\">\r\n            <nav class=\"navbar navbar-expand-lg bg-light navbar-light py-3 py-lg-0 px-0\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 5394, "\"", 5401, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""text-decoration-none d-block d-lg-none"">
                    <h1 class=""m-0 display-5 font-weight-semi-bold""><span class=""text-primary font-weight-bold border px-3 mr-1"">E</span>Shopper</h1>
                </a>
                <button type=""button"" class=""navbar-toggler"" data-toggle=""collapse"" data-target=""#navbarCollapse"">
                    <span class=""navbar-toggler-icon""></span>
                </button>
                <div class=""collapse navbar-collapse justify-content-between"" id=""navbarCollapse"">
                    <div class=""navbar-nav mr-auto py-0"">
                        <a href=""index.html"" class=""nav-item nav-link"">Home</a>
                        <a href=""/ShowProduct/Products"" class=""nav-item nav-link active"">Shop</a>
");
#nullable restore
#line 113 "F:\New folder (3)\mvc-ecommerce\e-commerce-project\wwwroot\shopProductTemmplate\_header.cshtml"
                          
                            if (User.Identity.IsAuthenticated == true)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a href=\"/allSubmittedOrders/Index/\" class=\"nav-item nav-link\">My Orders</a>\r\n");
#nullable restore
#line 117 "F:\New folder (3)\mvc-ecommerce\e-commerce-project\wwwroot\shopProductTemmplate\_header.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                        <div class=\"navbar-nav ml-auto py-0\">\r\n");
#nullable restore
#line 121 "F:\New folder (3)\mvc-ecommerce\e-commerce-project\wwwroot\shopProductTemmplate\_header.cshtml"
                          
                            if(User.Identity.IsAuthenticated == true){

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a onclick=\"whenSignOut()\" href=\"/Account/signout\" class=\"nav-item nav-link\">sign out</a>\r\n");
#nullable restore
#line 124 "F:\New folder (3)\mvc-ecommerce\e-commerce-project\wwwroot\shopProductTemmplate\_header.cshtml"
                            }else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a href=\"/Account/Login\" class=\"nav-item nav-link\">Login</a>\r\n                                <a href=\"/Account/signUp\" class=\"nav-item nav-link\">Register</a>\r\n");
#nullable restore
#line 128 "F:\New folder (3)\mvc-ecommerce\e-commerce-project\wwwroot\shopProductTemmplate\_header.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                    </div>
                </nav>
            </div>
        </div>
    </div>
    <!-- Navbar End -->

    <script>
        readFromStorageAndShow();

        document.addEventListener(""countChange"",()=>{
            readFromStorageAndShow()
        })

        function readFromStorageAndShow(){
            if(localStorage.getItem(""count"")){
                document.querySelector(""#cartIcon"").innerHTML=localStorage.getItem(""count"");
                return;
            }
            document.querySelector(""#cartIcon"").innerHTML="""";
        }
        function whenSignOut(){
            localStorage.removeItem(""count"")
        }

       function whenInput({target:{value}}){
            $.ajax({
                  url:`/ShowProduct/search?name=${value}`,
                  success: function(res){
                      drawData(res)
                    },
                    error:function(request, status, error){
                      ");
            WriteLiteral(@"  console.log(""sasds"")
                    }
          });
       }

       function drawData(data){
           $("".search-result"").html("""")
           data.forEach(({img,name,id})=>{
               $("".search-result"").append(`
                     <a href=""/ShowProduct/getProductById/${id}"">
                        <div class=""product-item"" style=""display:flex;"">
                            <img width=""50px"" src=""/productImages/${img}"" alt="""">
                            <div>${name}</div>
                        </div>
                     </a>
               `)
           })
       }
    </script>



        <style>
            #search{
                position:relative;
            }
            .search-result{
                position: absolute;
                width: 100%;
                top: 100%;
                left: 0;
                z-index: 10;
                max-height: 408px;
                overflow: auto;
                background-color:white;
           ");
            WriteLiteral(@"     box-shadow:0px 3px 8px -2px rgba(0,0,0,0.63);
            }

           .product-item{
                display: flex;
                padding: 13px;
                align-items: center;
                border-bottom: 1px solid #d1d0d063;
            }
            .product-item img{
                margin-right: 11px;
            }
            .search-result a{
                text-decoration:none;
            }
        </style>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
