#pragma checksum "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac20ebe07bb25ce5612f293e5686af53d4fd00d8"
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
#line 2 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Index.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Index.razor"
using OnlineBlazorApp.Data.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Index.razor"
using OnlineBlazorApp.Data.Service;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "banner");
            __builder.AddMarkupContent(2, "\r\n    \r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "id", "fwslider");
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 17 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Index.razor"
         if (usuario != null)
        {


#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "            ");
            __builder.OpenElement(7, "h3");
            __builder.AddContent(8, 
#nullable restore
#line 20 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Index.razor"
                 usuario.First().Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 21 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "        ");
            __builder.AddMarkupContent(11, @"<div class=""slider_container"">
            <div class=""slide"">
                
                <img src=""/Estilo/images/nike.jpg"" class=""img-responsive"" alt>
                
                
                <div class=""slide_content"">
                    <div class=""slide_content_wrap"">
                        
                        <h1 class=""title"">Run Over<br>Everything</h1>
                        
                        <div class=""button""><a href=""#"">See Details</a></div>
                    </div>
                </div>
                
            </div>
            
            <div class=""slide"">
                <img src=""/Estilo/images/nike2.jpg"" class=""img-responsive"" alt>
                <div class=""slide_content"">
                    <div class=""slide_content_wrap"">
                        <h1 class=""title"">Run Over<br>Everything</h1>
                        <div class=""button""><a href=""#"">See Details</a></div>
                    </div>
                </div>
            </div>
            
        </div>
        <div class=""timers""></div>
        ");
            __builder.AddMarkupContent(12, "<div class=\"slidePrev\"><span></span></div>\r\n        ");
            __builder.AddMarkupContent(13, "<div class=\"slideNext\"><span></span></div>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    \r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.AddMarkupContent(16, @"<div class=""main"">
    <div class=""content-top"">
        <h2>RECOMENDADOS</h2>
        <p>AQUI PODRÁS VER ALGUNOS ACCESORIOS QUE TE QUEREMOS RECOMENDAR ;)</p>

        <ul id=""flexiselDemo3"">
            <li><img src=""/Estilo/images/nike.jpg""></li>
            <li><img src=""/Estilo/images/nike2.jpg""></li>
            <li><img src=""/Estilo/images/nike3.jpg""></li>
            <li><img src=""/Estilo/images/nike3.jpg""></li>
            <li><img src=""/Estilo/images/nike.jpg""></li>
        </ul>
    </div>
</div>
");
            __builder.AddMarkupContent(17, @"<div class=""content-bottom"">
    <div class=""container"">
        <div class=""row content_bottom-text"">
            <div class=""col-md-7"">
                <h3 id=""t1"">ONLINE STORE</h3>
                <p class=""m_1"">
                    PRODUCTOS CON LA MEJOR CALIDAD Y EL MEJOR PRECIO
                </p>

            </div>
        </div>
    </div>
</div>
");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "features");
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "container");
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.AddMarkupContent(24, "<h3 class=\"m_3\">MAS COMPRADO</h3>\r\n\r\n        ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "row");
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "col-md-3 top_box");
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "view view-ninth");
            __builder.AddMarkupContent(33, "\r\n\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(34);
            __builder.AddAttribute(35, "activeClassName", "active");
            __builder.AddAttribute(36, "className", "nav-item link-light");
            __builder.AddAttribute(37, "href", "Single");
            __builder.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(39, "\r\n\r\n\r\n                        <img src=\"/Estilo/images/nike3.jpg\" class=\"img-responsive\" alt>\r\n                        ");
                __builder2.AddMarkupContent(40, "<div class=\"mask mask-1\"> </div>\r\n                        ");
                __builder2.AddMarkupContent(41, "<div class=\"mask mask-2\"> </div>\r\n                        ");
                __builder2.AddMarkupContent(42, "<div class=\"content\">\r\n                            <h2>TIENDA VIRTUAL</h2>\r\n                            <p>AQUIIIIIII USTED ESCRIBEEEEEEEEEEEEEEEEEE</p>\r\n                        </div>\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(43, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.AddMarkupContent(45, "<h4 class=\"m_4\"><a href=\"#\">TIENDA VIRTUAL</a></h4>\r\n                ");
            __builder.AddMarkupContent(46, "<p class=\"m_5\">TIENDA VIRTUAL</p>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n            ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "col-md-3 top_box");
            __builder.AddMarkupContent(50, "\r\n                ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "view view-ninth");
            __builder.AddMarkupContent(53, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(54);
            __builder.AddAttribute(55, "activeClassName", "active");
            __builder.AddAttribute(56, "className", "nav-item link-light");
            __builder.AddAttribute(57, "href", "Single");
            __builder.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(59, "\r\n                        <img src=\"/Estilo/images/nike.jpg\" class=\"img-responsive\" alt>\r\n                        ");
                __builder2.AddMarkupContent(60, "<div class=\"mask mask-1\"> </div>\r\n                        ");
                __builder2.AddMarkupContent(61, "<div class=\"mask mask-2\"> </div>\r\n                        ");
                __builder2.AddMarkupContent(62, "<div class=\"content\">\r\n                            <h2>TIENDA VIRTUAL</h2>\r\n                            <p>TIENDA VIRTUAL</p>\r\n                        </div>\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(63, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                ");
            __builder.AddMarkupContent(65, "<h4 class=\"m_4\"><a href=\"#\">TIENDA VIRTUAL</a></h4>\r\n                ");
            __builder.AddMarkupContent(66, "<p class=\"m_5\">TIENDA VIRTUAL</p>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n            ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "col-md-3 top_box");
            __builder.AddMarkupContent(70, "\r\n                ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "view view-ninth");
            __builder.AddMarkupContent(73, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(74);
            __builder.AddAttribute(75, "activeClassName", "active");
            __builder.AddAttribute(76, "className", "nav-item link-light");
            __builder.AddAttribute(77, "href", "Single");
            __builder.AddAttribute(78, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(79, "\r\n                        <img src=\"/Estilo/images/nike2.jpg\" class=\"img-responsive\" alt>\r\n                        ");
                __builder2.AddMarkupContent(80, "<div class=\"mask mask-1\"> </div>\r\n                        ");
                __builder2.AddMarkupContent(81, "<div class=\"mask mask-2\"> </div>\r\n                        ");
                __builder2.AddMarkupContent(82, "<div class=\"content\">\r\n                            <h2>TIENDA VIRTUAL</h2>\r\n                            <p>TIENDA VIRTUAL</p>\r\n                        </div>\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(83, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                ");
            __builder.AddMarkupContent(85, "<h4 class=\"m_4\"><a href=\"#\">TIENDA VIRTUAL</a></h4>\r\n                ");
            __builder.AddMarkupContent(86, "<p class=\"m_5\">TIENDA VIRTUAL</p>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n            ");
            __builder.OpenElement(88, "div");
            __builder.AddAttribute(89, "class", "col-md-3 top_box1");
            __builder.AddMarkupContent(90, "\r\n                ");
            __builder.OpenElement(91, "div");
            __builder.AddAttribute(92, "class", "view view-ninth");
            __builder.AddMarkupContent(93, "\r\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(94);
            __builder.AddAttribute(95, "activeClassName", "active");
            __builder.AddAttribute(96, "className", "nav-item link-light");
            __builder.AddAttribute(97, "href", "Single");
            __builder.AddAttribute(98, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(99, "\r\n                        <img src=\"/Estilo/images/nike3.jpg\" class=\"img-responsive\" alt>\r\n                        ");
                __builder2.AddMarkupContent(100, "<div class=\"mask mask-1\"> </div>\r\n                        ");
                __builder2.AddMarkupContent(101, "<div class=\"mask mask-2\"> </div>\r\n                        ");
                __builder2.AddMarkupContent(102, "<div class=\"content\">\r\n                            <h2>TIENDA VIRTUAL</h2>\r\n                            <p>TIENDA VIRTUAL</p>\r\n                        </div>\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(103, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n                ");
            __builder.AddMarkupContent(105, "<h4 class=\"m_4\"><a href=\"#\">TIENDA VIRTUAL</a></h4>\r\n                ");
            __builder.AddMarkupContent(106, "<p class=\"m_5\">TIENDA VIRTUAL</p>\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 163 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Index.razor"
       
    IEnumerable<AspNetUsers> usuario;
    string id;

    protected override async Task OnInitializedAsync()
    {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 169 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Index.razor"
     if (httpContextAccessor.HttpContext.User.Identity.Name != null)
    {
        usuario = await AspNetUsersService.GetUsuario(httpContextAccessor.HttpContext.User.Identity.Name);
        id= usuario.First().Id;
        sessionIDU.SetItemAsync("idu", id);

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 175 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Index.razor"
     
        
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor httpContextAccessor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAspNetUsersService AspNetUsersService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionIDU { get; set; }
    }
}
#pragma warning restore 1591
