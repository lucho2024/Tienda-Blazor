#pragma checksum "C:\Users\User\OneDrive\Escritorio\Proyecto tienda\Tienda-Blazor\Shared\Footer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31941a413890bf6dc8f00f367922c59ca9cdba63"
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
#line 1 "C:\Users\User\OneDrive\Escritorio\Proyecto tienda\Tienda-Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\OneDrive\Escritorio\Proyecto tienda\Tienda-Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\OneDrive\Escritorio\Proyecto tienda\Tienda-Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\OneDrive\Escritorio\Proyecto tienda\Tienda-Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\OneDrive\Escritorio\Proyecto tienda\Tienda-Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\OneDrive\Escritorio\Proyecto tienda\Tienda-Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\OneDrive\Escritorio\Proyecto tienda\Tienda-Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\OneDrive\Escritorio\Proyecto tienda\Tienda-Blazor\_Imports.razor"
using OnlineBlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\OneDrive\Escritorio\Proyecto tienda\Tienda-Blazor\_Imports.razor"
using OnlineBlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\OneDrive\Escritorio\Proyecto tienda\Tienda-Blazor\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\User\OneDrive\Escritorio\Proyecto tienda\Tienda-Blazor\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
    public partial class Footer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"footer\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-3\">\r\n                <ul class=\"footer_box\">\r\n                    <h4>Productos</h4>\r\n                    <li><a href=\"#\">Hombre</a></li>\r\n                    <li><a href=\"#\">Mujer</a></li>\r\n                    <li><a href=\"#\">Niños</a></li>\r\n                </ul>\r\n            </div>\r\n            <div class=\"col-md-3\">\r\n                <ul class=\"footer_box\">\r\n                    <h4>Tienda</h4>\r\n                    <li><a href=\"#\">-</a></li>\r\n                    <li><a href=\"#\">-</a></li>\r\n                    <li><a href=\"#\">-</a></li>\r\n                    <li><a href=\"#\">-</a></li>\r\n                </ul>\r\n            </div>\r\n            <div class=\"col-md-3\">\r\n                <ul class=\"footer_box\">\r\n                    <h4>Contactenos</h4>\r\n                    <li><a href=\"#\">Devoluciones</a></li>\r\n                    <li><a href=\"#\">-</a></li>\r\n                    <li><a href=\"#\">-</a></li>\r\n                    <li><a href=\"#\">-</a></li>\r\n                    <li><a href=\"#\">-</a></li>\r\n                </ul>\r\n            </div>\r\n            <div class=\"col-md-3\">\r\n                <ul class=\"footer_box\">\r\n                    <h4>Boletin de informacion</h4>\r\n                    <div class=\"footer_search\">\r\n                        <form>\r\n                            <input type=\"text\" value=\"Ingresa tu correo\" onfocus=\"this.value = \'\';\" onblur=\"if (this.value == \'\') {this.value = \'Ingresa tu correo\';}\">\r\n                            <input type=\"submit\" value=\"Registrar\">\r\n                        </form>\r\n                    </div>\r\n                    <ul class=\"social\">\r\n                        <li class=\"facebook\"><a href=\"#\"><span> </span></a></li>\r\n                        <li class=\"twitter\"><a href=\"#\"><span> </span></a></li>\r\n                        <li class=\"instagram\"><a href=\"#\"><span> </span></a></li>\r\n                        <li class=\"pinterest\"><a href=\"#\"><span> </span></a></li>\r\n                        <li class=\"youtube\"><a href=\"#\"><span> </span></a></li>\r\n                    </ul>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n\r\n        <dl id=\"sample\" class=\"dropdown\">\r\n            <dt><a href=\"#\"><span>Cambiar de Region</span></a></dt>\r\n            <dd>\r\n                <ul>\r\n                    <li><a href=\"#\">Australia<img class=\"flag\" src=\"/Estilo/images/as.png\" alt><span class=\"value\">AS</span></a></li>\r\n                    <li><a href=\"#\">Sri Lanka<img class=\"flag\" src=\"/Estilo/images/srl.png\" alt><span class=\"value\">SL</span></a></li>\r\n                    <li><a href=\"#\">Newziland<img class=\"flag\" src=\"/Estilo/images/nz.png\" alt><span class=\"value\">NZ</span></a></li>\r\n                    <li><a href=\"#\">Pakistan<img class=\"flag\" src=\"/Estilo/images/pk.png\" alt><span class=\"value\">Pk</span></a></li>\r\n                    <li><a href=\"#\">United Kingdom<img class=\"flag\" src=\"/Estilo/images/uk.png\" alt><span class=\"value\">UK</span></a></li>\r\n                    <li><a href=\"#\">United States<img class=\"flag\" src=\"/Estilo/images/us.png\" alt><span class=\"value\">US</span></a></li>\r\n                </ul>\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
