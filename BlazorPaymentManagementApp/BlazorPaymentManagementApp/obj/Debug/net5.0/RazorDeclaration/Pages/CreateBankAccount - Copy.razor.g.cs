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
#line 1 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using BlazorPaymentManagementApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using BlazorPaymentManagementApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreateBankAccount - Copy.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreateBankAccount - Copy.razor"
using BlazorPaymentManagementApp.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/createbankaccount")]
    public partial class CreateBankAccount___Copy : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreateBankAccount - Copy.razor"
      
    private BankAccount bankAccount = new BankAccount();

    private List<BankAccount> bankAccounts = new List<BankAccount>();

    private List<string> accountTypes = new List<string>();

    [Required]
    [RegularExpression(@"^[0-9]+[.][0-9]+|[0-9]+$", ErrorMessage = "Balance must be like \"40\" or \"40.5\".")]
    public string BalanceToSend { get; set; }

    [RegularExpression(@"^[0-9]{4}$", ErrorMessage = "User Id must be 4 digits long.")]
    [Required]
    public string UserIdToSend { get; set; }

    public string AccountTypeToSend { get; set; }
    HttpClient httpClient = new HttpClient()
    {
        BaseAddress = new Uri("http://localhost:5000")
    };

    protected async Task<string> GenerateId(int length)
    {
        string cypher = "123456789";

        var random = new Random();

        string generatedId = "";

        for (int i = 0; i < length; i++)
        {
            generatedId += cypher[random.Next(cypher.Length)];
        }

        return generatedId;
    }

    protected async Task Create()
    {
        bankAccount.Balance = Double.Parse(BalanceToSend);
        bankAccount.UserId = Int32.Parse(UserIdToSend);
        bankAccount.Id = await GenerateId(16);

        if (AccountTypeToSend == null)
        {
            bankAccount.AccountType = "STUDENT";
        }
        else
        {
            bankAccount.AccountType = AccountTypeToSend;
        }

        await httpClient.PostAsJsonAsync<BankAccount>("/api/bankaccounts", bankAccount);
    }

    protected override async Task OnInitializedAsync()
    {
        bankAccounts = await httpClient.GetFromJsonAsync<List<BankAccount>>("/api/bankaccounts");
        foreach (var bankAccount in bankAccounts)
        {
            if (!accountTypes.Contains(bankAccount.AccountType))
            {
                accountTypes.Add(bankAccount.AccountType);
            }
        }
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
