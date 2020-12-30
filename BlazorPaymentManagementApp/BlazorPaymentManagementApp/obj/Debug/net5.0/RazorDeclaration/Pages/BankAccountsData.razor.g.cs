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
#line 1 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune1.30-29.12.2020-cubaietii\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune1.30-29.12.2020-cubaietii\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune1.30-29.12.2020-cubaietii\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune1.30-29.12.2020-cubaietii\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune1.30-29.12.2020-cubaietii\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune1.30-29.12.2020-cubaietii\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune1.30-29.12.2020-cubaietii\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune1.30-29.12.2020-cubaietii\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune1.30-29.12.2020-cubaietii\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using BlazorPaymentManagementApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune1.30-29.12.2020-cubaietii\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using BlazorPaymentManagementApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune1.30-29.12.2020-cubaietii\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune1.30-29.12.2020-cubaietii\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\BankAccountsData.razor"
using BlazorPaymentManagementApp.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune1.30-29.12.2020-cubaietii\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\BankAccountsData.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune1.30-29.12.2020-cubaietii\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\BankAccountsData.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/bankaccounts")]
    public partial class BankAccountsData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 84 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune1.30-29.12.2020-cubaietii\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\BankAccountsData.razor"
       private List<BankAccount> bankAccounts;

    string message = "---";

    private BankAccount bankAccount = new BankAccount();

    private List<string> accountTypes = new List<string>();

    [Required]
    [RegularExpression(@"^[0-9]+[.][0-9]+|[0-9]+$", ErrorMessage = "Balance must be like \"40\" or \"40.5\".")]
    public string BalanceToSend { get; set; }

    [RegularExpression(@"^[0-9]{16}$", ErrorMessage ="User Id must be 16 digits long.")]
    [Required]
    public string UserIdToSend { get; set; }

    public string AccountTypeToSend { get; set; }

    private bool IsShown { get; set; } = true;

    HttpClient httpClient = new HttpClient()
    {
        BaseAddress = new Uri("http://localhost:5000")
    };

    private void ShowForm()
    {
        IsShown = !IsShown;
    }

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

        if(AccountTypeToSend == null)
        {
            bankAccount.AccountType = "STUDENT";
        } else
        {
            bankAccount.AccountType = AccountTypeToSend;
        }

        message = JsonSerializer.Serialize(bankAccount);

        await httpClient.PostAsJsonAsync<BankAccount>("/api/v1/bankaccounts", bankAccount);
        bankAccounts = await httpClient.GetFromJsonAsync<List<BankAccount>>("/api/v1/bankaccounts");
    }

    protected override async Task OnInitializedAsync()
    {
        bankAccounts = await httpClient.GetFromJsonAsync<List<BankAccount>>("/api/v1/bankaccounts");
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
