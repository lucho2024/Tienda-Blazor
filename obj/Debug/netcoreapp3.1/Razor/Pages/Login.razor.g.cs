#pragma checksum "C:\Users\User\OneDrive\Escritorio\proyecto_tienda\Tienda-Blazor\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1fd840ea0e3b21f42f530934f38f790669a2bec4"
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
#line 1 "C:\Users\User\OneDrive\Escritorio\proyecto_tienda\Tienda-Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\OneDrive\Escritorio\proyecto_tienda\Tienda-Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\OneDrive\Escritorio\proyecto_tienda\Tienda-Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\OneDrive\Escritorio\proyecto_tienda\Tienda-Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\OneDrive\Escritorio\proyecto_tienda\Tienda-Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\OneDrive\Escritorio\proyecto_tienda\Tienda-Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\OneDrive\Escritorio\proyecto_tienda\Tienda-Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\OneDrive\Escritorio\proyecto_tienda\Tienda-Blazor\_Imports.razor"
using OnlineBlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\OneDrive\Escritorio\proyecto_tienda\Tienda-Blazor\_Imports.razor"
using OnlineBlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\OneDrive\Escritorio\proyecto_tienda\Tienda-Blazor\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\User\OneDrive\Escritorio\proyecto_tienda\Tienda-Blazor\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\OneDrive\Escritorio\proyecto_tienda\Tienda-Blazor\Pages\Login.razor"
using OnlineBlazorApp.Data.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\OneDrive\Escritorio\proyecto_tienda\Tienda-Blazor\Pages\Login.razor"
using OnlineBlazorApp.Data.Service;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "C:\Users\User\OneDrive\Escritorio\proyecto_tienda\Tienda-Blazor\Pages\Login.razor"
                  usuario

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "C:\Users\User\OneDrive\Escritorio\proyecto_tienda\Tienda-Blazor\Pages\Login.razor"
                                           UsuarioInsert

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "c-register");
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "c-form");
                __builder2.AddMarkupContent(10, "\r\n            ");
                __builder2.AddMarkupContent(11, "<h1>Login</h1>\r\n            ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "mb-2");
                __builder2.AddMarkupContent(14, "\r\n                ");
                __builder2.AddMarkupContent(15, "<label for=\"email\" class=\"form-label\">Correo electronico : </label>\r\n                ");
                __builder2.OpenElement(16, "input");
                __builder2.AddAttribute(17, "type", "text");
                __builder2.AddAttribute(18, "class", "form-control");
                __builder2.AddAttribute(19, "id", "email");
                __builder2.AddAttribute(20, "required", true);
                __builder2.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\User\OneDrive\Escritorio\proyecto_tienda\Tienda-Blazor\Pages\Login.razor"
                                                                          usuario.email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => usuario.email = __value, usuario.email));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n            ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "mb-2");
                __builder2.AddMarkupContent(27, "\r\n                ");
                __builder2.AddMarkupContent(28, "<label for=\"pass\" class=\"form-label\">Contraseña :</label>\r\n                ");
                __builder2.OpenElement(29, "input");
                __builder2.AddAttribute(30, "type", "password");
                __builder2.AddAttribute(31, "class", "form-control");
                __builder2.AddAttribute(32, "id", "pass");
                __builder2.AddAttribute(33, "required", true);
                __builder2.AddAttribute(34, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\User\OneDrive\Escritorio\proyecto_tienda\Tienda-Blazor\Pages\Login.razor"
                                                                             usuario.pass

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => usuario.pass = __value, usuario.pass));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n\r\n            ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "mb-2");
                __builder2.AddMarkupContent(40, "\r\n                <input type=\"submit\" value=\"Login\" class=\"btn btn-success btn-block\">\r\n                ");
                __builder2.OpenElement(41, "input");
                __builder2.AddAttribute(42, "type", "button");
                __builder2.AddAttribute(43, "value", "Cancelar");
                __builder2.AddAttribute(44, "class", "btn btn-primary btn-block");
                __builder2.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\User\OneDrive\Escritorio\proyecto_tienda\Tienda-Blazor\Pages\Login.razor"
                                                                                                   Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n\r\n\r\n\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "C:\Users\User\OneDrive\Escritorio\proyecto_tienda\Tienda-Blazor\Pages\Login.razor"
       
    Usuario usuario = new Usuario();
    protected async Task UsuarioInsert()
    {
        await UsuarioService.UsuarioInsert(usuario);
        NavigationManager.NavigateTo("/login");
    }

    void Cancel()
    {
        NavigationManager.NavigateTo("/");
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\User\OneDrive\Escritorio\proyecto_tienda\Tienda-Blazor\Pages\Login.razor"
        IEnumerable<Usuario> usuarios;

            protected override async Task OnInitializedAsync()
            {
                usuarios = await UsuarioService.GetAllClientes();
            }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUsuarioService UsuarioService { get; set; }
    }
}
#pragma warning restore 1591
