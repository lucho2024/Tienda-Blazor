#pragma checksum "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Shared\Categoria.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22568834c9f4fc6aa5094b8a5bdedf0072a37799"
// <auto-generated/>
#pragma warning disable 1591
namespace OnlineBlazorApp.Pages.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\luish\source\repos\OnlineBlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\luish\source\repos\OnlineBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\luish\source\repos\OnlineBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\luish\source\repos\OnlineBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\luish\source\repos\OnlineBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\luish\source\repos\OnlineBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\luish\source\repos\OnlineBlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\luish\source\repos\OnlineBlazorApp\_Imports.razor"
using OnlineBlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\luish\source\repos\OnlineBlazorApp\_Imports.razor"
using OnlineBlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\luish\source\repos\OnlineBlazorApp\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\luish\source\repos\OnlineBlazorApp\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Shared\Categoria.razor"
using OnlineBlazorApp.Data.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Shared\Categoria.razor"
using OnlineBlazorApp.Data.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Shared\Categoria.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Shared\Categoria.razor"
using Microsoft.AspNetCore.WebUtilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Shared\Categoria.razor"
using Microsoft.Extensions.Primitives;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/categoria")]
    public partial class Categoria : Microsoft.AspNetCore.Components.ComponentBase
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
            __builder.AddAttribute(10, "class", "pagination");
            __builder.AddMarkupContent(11, "\r\n\r\n                ");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Shared\Categoria.razor"
                                  () => ChangeP(1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(14, "    ");
            __builder.AddMarkupContent(15, "<a>1</a> ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Shared\Categoria.razor"
                                  () => ChangeP(2)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(19, "    ");
            __builder.AddMarkupContent(20, "<a>2</a> ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "row shop_box-top");
            __builder.AddMarkupContent(25, "\r\n\r\n");
#nullable restore
#line 28 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Shared\Categoria.razor"
                 if (productosc != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Shared\Categoria.razor"
                     foreach (var producto in productosc)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(26, "                        ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "col-md-3 shop_box");
            __builder.AddMarkupContent(29, "\r\n                            ");
            __builder.OpenElement(30, "a");
            __builder.AddAttribute(31, "href", "Single");
            __builder.AddMarkupContent(32, "\r\n                                ");
            __builder.OpenElement(33, "img");
            __builder.AddAttribute(34, "src", 
#nullable restore
#line 34 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Shared\Categoria.razor"
                                           producto.imagen

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(35, "asp-append-version", "true");
            __builder.AddAttribute(36, "class", "img-responsive");
            __builder.AddAttribute(37, "alt", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                                ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "shop_desc");
            __builder.AddMarkupContent(41, "\r\n                                    ");
            __builder.OpenElement(42, "h3");
            __builder.OpenElement(43, "a");
            __builder.AddAttribute(44, "href", "#");
            __builder.AddContent(45, 
#nullable restore
#line 36 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Shared\Categoria.razor"
                                                     producto.nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                                    ");
            __builder.OpenElement(47, "p");
            __builder.AddContent(48, 
#nullable restore
#line 37 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Shared\Categoria.razor"
                                        producto.descripcion

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(49, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n");
#nullable restore
#line 38 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Shared\Categoria.razor"
                                     if (@producto.precioDescuento > 0)
                                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(51, "                                        ");
            __builder.OpenElement(52, "span");
            __builder.AddAttribute(53, "class", "reducedfrom");
            __builder.AddContent(54, 
#nullable restore
#line 40 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Shared\Categoria.razor"
                                                                   producto.precio

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                                        ");
            __builder.OpenElement(56, "span");
            __builder.AddAttribute(57, "class", "actual");
            __builder.AddContent(58, 
#nullable restore
#line 41 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Shared\Categoria.razor"
                                                              producto.precioDescuento

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "<br>\r\n");
#nullable restore
#line 42 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Shared\Categoria.razor"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(60, "                                        ");
            __builder.OpenElement(61, "span");
            __builder.AddAttribute(62, "class", "actual");
            __builder.AddContent(63, 
#nullable restore
#line 45 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Shared\Categoria.razor"
                                                              producto.precio

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "<br>\r\n");
#nullable restore
#line 46 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Shared\Categoria.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(65, "\r\n                                    ");
            __builder.OpenElement(66, "ul");
            __builder.AddAttribute(67, "class", "buttons");
            __builder.AddMarkupContent(68, "\r\n");
#nullable restore
#line 49 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Shared\Categoria.razor"
                                         if (httpContextAccessor.HttpContext.User.Identity.Name != null)
                                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(69, "                                            ");
            __builder.AddMarkupContent(70, "<li class=\"cart\"><a href=\"#\">Add To Cart</a></li>\r\n                                            ");
            __builder.AddMarkupContent(71, "<li class=\"shop_btn\"><a href=\"#\">Read More</a></li>\r\n                                            ");
            __builder.AddMarkupContent(72, "<div class=\"clear\"> </div>\r\n");
#nullable restore
#line 54 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Shared\Categoria.razor"
                                        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(73, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n");
#nullable restore
#line 60 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Shared\Categoria.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Shared\Categoria.razor"
                     
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(78, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Shared\Categoria.razor"
       

    public string cate;
    IEnumerable<Producto> productosc;

    protected override async Task OnInitializedAsync()
    {

        StringValues categoria;
        var uri = NavigationManager.ToAbsoluteUri(NavigationManager.Uri);
        if (QueryHelpers.ParseQuery(uri.Query).TryGetValue("categoria", out categoria))
        {
            cate = categoria;
        }

        productosc = await ProductoService.GetProductoByCategory(cate, 1);

    }
    protected async Task ChangeP(int pagina)
    {
        productosc = await ProductoService.GetProductoByCategory(cate, pagina);
    }   


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor httpContextAccessor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionCarrito { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductoService ProductoService { get; set; }
    }
}
#pragma warning restore 1591
