#pragma checksum "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\UsersData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3d326e8e5bb4d5aed13bb7b0cd5cbdeb1de8a7c"
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
#line 1 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using BlazorPaymentManagementApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using BlazorPaymentManagementApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/usersdata")]
    public partial class UsersData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>UsersData</h3>\n");
            __builder.OpenElement(1, "form");
            __builder.AddAttribute(2, "action", "/user/" + (
#nullable restore
#line 4 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\UsersData.razor"
                     IdToFind

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 5 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\UsersData.razor"
                   IdToFind

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => IdToFind = __value, IdToFind));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\n    <input type=\"submit\" value=\"Search\">");
            __builder.CloseElement();
#nullable restore
#line 9 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\UsersData.razor"
 if (users == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<p><em>Loading users...</em></p>");
#nullable restore
#line 12 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\UsersData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "table");
            __builder.AddAttribute(9, "class", "table");
            __builder.AddMarkupContent(10, "<thead><tr><th>Id</th>\n                <th>Username</th>\n                <th>Email</th>\n                <th>Phone Number</th>\n                <th>Address</th></tr></thead>\n        ");
            __builder.OpenElement(11, "tbody");
#nullable restore
#line 26 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\UsersData.razor"
             foreach (var user in users)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "tr");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 29 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\UsersData.razor"
                         user.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 30 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\UsersData.razor"
                         user.Username

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 31 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\UsersData.razor"
                         user.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\n                    ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 32 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\UsersData.razor"
                         user.PhoneNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n                    ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 33 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\UsersData.razor"
                         user.Address

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 35 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\UsersData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 38 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\UsersData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\UsersData.razor"
      
    private List<User> users;

    public int IdToFind { get; set; }

    HttpClient httpClient = new HttpClient()
    {
        BaseAddress = new Uri("http://localhost:5000")
    };

    protected override async Task OnInitializedAsync()
    {
        users = await httpClient.GetFromJsonAsync<List<User>>("/api/v1/users");
    }

    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
