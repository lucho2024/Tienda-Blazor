#pragma checksum "C:\Users\luish\source\repos\OnlineBlazorApp\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ebb2df1b7591f130a0a7224ef990bae275dc56f"
// <auto-generated/>
#pragma warning disable 1591
namespace OnlineBlazorApp.Shared
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
#line 1 "C:\Users\luish\source\repos\OnlineBlazorApp\Shared\NavMenu.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "header");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col-md-12");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "header-left");
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "logo");
            __builder.AddMarkupContent(17, "\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(18);
            __builder.AddAttribute(19, "href", "/");
            __builder.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(21, "<img src=\"/Estilo/images/logo.png\" alt>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "menu");
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(27);
            __builder.AddAttribute(28, "class", "toggleMenu");
            __builder.AddAttribute(29, "href", "#");
            __builder.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(31, "<img src=\"/Estilo/images/nav.png\" alt>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(32, "\r\n                        ");
            __builder.OpenElement(33, "ul");
            __builder.AddAttribute(34, "class", "nav");
            __builder.AddAttribute(35, "id", "nav");
            __builder.AddMarkupContent(36, "\r\n");
#nullable restore
#line 14 "C:\Users\luish\source\repos\OnlineBlazorApp\Shared\NavMenu.razor"
                             if (@httpContextAccessor.HttpContext.User.Identity.Name == null)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(37, "                                ");
            __builder.OpenElement(38, "li");
            __builder.AddMarkupContent(39, "\r\n                                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(40);
            __builder.AddAttribute(41, "activeClassName", "active");
            __builder.AddAttribute(42, "className", "nav-item link-light");
            __builder.AddAttribute(43, "href", "/identity/account/login");
            __builder.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(45, "\r\n                                        Login\r\n                                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(46, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                                ");
            __builder.OpenElement(48, "li");
            __builder.AddMarkupContent(49, "\r\n                                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(50);
            __builder.AddAttribute(51, "activeClassName", "active");
            __builder.AddAttribute(52, "className", "nav-item link-light");
            __builder.AddAttribute(53, "href", "/identity/account/register");
            __builder.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(55, "\r\n                                        Sing up\r\n                                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(56, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n");
#nullable restore
#line 30 "C:\Users\luish\source\repos\OnlineBlazorApp\Shared\NavMenu.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(58, "\r\n                            \r\n");
#nullable restore
#line 39 "C:\Users\luish\source\repos\OnlineBlazorApp\Shared\NavMenu.razor"
                             if (@httpContextAccessor.HttpContext.User.Identity.Name != null)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(59, "                                ");
            __builder.OpenElement(60, "li");
            __builder.AddMarkupContent(61, "\r\n                                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(62);
            __builder.AddAttribute(63, "activeClassName", "active");
            __builder.AddAttribute(64, "className", "nav-item link-light");
            __builder.AddAttribute(65, "href", "/producto-add");
            __builder.AddAttribute(66, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(67, "\r\n                                        Añadir producto\r\n                                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(68, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                                ");
            __builder.OpenElement(70, "li");
            __builder.AddMarkupContent(71, "\r\n                                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(72);
            __builder.AddAttribute(73, "activeClassName", "active");
            __builder.AddAttribute(74, "className", "nav-item link-light");
            __builder.AddAttribute(75, "href", "/productos-list");
            __builder.AddAttribute(76, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(77, "\r\n                                        Lista productos\r\n                                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(78, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                                ");
            __builder.OpenElement(80, "li");
            __builder.AddMarkupContent(81, "\r\n                                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(82);
            __builder.AddAttribute(83, "activeClassName", "active");
            __builder.AddAttribute(84, "className", "nav-item link-light");
            __builder.AddAttribute(85, "href", "/descuento");
            __builder.AddAttribute(86, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(87, "\r\n                                        Añadir descuento\r\n                                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(88, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n                                ");
            __builder.OpenElement(90, "li");
            __builder.AddMarkupContent(91, "\r\n                                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(92);
            __builder.AddAttribute(93, "activeClassName", "active");
            __builder.AddAttribute(94, "className", "nav-item link-light");
            __builder.AddAttribute(95, "href", "/descuentos-list");
            __builder.AddAttribute(96, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(97, "\r\n                                        Lista Descuentos\r\n                                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(98, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n");
#nullable restore
#line 69 "C:\Users\luish\source\repos\OnlineBlazorApp\Shared\NavMenu.razor"
                               
                                            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(100, "\r\n                            ");
            __builder.OpenElement(101, "li");
            __builder.AddMarkupContent(102, "\r\n                                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(103);
            __builder.AddAttribute(104, "activeClassName", "active");
            __builder.AddAttribute(105, "className", "nav-item link-light");
            __builder.AddAttribute(106, "href", "/categorias");
            __builder.AddAttribute(107, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(108, "\r\n                                    Categorias\r\n                                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(109, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n\r\n                            ");
            __builder.OpenElement(111, "li");
            __builder.AddMarkupContent(112, "\r\n                                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(113);
            __builder.AddAttribute(114, "activeClassName", "active");
            __builder.AddAttribute(115, "className", "nav-item link-light");
            __builder.AddAttribute(116, "href", "/devoluciones");
            __builder.AddAttribute(117, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(118, "\r\n                                    Devoluciones\r\n                                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(119, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n                            ");
            __builder.OpenElement(121, "li");
            __builder.AddMarkupContent(122, "\r\n                                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(123);
            __builder.AddAttribute(124, "activeClassName", "active");
            __builder.AddAttribute(125, "className", "nav-item link-light");
            __builder.AddAttribute(126, "href", "/shop");
            __builder.AddAttribute(127, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(128, "\r\n                                    Shop\r\n                                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(129, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n                    <div class=\"clear\"></div>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(133, "\r\n                ");
            __builder.OpenElement(134, "div");
            __builder.AddAttribute(135, "class", "header_right");
            __builder.AddMarkupContent(136, "\r\n                    \r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(137);
            __builder.AddAttribute(138, "href", "Carrito");
            __builder.AddAttribute(139, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(140, "\r\n                        <img src=\"/Estilo/images/carrito.png\" width=\"25\" alt=\"Ver carrito de compras\">\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(141, "\r\n                    &nbsp;\r\n                    &nbsp;\r\n                    &nbsp;\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(142);
            __builder.AddAttribute(143, "href", "Editardatos");
            __builder.AddAttribute(144, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(145, "\r\n                        <img src=\"/Estilo/images/lapiz.png\" width=\"25\" alt=\"Editar datos de usuario\">\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(146, "\r\n                    \r\n\r\n\r\n                    <div class=\"clear\"></div>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(147, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(148, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(149, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor httpContextAccessor { get; set; }
    }
}
#pragma warning restore 1591
