#pragma checksum "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\PaymentsData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec57216858c0371fbd186d1cc327170be56fba38"
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
#line 1 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using BlazorPaymentManagementApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using BlazorPaymentManagementApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\PaymentsData.razor"
using BlazorPaymentManagementApp.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\PaymentsData.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\PaymentsData.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/payments")]
    public partial class PaymentsData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Payments</h3>");
#nullable restore
#line 11 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\PaymentsData.razor"
 if (payments == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading payments...</em></p>");
#nullable restore
#line 13 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\PaymentsData.razor"
                                    }
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table");
            __builder.AddMarkupContent(4, "<thead><tr><th>Amount</th>\n            <th>Currency</th>\n            <th>Source</th>\n            <th>Destination</th></tr></thead>\n    ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 26 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\PaymentsData.razor"
         foreach (var payment in payments)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 29 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\PaymentsData.razor"
                 payment.Amount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\n            ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 30 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\PaymentsData.razor"
                 payment.Currency

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n            ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 31 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\PaymentsData.razor"
                 payment.Source

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\n            ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 32 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\PaymentsData.razor"
                 payment.Destination

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 33 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\PaymentsData.razor"
             }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n                ");
            __builder.OpenElement(19, "p");
            __builder.AddContent(20, "Message: ");
            __builder.AddContent(21, 
#nullable restore
#line 36 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\PaymentsData.razor"
                             message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 36 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\PaymentsData.razor"
                                        }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\PaymentsData.razor"
       private List<Payment> payments;

    string message = "---";

    private Payment payment = new Payment();

    HttpClient httpClient = new HttpClient()
    {
        BaseAddress = new Uri("http://localhost:5000")
    };

    protected override async Task OnInitializedAsync()
    {
        payments = await httpClient.GetFromJsonAsync<List<Payment>>("/api/v1/payments");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
