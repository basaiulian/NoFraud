#pragma checksum "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\BankAccountsData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ae3774dc87bd82f81cf8057583ac700bdf56859"
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
#line 11 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\BankAccountsData.razor"
using BlazorPaymentManagementApp.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\BankAccountsData.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\BankAccountsData.razor"
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
            __builder.AddMarkupContent(0, "<h3 b-xav4jpzvug>Bank Accounts</h3>\n\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\BankAccountsData.razor"
                   ShowForm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "b-xav4jpzvug");
            __builder.AddContent(4, "Create Bank Account");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\n");
            __builder.OpenElement(6, "p");
            __builder.AddAttribute(7, "hidden", 
#nullable restore
#line 12 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\BankAccountsData.razor"
            IsShown

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(8, "b-xav4jpzvug");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(9);
            __builder.AddAttribute(10, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\BankAccountsData.razor"
                      bankAccount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 13 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\BankAccountsData.razor"
                                                  Create

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(13);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\n        <hr b-xav4jpzvug>\n\n        ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "form-group row");
                __builder2.AddAttribute(17, "b-xav4jpzvug");
                __builder2.AddMarkupContent(18, "<label for=\"balance\" class=\"col-sm-2 col-form-label\" b-xav4jpzvug>\n                Balance\n            </label>\n            ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "col-sm-10");
                __builder2.AddAttribute(21, "b-xav4jpzvug");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(22);
                __builder2.AddAttribute(23, "id", "balance");
                __builder2.AddAttribute(24, "class", "form-control");
                __builder2.AddAttribute(25, "placeholder", "Balance");
                __builder2.AddAttribute(26, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\BankAccountsData.razor"
                                                                                                BalanceToSend

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => BalanceToSend = __value, BalanceToSend))));
                __builder2.AddAttribute(28, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => BalanceToSend));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\n                ");
                __Blazor.BlazorPaymentManagementApp.Pages.BankAccountsData.TypeInference.CreateValidationMessage_0(__builder2, 30, 31, 
#nullable restore
#line 23 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\BankAccountsData.razor"
                                          () => BalanceToSend

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\n\n        ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "form-group row");
                __builder2.AddAttribute(35, "b-xav4jpzvug");
                __builder2.AddMarkupContent(36, "<label for=\"accountType\" class=\"col-sm-2 col-form-label\" b-xav4jpzvug>\n                Account Type\n            </label>\n            ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "col-sm-10");
                __builder2.AddAttribute(39, "b-xav4jpzvug");
                __Blazor.BlazorPaymentManagementApp.Pages.BankAccountsData.TypeInference.CreateInputSelect_1(__builder2, 40, 41, "accountType", 42, "form-control", 43, 
#nullable restore
#line 32 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\BankAccountsData.razor"
                                                                                AccountTypeToSend

#line default
#line hidden
#nullable disable
                , 44, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AccountTypeToSend = __value, AccountTypeToSend)), 45, () => AccountTypeToSend, 46, (__builder3) => {
                    __builder3.AddMarkupContent(47, "<option b-xav4jpzvug>STUDENT(Default)</option>");
#nullable restore
#line 34 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\BankAccountsData.razor"
                     foreach (var accountType in accountTypes)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(48, "option");
                    __builder3.AddAttribute(49, "b-xav4jpzvug");
                    __builder3.AddContent(50, 
#nullable restore
#line 36 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\BankAccountsData.razor"
                             accountType

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 37 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\BankAccountsData.razor"
                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(51, "\n                ");
                __Blazor.BlazorPaymentManagementApp.Pages.BankAccountsData.TypeInference.CreateValidationMessage_2(__builder2, 52, 53, 
#nullable restore
#line 39 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\BankAccountsData.razor"
                                          () => AccountTypeToSend

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\n\n        ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "form-group row");
                __builder2.AddAttribute(57, "b-xav4jpzvug");
                __builder2.AddMarkupContent(58, "<label for=\"userId\" class=\"col-sm-2 col-form-label\" b-xav4jpzvug>\n                User Id\n            </label>\n            ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "col-sm-10");
                __builder2.AddAttribute(61, "b-xav4jpzvug");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(62);
                __builder2.AddAttribute(63, "id", "userId");
                __builder2.AddAttribute(64, "class", "form-control");
                __builder2.AddAttribute(65, "placeholder", "User Id");
                __builder2.AddAttribute(66, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 48 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\BankAccountsData.razor"
                                                                                               UserIdToSend

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(67, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => UserIdToSend = __value, UserIdToSend))));
                __builder2.AddAttribute(68, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => UserIdToSend));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(69, "\n                ");
                __Blazor.BlazorPaymentManagementApp.Pages.BankAccountsData.TypeInference.CreateValidationMessage_3(__builder2, 70, 71, 
#nullable restore
#line 49 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\BankAccountsData.razor"
                                          () => UserIdToSend

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\n\n        <input type=\"submit\" value=\"Submit\" b-xav4jpzvug>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 57 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\BankAccountsData.razor"
 if (bankAccounts == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(73, "<p b-xav4jpzvug><em b-xav4jpzvug>Loading cards...</em></p>");
#nullable restore
#line 59 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\BankAccountsData.razor"
                                 }
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(74, "table");
            __builder.AddAttribute(75, "class", "table");
            __builder.AddAttribute(76, "b-xav4jpzvug");
            __builder.AddMarkupContent(77, "<thead b-xav4jpzvug><tr b-xav4jpzvug><th b-xav4jpzvug>Balance</th>\n            <th b-xav4jpzvug>Account Type</th>\n            <th b-xav4jpzvug>User Id</th></tr></thead>\n    ");
            __builder.OpenElement(78, "tbody");
            __builder.AddAttribute(79, "b-xav4jpzvug");
#nullable restore
#line 71 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\BankAccountsData.razor"
         foreach (var bankAccount in bankAccounts)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(80, "tr");
            __builder.AddAttribute(81, "b-xav4jpzvug");
            __builder.OpenElement(82, "td");
            __builder.AddAttribute(83, "b-xav4jpzvug");
            __builder.AddContent(84, 
#nullable restore
#line 74 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\BankAccountsData.razor"
         bankAccount.Balance

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\n    ");
            __builder.OpenElement(86, "td");
            __builder.AddAttribute(87, "b-xav4jpzvug");
            __builder.AddContent(88, 
#nullable restore
#line 75 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\BankAccountsData.razor"
         bankAccount.AccountType

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\n    ");
            __builder.OpenElement(90, "td");
            __builder.AddAttribute(91, "b-xav4jpzvug");
            __builder.AddContent(92, 
#nullable restore
#line 76 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\BankAccountsData.razor"
         bankAccount.UserId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 78 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\BankAccountsData.razor"
}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\n");
            __builder.OpenElement(94, "p");
            __builder.AddAttribute(95, "b-xav4jpzvug");
            __builder.AddContent(96, "Message: ");
            __builder.AddContent(97, 
#nullable restore
#line 81 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\BankAccountsData.razor"
             message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 81 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\BankAccountsData.razor"
                        }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 84 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\BankAccountsData.razor"
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

        await httpClient.PostAsJsonAsync<BankAccount>("/api/bankaccounts", bankAccount);
        bankAccounts = await httpClient.GetFromJsonAsync<List<BankAccount>>("/api/bankaccounts");
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
namespace __Blazor.BlazorPaymentManagementApp.Pages.BankAccountsData
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591