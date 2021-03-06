#pragma checksum "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\UsuariosList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d181b456eb23ab0b909a1b828af4925593f16cde"
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
#line 2 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\UsuariosList.razor"
using OnlineBlazorApp.Data.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\UsuariosList.razor"
using OnlineBlazorApp.Data.Service;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/lista")]
    public partial class UsuariosList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Lista de usuarios</h3>\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<thead>\r\n        <tr>\r\n            <th>Nombre</th>\r\n            <th>Email</th>\r\n            <th>Direccion</th>\r\n            <th>telefono</th>\r\n            <th colspan=\"2\">Accion</th>\r\n        </tr>\r\n    </thead>\r\n");
            __builder.OpenElement(5, "tbody");
            __builder.AddMarkupContent(6, "\r\n");
#nullable restore
#line 20 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\UsuariosList.razor"
     if(usuarios!=null) { 
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\UsuariosList.razor"
         foreach(var usuario in usuarios)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "    ");
            __builder.OpenElement(8, "tr");
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 24 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\UsuariosList.razor"
             usuario.nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 25 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\UsuariosList.razor"
             usuario.email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 26 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\UsuariosList.razor"
             usuario.direccion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 27 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\UsuariosList.razor"
             usuario.telefono

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.AddMarkupContent(22, "<td>\r\n            <button type=\"button\" class=\"btn btn-default\" aria-label=\"Left Align\" title=\"editar\">\r\n                <span class=\"oi oi-pencil\" aria-hidden=\"true\"></span>\r\n            </button>\r\n        </td>\r\n        ");
            __builder.AddMarkupContent(23, "<td>\r\n            <button type=\"button\" class=\"btn btn-default\" aria-label=\"Left Align\" title=\"eliminar\">\r\n                <span class=\"oi oi-trash\" aria-hidden=\"true\"></span>\r\n            </button>\r\n        </td>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
#nullable restore
#line 39 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\UsuariosList.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\UsuariosList.razor"
                 
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\UsuariosList.razor"
       

    IEnumerable<Usuario> usuarios;

    protected override async Task OnInitializedAsync()
    {
        usuarios = await UsuarioService.GetAllClientes();
    }

    void editarRegistro(int id)
    {
        NavigationManager.NavigateTo("/");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUsuarioService UsuarioService { get; set; }
    }
}
#pragma warning restore 1591
