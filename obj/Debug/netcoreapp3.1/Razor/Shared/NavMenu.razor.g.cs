#pragma checksum "C:\Users\luish\source\repos\OnlineBlazorApp\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "726e7a85199aede500d31618826067f2a617d419"
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "navbar navbar-expand-lg navbar-light bg-light");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, @"<button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarTogglerDemo01"" aria-controls=""navbarTogglerDemo01"" aria-expanded=""false"" aria-label=""Toggle navigation"">
        <span class=""navbar-toggler-icon""></span>
    </button>
    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "collapse navbar-collapse");
            __builder.AddAttribute(6, "id", "navbarTogglerDemo01");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<a class=\"navbar-brand\" href=\"#\">Hidden brand</a>\r\n        ");
            __builder.OpenElement(9, "ul");
            __builder.AddAttribute(10, "class", "navbar-nav mr-auto mt-2 mt-lg-0");
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "li");
            __builder.AddAttribute(13, "class", "nav-item mr-1");
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(15);
            __builder.AddAttribute(16, "activeClassName", "active");
            __builder.AddAttribute(17, "className", "nav-item link-light");
            __builder.AddAttribute(18, "href", "identity/account/login");
            __builder.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(20, "\r\n                    Login\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenElement(23, "li");
            __builder.AddAttribute(24, "class", "nav-item");
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(26);
            __builder.AddAttribute(27, "activeClassName", "active");
            __builder.AddAttribute(28, "className", "nav-item link-light");
            __builder.AddAttribute(29, "href", "identity/account/register");
            __builder.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(31, "\r\n                    Sing up\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.OpenElement(34, "li");
            __builder.AddAttribute(35, "class", "nav-item");
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(37);
            __builder.AddAttribute(38, "activeClassName", "active");
            __builder.AddAttribute(39, "className", "nav-item link-light");
            __builder.AddAttribute(40, "href", "lista");
            __builder.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(42, "\r\n                    Lista usuarios\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(43, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n            ");
            __builder.OpenElement(45, "li");
            __builder.AddAttribute(46, "class", "nav-item");
            __builder.AddMarkupContent(47, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(48);
            __builder.AddAttribute(49, "activeClassName", "active");
            __builder.AddAttribute(50, "className", "nav-item link-light");
            __builder.AddAttribute(51, "href", "producto-add");
            __builder.AddAttribute(52, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(53, "\r\n                    Añadir producto\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(54, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n            ");
            __builder.OpenElement(56, "li");
            __builder.AddAttribute(57, "class", "nav-item");
            __builder.AddMarkupContent(58, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(59);
            __builder.AddAttribute(60, "activeClassName", "active");
            __builder.AddAttribute(61, "className", "nav-item link-light");
            __builder.AddAttribute(62, "href", "productos-list");
            __builder.AddAttribute(63, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(64, "\r\n                    Lista productos\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(65, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n        ");
            __builder.AddMarkupContent(68, @"<form class=""form-inline my-2 my-lg-0"">
            <input class=""form-control mr-sm-2"" type=""search"" placeholder=""Search"" aria-label=""Search"">
            <button class=""btn btn-outline-success my-2 my-sm-0"" type=""submit"">Search</button>
        </form>
    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
