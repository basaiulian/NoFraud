// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#nullable restore
#line 3 "C:\Users\gabby\Documents\GitHub\NoFraud\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreateCard.razor"
using BlazorPaymentManagementApp.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/createcard")]
    public partial class CreateCard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "C:\Users\gabby\Documents\GitHub\NoFraud\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreateCard.razor"
       private Card card = new Card();

    HttpClient httpClient = new HttpClient()
    {
        BaseAddress = new Uri("http://localhost:5000")
    };

    protected async Task Create()
    {
        await httpClient.PostAsJsonAsync<Card>("/api/cards", card);
        NavManager.NavigateTo("users/" + card.OwnerId);

    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
#pragma warning restore 1591
