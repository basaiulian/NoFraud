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
#line 2 "C:\Users\gabby\Documents\GitHub\NoFraud\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\Register.razor"
using BlazorPaymentManagementApp.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gabby\Documents\GitHub\NoFraud\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\Register.razor"
using System.Timers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "C:\Users\gabby\Documents\GitHub\NoFraud\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\Register.razor"
      

    private User user = new User();
    private string message = "";
    private string message2 = "";

    private static Timer aTimer;

    HttpClient httpClient = new HttpClient()
    {
        BaseAddress = new Uri("http://localhost:5000")
    };

    protected async Task RegisterUser()
    {

        HttpResponseMessage response = await httpClient.PostAsJsonAsync<User>("/api/v1/users", user);

        if (response.StatusCode.ToString() == "Created")
        {
            message = "";
            message2 = "";
            message2 += " Contul a fost creat cu succes ! ";
        }
        else
        {
            message = "";
            message += " Contul exista deja ! ";
        }

    }

    //protected override async Task OnInitializedAsync()
    //{
    //   // users = await httpClient.GetFromJsonAsync<List<User>>("/api/users");
    //}



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
#pragma warning restore 1591
