#pragma checksum "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Devoluciones.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b1f92433caf57385999e49e97c67a55b6c2f189"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/devoluciones")]
    public partial class Devoluciones : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"main\">\r\n    <div class=\"shop_top\">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-7\">\r\n                    <div class=\"map\">\r\n                        <iframe src=\"https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d254900.13121119505!2d-76.66575259467078!3d3.3953970272403415!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x8e30a6f0cc4bb3f1%3A0x1f0fb5e952ae6168!2sCali%2C%20Valle%20del%20Cauca!5e0!3m2!1ses!2sco!4v1616599099069!5m2!1ses!2sco\" width=\"600\" height=\"450\" frameborder=\"0\" allowfullscreen loading=\"lazy\" style=\"color:#666;text-align:left;font-size:12px\"></iframe><br>\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-md-5\">\r\n                    <p class=\"m_8\">Nike, Inc.​ es una empresa multinacional estadounidense dedicada al diseño, desarrollo, fabricación y comercialización de equipamiento deportivo: balones, calzado, ropa, equipo, accesorios y otros artículos deportivos.</p>\r\n                    <div class=\"address\">\r\n                        <p>Cali,</p>\r\n                        <p>USC</p>\r\n                        <p>Colombia</p>\r\n                        <p>Celular:(57) 314 456 476</p>\r\n                        <p>Fax: (000) 000 00 00 0</p>\r\n                        <p>Correo: <span>nike@nike.com</span></p>\r\n                        <p>Follow on: <span>Facebook</span>, <span>Twitter</span></p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12 contact\">\r\n                    <form method=\"post\" action=\"contact-post.html\">\r\n                        <div class=\"to\">\r\n                            <input type=\"text\" class=\"text\" value=\"Nombre\" onfocus=\"this.value = \'\';\" onblur=\"if (this.value == \'\') {this.value = \'Name\';}\">\r\n                            <input type=\"text\" class=\"text\" value=\"Correo\" onfocus=\"this.value = \'\';\" onblur=\"if (this.value == \'\') {this.value = \'Email\';}\">\r\n                            <input type=\"text\" class=\"text\" value=\"Dato extra\" onfocus=\"this.value = \'\';\" onblur=\"if (this.value == \'\') {this.value = \'Subject\';}\">\r\n                        </div>\r\n                        <div class=\"text\">\r\n                            <textarea value=\"Message:\" onfocus=\"this.value = \'\';\" onblur=\"if (this.value == \'\') {this.value = \'Message\';}\">Mensaje:</textarea>\r\n                            <div class=\"form-submit\">\r\n                                <input name=\"submit\" type=\"submit\" id=\"submit\" value=\"Enviar\"><br>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"clear\"></div>\r\n                    </form>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
