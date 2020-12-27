#pragma checksum "C:\Users\gabby\Documents\GitHub\NoFraud\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1914fe0efe7ae8615e347e20c0fbff117ce696dd"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorPaymentManagementApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\gabby\Documents\GitHub\NoFraud\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gabby\Documents\GitHub\NoFraud\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gabby\Documents\GitHub\NoFraud\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gabby\Documents\GitHub\NoFraud\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gabby\Documents\GitHub\NoFraud\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\gabby\Documents\GitHub\NoFraud\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\gabby\Documents\GitHub\NoFraud\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\gabby\Documents\GitHub\NoFraud\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\gabby\Documents\GitHub\NoFraud\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using BlazorPaymentManagementApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\gabby\Documents\GitHub\NoFraud\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using BlazorPaymentManagementApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\gabby\Documents\GitHub\NoFraud\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"title\" b-jvtcrqogn1>Welcome to Nofraud</div>\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "buttons");
            __builder.AddAttribute(3, "b-jvtcrqogn1");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "id", "login");
            __builder.AddAttribute(6, "type", "button");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\gabby\Documents\GitHub\NoFraud\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\Index.razor"
                                               GoToLogin

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "b-jvtcrqogn1");
            __builder.AddContent(9, "Login");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n    ");
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "id", "register");
            __builder.AddAttribute(13, "type", "button");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\gabby\Documents\GitHub\NoFraud\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\Index.razor"
                                                  GoToRegister

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "b-jvtcrqogn1");
            __builder.AddContent(16, "Register");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\gabby\Documents\GitHub\NoFraud\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\Index.razor"
       protected bool IsLoggedIn { get; set; }
    protected string Id { get; set; }

    protected override async Task OnInitializedAsync()
    {
        this.IsLoggedIn = await localStorage.ContainKeyAsync("autentificat");
        this.Id = await localStorage.GetItemAsStringAsync("id");

        if (this.IsLoggedIn == true)
        {
            NavManager.NavigateTo("/users/" + Id, true);
        }



    }
    protected async void GoToLogin()
    {
        NavManager.NavigateTo("/login");
    }

    protected async void GoToRegister()
    {
        NavManager.NavigateTo("/register");
    }

    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
    }
}
#pragma warning restore 1591
