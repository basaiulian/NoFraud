// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorPaymentManagementApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Iulian\Documents\GitHub\NoFraud\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Iulian\Documents\GitHub\NoFraud\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Iulian\Documents\GitHub\NoFraud\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Iulian\Documents\GitHub\NoFraud\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Iulian\Documents\GitHub\NoFraud\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Iulian\Documents\GitHub\NoFraud\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Iulian\Documents\GitHub\NoFraud\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Iulian\Documents\GitHub\NoFraud\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Iulian\Documents\GitHub\NoFraud\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using BlazorPaymentManagementApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Iulian\Documents\GitHub\NoFraud\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using BlazorPaymentManagementApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Iulian\Documents\GitHub\NoFraud\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
    public partial class CardLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\Iulian\Documents\GitHub\NoFraud\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Shared\CardLayout.razor"
        private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    public bool IsLoggedIn { get; set; }
    public bool Id { get; set; }
    public string IdValue { get; set; }
    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

    protected async void logout()
    {
        await localStorage.RemoveItemAsync("autentificat");
        await localStorage.RemoveItemAsync("id");

        NavManager.NavigateTo("/");
    }

    protected async void GoToProfile()
    {
        NavManager.NavigateTo("users/" + this.IdValue);
    }

    protected async void GoToCreateCard()
    {
        NavManager.NavigateTo("/createcard");
    }

    protected async void GoToBankAccount()
    {
        NavManager.NavigateTo("/createbankaccount");
    }

    protected async void GoToPayment()
    {
        NavManager.NavigateTo("/createpayment");
    }


    protected override async Task OnInitializedAsync()
    {
        this.IdValue = await localStorage.GetItemAsStringAsync("id");
        this.IsLoggedIn = await localStorage.ContainKeyAsync("autentificat");
        this.Id = await localStorage.ContainKeyAsync("id");
        Console.WriteLine("autentificat:" + this.IsLoggedIn);

    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
    }
}
#pragma warning restore 1591
