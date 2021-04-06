#pragma checksum "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\ProductoAdd.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8682fdff0020e038813a91a005ca72449aee6b01"
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
#line 2 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\ProductoAdd.razor"
using OnlineBlazorApp.Data.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\ProductoAdd.razor"
using OnlineBlazorApp.Data.Service;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/producto-add")]
    public partial class ProductoAdd : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\ProductoAdd.razor"
                  producto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\ProductoAdd.razor"
                                            ProductoInsert

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "form-group");
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.AddMarkupContent(8, "<label for=\"name\" class=\"form-label\">Nombre : </label>\r\n        ");
                __builder2.OpenElement(9, "input");
                __builder2.AddAttribute(10, "type", "text");
                __builder2.AddAttribute(11, "class", "form-control");
                __builder2.AddAttribute(12, "id", "name");
                __builder2.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\ProductoAdd.razor"
                                                                 producto.nombre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => producto.nombre = __value, producto.nombre));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n    ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "form-group");
                __builder2.AddMarkupContent(19, "\r\n        ");
                __builder2.AddMarkupContent(20, "<label for=\"cantidad\">Cantidad</label>\r\n        ");
                __builder2.OpenElement(21, "input");
                __builder2.AddAttribute(22, "type", "number");
                __builder2.AddAttribute(23, "class", "form-control");
                __builder2.AddAttribute(24, "id", "cantidad");
                __builder2.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\ProductoAdd.razor"
                                                                       producto.cantidad

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => producto.cantidad = __value, producto.cantidad, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n    ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "form-group");
                __builder2.AddMarkupContent(31, "\r\n        ");
                __builder2.AddMarkupContent(32, "<label for=\"categoria\" class=\"form-label\">Categoria : </label>\r\n        ");
                __builder2.OpenElement(33, "select");
                __builder2.AddAttribute(34, "name", "categoria");
                __builder2.AddAttribute(35, "id", "categoria");
                __builder2.AddAttribute(36, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\ProductoAdd.razor"
                                                       producto.fk_cod_categoria

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => producto.fk_cod_categoria = __value, producto.fk_cod_categoria));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(38, "\r\n");
#nullable restore
#line 22 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\ProductoAdd.razor"
             if (categorias != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\ProductoAdd.razor"
                 foreach (var categoria in categorias)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(39, "                    ");
                __builder2.OpenElement(40, "option");
                __builder2.AddAttribute(41, "value", 
#nullable restore
#line 26 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\ProductoAdd.razor"
                                    categoria.pk_cod_categoria

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(42, 
#nullable restore
#line 26 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\ProductoAdd.razor"
                                                                 categoria.nombre

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n");
#nullable restore
#line 27 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\ProductoAdd.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\ProductoAdd.razor"
                 
            }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(44, "\r\n\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n    ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "form-group");
                __builder2.AddMarkupContent(49, "\r\n        ");
                __builder2.AddMarkupContent(50, "<label for=\"descripcion\" class=\"form-label\">Descripcion : </label>\r\n        ");
                __builder2.OpenElement(51, "input");
                __builder2.AddAttribute(52, "type", "text");
                __builder2.AddAttribute(53, "class", "form-control");
                __builder2.AddAttribute(54, "id", "descripcion");
                __builder2.AddAttribute(55, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 36 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\ProductoAdd.razor"
                                                                        producto.descripcion

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(56, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => producto.descripcion = __value, producto.descripcion));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n    ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "form-group");
                __builder2.AddMarkupContent(61, "\r\n        ");
                __builder2.AddMarkupContent(62, "<label for=\"precio\">Precio</label>\r\n        ");
                __builder2.OpenElement(63, "input");
                __builder2.AddAttribute(64, "type", "number");
                __builder2.AddAttribute(65, "class", "form-control");
                __builder2.AddAttribute(66, "id", "precio");
                __builder2.AddAttribute(67, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 40 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\ProductoAdd.razor"
                                                                     producto.precio

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(68, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => producto.precio = __value, producto.precio, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n    ");
                __builder2.OpenElement(71, "div");
                __builder2.AddAttribute(72, "class", "form-group");
                __builder2.AddMarkupContent(73, "\r\n        ");
                __builder2.AddMarkupContent(74, "<label for=\"imagen\">Imagen</label>\r\n        ");
                __builder2.OpenComponent<BlazorInputFile.InputFile>(75);
                __builder2.AddAttribute(76, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 44 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\ProductoAdd.razor"
                             SeleccionarArchivo

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(77, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(78, "\r\n");
#nullable restore
#line 45 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\ProductoAdd.razor"
             if (file != null)
            {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(79, "                ");
                    __builder3.OpenElement(80, "p");
                    __builder3.AddContent(81, "Archivo cargado : ");
                    __builder3.AddContent(82, 
#nullable restore
#line 47 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\ProductoAdd.razor"
                                      file.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(83, "\r\n");
#nullable restore
#line 48 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\ProductoAdd.razor"
            }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(84, "        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(85, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\r\n    ");
                __builder2.AddMarkupContent(87, "<div class=\"mb-2\">\r\n        <input type=\"submit\" value=\"Registrar producto\" class=\"btn btn-warning btn-block\">\r\n    </div>\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Users\luish\source\repos\OnlineBlazorApp\Pages\ProductoAdd.razor"
       

    Producto producto = new Producto();
    IFileListEntry file;
    IEnumerable<Categoria> categorias;

    protected override async Task OnInitializedAsync()
    {
        categorias = await CategoriaService.GetAllCategorias();

    }

    protected async Task ProductoInsert()
    {
        await ProductoService.ProductoInsert(producto);
        NavigationManager.NavigateTo("/productos-list");
    }

    public bool verificarTipoImagen(String extension)
    {
        string[] typeImage = { ".png", ".jpg", ".jpeg", ".gif" };
        return typeImage.Contains(extension);
    }

    async Task SeleccionarArchivo(IFileListEntry[] files)
    {
        file = files.FirstOrDefault();
        if (file != null && verificarTipoImagen(Path.GetExtension(file.Name)))
        {
            producto.imagen = "/UploadImage/" + file.Name;
            await fileUpload.UploadAsync(file);
        }
    }
    async Task HandleFileSelected(IFileListEntry[] files)
    {
        file = files.FirstOrDefault();
        if (file != null)
        {
            await fileUpload.UploadAsync(file);
        }
    }

    void Cancel()
    {
        NavigationManager.NavigateTo("/");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileUpload fileUpload { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICategoriaService CategoriaService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductoService ProductoService { get; set; }
    }
}
#pragma warning restore 1591
