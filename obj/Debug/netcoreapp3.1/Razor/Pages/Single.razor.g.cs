#pragma checksum "C:\Users\User\OneDrive\Escritorio\proyecto_tienda\Tienda-Blazor\Pages\Single.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28d1751ebda61de65834fe0b67652cf8e668b0ff"
// <auto-generated/>
#pragma warning disable 1591
namespace OnlineBlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\OneDrive\Escritorio\proyecto_tienda\Tienda-Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\OneDrive\Escritorio\proyecto_tienda\Tienda-Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\OneDrive\Escritorio\proyecto_tienda\Tienda-Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\OneDrive\Escritorio\proyecto_tienda\Tienda-Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\OneDrive\Escritorio\proyecto_tienda\Tienda-Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\OneDrive\Escritorio\proyecto_tienda\Tienda-Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\OneDrive\Escritorio\proyecto_tienda\Tienda-Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\OneDrive\Escritorio\proyecto_tienda\Tienda-Blazor\_Imports.razor"
using OnlineBlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\OneDrive\Escritorio\proyecto_tienda\Tienda-Blazor\_Imports.razor"
using OnlineBlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\OneDrive\Escritorio\proyecto_tienda\Tienda-Blazor\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\User\OneDrive\Escritorio\proyecto_tienda\Tienda-Blazor\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/single")]
    public partial class Single : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "main");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "shop_top");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "container");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "row");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.AddMarkupContent(12, "<div class=\"col-md-9 single_left\">\r\n                    <div class=\"single_image\">\r\n                        <ul id=\"etalage\">\r\n                            <li>\r\n\r\n                                <img class=\"etalage_thumb_image\" src=\"/Estilo/images/nike2.jpg\">\r\n                                <img class=\"etalage_source_image\" src=\"/Estilo/images/nike2.jpg\">\r\n\r\n                            </li>\r\n                        </ul>\r\n                    </div>\r\n                    \r\n                    <div class=\"single_right\">\r\n                        <h3>hendrerit in vulputate velit </h3>\r\n                        <p class=\"m_10\">Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse</p>\r\n                        <ul class=\"options\">\r\n                            <h4 class=\"m_12\">Talla:</h4>\r\n                            <li><a href=\"#\">38</a></li>\r\n                            <li><a href=\"#\">39</a></li>\r\n                            <li><a href=\"#\">40</a></li>\r\n                            <li><a href=\"#\">41</a></li>\r\n                            <li><a href=\"#\">42</a></li>\r\n                            <li><a href=\"#\">43</a></li>\r\n                        </ul>\r\n                        <ul class=\"product-colors\">\r\n                            <h3>available Colors</h3>\r\n                            <li><a class=\"color1\" href=\"#\"><span> </span></a></li>\r\n                            <li><a class=\"color2\" href=\"#\"><span> </span></a></li>\r\n                            <li><a class=\"color3\" href=\"#\"><span> </span></a></li>\r\n                            <li><a class=\"color4\" href=\"#\"><span> </span></a></li>\r\n                            <li><a class=\"color5\" href=\"#\"><span> </span></a></li>\r\n                            <li><a class=\"color6\" href=\"#\"><span> </span></a></li>\r\n                            <div class=\"clear\"> </div>\r\n                        </ul>\r\n                        <div class=\"btn_form\">\r\n                            <form>\r\n                                <input type=\"submit\" value=\"buy now\" title>\r\n                            </form>\r\n                        </div>\r\n\r\n\r\n                    </div>\r\n                    <div class=\"clear\"> </div>\r\n                </div>\r\n                ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "col-md-3");
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "box-info-product");
            __builder.AddMarkupContent(18, "\r\n                        ");
            __builder.AddMarkupContent(19, "<p class=\"price2\">$180.000</p>\r\n                        ");
            __builder.OpenElement(20, "ul");
            __builder.AddAttribute(21, "class", "prosuct-qty");
            __builder.AddMarkupContent(22, "\r\n                            ");
            __builder.AddMarkupContent(23, "<span>Cantidad:</span>\r\n                            ");
            __builder.OpenElement(24, "select");
            __builder.AddMarkupContent(25, "\r\n                                ");
            __builder.OpenElement(26, "option");
            __builder.AddContent(27, "1");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                                ");
            __builder.OpenElement(29, "option");
            __builder.AddContent(30, "2");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                                ");
            __builder.OpenElement(32, "option");
            __builder.AddContent(33, "3");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                                ");
            __builder.OpenElement(35, "option");
            __builder.AddContent(36, "4");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                                ");
            __builder.OpenElement(38, "option");
            __builder.AddContent(39, "5");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                                ");
            __builder.OpenElement(41, "option");
            __builder.AddContent(42, "6");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                        ");
            __builder.AddMarkupContent(46, "<button type=\"submit\" name=\"Submit\" class=\"exclusive\">\r\n                            <span>Add to cart</span>\r\n                        </button>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n            ");
            __builder.AddMarkupContent(50, @"<div class=""desc"">
                <h4>Description</h4>
                <p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat. Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue duis dolore te feugait nulla facilisi. Nam liber tempor cum soluta nobis eleifend option congue nihil imperdiet doming id quod mazim placerat facer possim assum. Typi non habent claritatem insitam; est usus legentis in iis qui facit eorum claritatem. Investigationes demonstraverunt lectores</p>
            </div>

        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
