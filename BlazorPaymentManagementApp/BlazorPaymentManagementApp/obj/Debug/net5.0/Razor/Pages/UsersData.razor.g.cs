#pragma checksum "C:\Users\Iulian\source\repos\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\UsersData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81ccc8b2e4a9db4471225b2cdf6f5d10f42f2e05"
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
#line 1 "C:\Users\Iulian\source\repos\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Iulian\source\repos\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Iulian\source\repos\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Iulian\source\repos\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Iulian\source\repos\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Iulian\source\repos\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Iulian\source\repos\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Iulian\source\repos\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Iulian\source\repos\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using BlazorPaymentManagementApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Iulian\source\repos\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using BlazorPaymentManagementApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/usersdata")]
    public partial class UsersData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>UsersData</h3>");
#nullable restore
#line 5 "C:\Users\Iulian\source\repos\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\UsersData.razor"
 if (users == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading users...</em></p>");
#nullable restore
#line 8 "C:\Users\Iulian\source\repos\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\UsersData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "<thead><tr><th>Id</th>\r\n            <th>Username</th>\r\n            <th>Email</th>\r\n            <th>Phone Number</th>\r\n            <th>Address</th></tr></thead>\r\n    ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 22 "C:\Users\Iulian\source\repos\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\UsersData.razor"
         foreach (var user in users)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 25 "C:\Users\Iulian\source\repos\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\UsersData.razor"
                 user.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 26 "C:\Users\Iulian\source\repos\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\UsersData.razor"
                 user.Username

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 27 "C:\Users\Iulian\source\repos\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\UsersData.razor"
                 user.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 28 "C:\Users\Iulian\source\repos\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\UsersData.razor"
                 user.PhoneNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 29 "C:\Users\Iulian\source\repos\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\UsersData.razor"
                 user.Address

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 31 "C:\Users\Iulian\source\repos\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\UsersData.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 34 "C:\Users\Iulian\source\repos\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\UsersData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\Iulian\source\repos\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\UsersData.razor"
      
    private List<User> users;

    HttpClient httpClient = new HttpClient()
    {
        BaseAddress = new Uri("http://localhost:5000")
    };

    protected override async Task OnInitializedAsync()
    {
        users = await httpClient.GetFromJsonAsync<List<User>>("/api/users");
    }

    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Address {get; set; }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
