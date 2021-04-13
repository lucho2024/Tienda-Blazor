#pragma checksum "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Productos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "484b96ceb6a49c0764819f915a80df2132e8175d"
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
#line 3 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Productos.razor"
using OnlineBlazorApp.Data.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Productos.razor"
using OnlineBlazorApp.Data.Service;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/productos-list")]
    public partial class Productos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Lista de Productos</h3>\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, @"<thead>
        <tr>
            <th>PK</th>
            <th>Nombre</th>
            <th>Cantidad</th>
            <th>Descripcion</th>
            <th>precio</th>
            <th>Imagen</th>
            <th colspan=""2"">Accion</th>
        </tr>
    </thead>
    ");
            __builder.OpenElement(5, "tbody");
            __builder.AddMarkupContent(6, "\r\n");
#nullable restore
#line 23 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Productos.razor"
         if (productos != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Productos.razor"
             foreach (var producto in productos)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "        ");
            __builder.OpenElement(8, "tr");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 28 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Productos.razor"
                 producto.pk_cod_producto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 29 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Productos.razor"
                 producto.nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 30 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Productos.razor"
                 producto.cantidad

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 31 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Productos.razor"
                 producto.descripcion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 32 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Productos.razor"
                 producto.precio

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.OpenElement(25, "td");
            __builder.AddMarkupContent(26, "\r\n");
#nullable restore
#line 34 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Productos.razor"
                 if (@producto.imagen != null)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "            ");
            __builder.OpenElement(28, "img");
            __builder.AddAttribute(29, "src", 
#nullable restore
#line 36 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Productos.razor"
                       producto.imagen

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(30, "asp-append-version", "true");
            __builder.AddAttribute(31, "style", "width:100px;height:100px;");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
#nullable restore
#line 37 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Productos.razor"
            }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(33, "            <img src alt class=\"img-thumbnail\">\r\n");
#nullable restore
#line 41 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Productos.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(34, "                \r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n            ");
            __builder.OpenElement(36, "td");
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.OpenElement(38, "button");
            __builder.AddAttribute(39, "type", "button");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Productos.razor"
                                  () => editarRegistro(producto.pk_cod_producto)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "class", "btn btn-default");
            __builder.AddAttribute(42, "aria-label", "Left Align");
            __builder.AddAttribute(43, "title", "editar");
            __builder.AddMarkupContent(44, "\r\n                    <span class=\"oi oi-pencil\" aria-hidden=\"true\"></span>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n            ");
            __builder.OpenElement(47, "td");
            __builder.AddMarkupContent(48, "\r\n                ");
            __builder.OpenElement(49, "button");
            __builder.AddAttribute(50, "type", "button");
            __builder.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Productos.razor"
                                  () => eliminarRegistro(producto.pk_cod_producto)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "class", "btn btn-default");
            __builder.AddAttribute(53, "aria-label", "Left Align");
            __builder.AddAttribute(54, "title", "eliminar");
            __builder.AddMarkupContent(55, "\r\n                    <span class=\"oi oi-trash\" aria-hidden=\"true\"></span>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n");
#nullable restore
#line 61 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Productos.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Productos.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(59, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\Productos.razor"
       

    IEnumerable<Producto> productos;

    protected override async Task OnInitializedAsync()
    {
        productos = await ProductoService.GetAllProductos();

    }

    void editarRegistro(int id)
    {

        NavigationManager.NavigateTo("/ActualizarP/" + id);
    }

    async void eliminarRegistro(int id)
    {
        await ProductoService.deleteIdproducto(id);
        NavigationManager.NavigateTo("/productos-list");

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductoService ProductoService { get; set; }
    }
}
#pragma warning restore 1591
