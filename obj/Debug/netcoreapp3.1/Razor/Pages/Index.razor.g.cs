#pragma checksum "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59a031cafdcad1680ab655fe5343ceb32e545fb7"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""banner"">
    
    <div id=""fwslider"">
        <div class=""slider_container"">
            <div class=""slide"">
                
                <img src=""/Pruebaestilo/images/nike.jpg"" class=""img-responsive"" alt>
                
                
                <div class=""slide_content"">
                    <div class=""slide_content_wrap"">
                        
                        <h1 class=""title"">Run Over<br>Everything</h1>
                        
                        <div class=""button""><a href=""#"">See Details</a></div>
                    </div>
                </div>
                
            </div>
            
            <div class=""slide"">
                <img src=""/Pruebaestilo/images/nike2.jpg"" class=""img-responsive"" alt>
                <div class=""slide_content"">
                    <div class=""slide_content_wrap"">
                        <h1 class=""title"">Run Over<br>Everything</h1>
                        <div class=""button""><a href=""#"">See Details</a></div>
                    </div>
                </div>
            </div>
            
        </div>
        <div class=""timers""></div>
        <div class=""slidePrev""><span></span></div>
        <div class=""slideNext""><span></span></div>
    </div>
    
</div>
");
            __builder.AddMarkupContent(1, @"<div class=""main"">
    <div class=""content-top"">
        <h2>RECOMENDADOS</h2>
        <p>AQUI PODRÁS VER ALGUNOS ACCESORIOS QUE TE QUEREMOS RECOMENDAR ;)</p>

        <ul id=""flexiselDemo3"">
            <li><img src=""/Pruebaestilo/images/nike.jpg""></li>
            <li><img src=""/Pruebaestilo/images/nike2.jpg""></li>
            <li><img src=""/Pruebaestilo/images/nike3.jpg""></li>
            <li><img src=""/Pruebaestilo/images/nike3.jpg""></li>
            <li><img src=""/Pruebaestilo/images/nike.jpg""></li>
        </ul>
    </div>
</div>
");
            __builder.AddMarkupContent(2, @"<div class=""content-bottom"">
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
            __builder.AddMarkupContent(3, "<div class=\"features\">\r\n    <div class=\"container\">\r\n        <h3 class=\"m_3\">MAS COMPRADO</h3>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-md-3 top_box\">\r\n                <div class=\"view view-ninth\">\r\n                    <a href=\"single.html\">\r\n                        <img src=\"/Pruebaestilo/images/nike3.jpg\" class=\"img-responsive\" alt>\r\n                        <div class=\"mask mask-1\"> </div>\r\n                        <div class=\"mask mask-2\"> </div>\r\n                        <div class=\"content\">\r\n                            <h2>TIENDA VIRTUAL</h2>\r\n                            <p>AQUIIIIIII USTED ESCRIBEEEEEEEEEEEEEEEEEE</p>\r\n                        </div>\r\n                    </a>\r\n                </div>\r\n                <h4 class=\"m_4\"><a href=\"#\">TIENDA VIRTUAL</a></h4>\r\n                <p class=\"m_5\">TIENDA VIRTUAL</p>\r\n            </div>\r\n            <div class=\"col-md-3 top_box\">\r\n                <div class=\"view view-ninth\">\r\n                    <a href=\"single.html\">\r\n                        <img src=\"/Pruebaestilo/images/nike.jpg\" class=\"img-responsive\" alt>\r\n                        <div class=\"mask mask-1\"> </div>\r\n                        <div class=\"mask mask-2\"> </div>\r\n                        <div class=\"content\">\r\n                            <h2>TIENDA VIRTUAL</h2>\r\n                            <p>TIENDA VIRTUAL</p>\r\n                        </div>\r\n                    </a>\r\n                </div>\r\n                <h4 class=\"m_4\"><a href=\"#\">TIENDA VIRTUAL</a></h4>\r\n                <p class=\"m_5\">TIENDA VIRTUAL</p>\r\n            </div>\r\n            <div class=\"col-md-3 top_box\">\r\n                <div class=\"view view-ninth\">\r\n                    <a href=\"single.html\">\r\n                        <img src=\"/Pruebaestilo/images/nike2.jpg\" class=\"img-responsive\" alt>\r\n                        <div class=\"mask mask-1\"> </div>\r\n                        <div class=\"mask mask-2\"> </div>\r\n                        <div class=\"content\">\r\n                            <h2>TIENDA VIRTUAL</h2>\r\n                            <p>TIENDA VIRTUAL</p>\r\n                        </div>\r\n                    </a>\r\n                </div>\r\n                <h4 class=\"m_4\"><a href=\"#\">TIENDA VIRTUAL</a></h4>\r\n                <p class=\"m_5\">TIENDA VIRTUAL</p>\r\n            </div>\r\n            <div class=\"col-md-3 top_box1\">\r\n                <div class=\"view view-ninth\">\r\n                    <a href=\"single.html\">\r\n                        <img src=\"/Pruebaestilo/images/nike3.jpg\" class=\"img-responsive\" alt>\r\n                        <div class=\"mask mask-1\"> </div>\r\n                        <div class=\"mask mask-2\"> </div>\r\n                        <div class=\"content\">\r\n                            <h2>TIENDA VIRTUAL</h2>\r\n                            <p>TIENDA VIRTUAL</p>\r\n                        </div>\r\n                    </a>\r\n                </div>\r\n                <h4 class=\"m_4\"><a href=\"#\">TIENDA VIRTUAL</a></h4>\r\n                <p class=\"m_5\">TIENDA VIRTUAL</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
