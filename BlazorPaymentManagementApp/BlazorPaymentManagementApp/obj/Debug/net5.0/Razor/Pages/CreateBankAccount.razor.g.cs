#pragma checksum "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreateBankAccount.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50df13333a4dab3eae60f089ab613ad430da37a6"
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
#line 3 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreateBankAccount.razor"
using System.Timers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreateBankAccount.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreateBankAccount.razor"
using BlazorPaymentManagementApp.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(CardLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/createbankaccount")]
    public partial class CreateBankAccount : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "register-photo");
            __builder.AddAttribute(2, "b-t4gj8982ag");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "form-container");
            __builder.AddAttribute(5, "b-t4gj8982ag");
            __builder.AddMarkupContent(6, "<div class=\"image-holder\" b-t4gj8982ag></div>\r\n        ");
            __builder.OpenElement(7, "form");
            __builder.AddAttribute(8, "method", "post");
            __builder.AddAttribute(9, "b-t4gj8982ag");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(10);
            __builder.AddAttribute(11, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 15 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreateBankAccount.razor"
                              bankAccount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 15 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreateBankAccount.razor"
                                                          Create

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(14);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n                ");
                __builder2.AddMarkupContent(16, "<h2 class=\"text-center\" b-t4gj8982ag><strong b-t4gj8982ag>Bank Account </strong></h2>\r\n                ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "form-group");
                __builder2.AddAttribute(19, "b-t4gj8982ag");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(20);
                __builder2.AddAttribute(21, "id", "balance");
                __builder2.AddAttribute(22, "class", "form-control");
                __builder2.AddAttribute(23, "placeholder", "Balance");
                __builder2.AddAttribute(24, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreateBankAccount.razor"
                                                                                                    BalanceToSend

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => BalanceToSend = __value, BalanceToSend))));
                __builder2.AddAttribute(26, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => BalanceToSend));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n                    ");
                __Blazor.BlazorPaymentManagementApp.Pages.CreateBankAccount.TypeInference.CreateValidationMessage_0(__builder2, 28, 29, 
#nullable restore
#line 20 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreateBankAccount.razor"
                                              () => BalanceToSend

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "form-group");
                __builder2.AddAttribute(33, "b-t4gj8982ag");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(34);
                __builder2.AddAttribute(35, "id", "name");
                __builder2.AddAttribute(36, "class", "form-control");
                __builder2.AddAttribute(37, "placeholder", "Name");
                __builder2.AddAttribute(38, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreateBankAccount.razor"
                                                                                              bankAccount.BankName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => bankAccount.BankName = __value, bankAccount.BankName))));
                __builder2.AddAttribute(40, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => bankAccount.BankName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(41, "\r\n                    ");
                __Blazor.BlazorPaymentManagementApp.Pages.CreateBankAccount.TypeInference.CreateValidationMessage_1(__builder2, 42, 43, 
#nullable restore
#line 24 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreateBankAccount.razor"
                                              () => bankAccount.BankName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n                ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "form-group");
                __builder2.AddAttribute(47, "b-t4gj8982ag");
                __Blazor.BlazorPaymentManagementApp.Pages.CreateBankAccount.TypeInference.CreateInputSelect_2(__builder2, 48, 49, "accountType", 50, "form-control", 51, 
#nullable restore
#line 27 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreateBankAccount.razor"
                                                                                    AccountTypeToSend

#line default
#line hidden
#nullable disable
                , 52, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AccountTypeToSend = __value, AccountTypeToSend)), 53, () => AccountTypeToSend, 54, (__builder3) => {
                    __builder3.AddMarkupContent(55, "<option b-t4gj8982ag>Student(Default)</option>");
#nullable restore
#line 29 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreateBankAccount.razor"
                         foreach (var accountType in accountTypes)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreateBankAccount.razor"
                             if (accountType != "Student")
                            {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(56, "option");
                    __builder3.AddAttribute(57, "b-t4gj8982ag");
                    __builder3.AddContent(58, 
#nullable restore
#line 33 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreateBankAccount.razor"
                                         accountType

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 34 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreateBankAccount.razor"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreateBankAccount.razor"
                             
                        }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(59, "\r\n                    ");
                __Blazor.BlazorPaymentManagementApp.Pages.CreateBankAccount.TypeInference.CreateValidationMessage_3(__builder2, 60, 61, 
#nullable restore
#line 37 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreateBankAccount.razor"
                                              () => bankAccount.AccountType

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n                ");
                __builder2.AddMarkupContent(63, "<div class=\"form-group\" b-t4gj8982ag><input class=\"btn btn-success btn-block\" type=\"submit\" value=\"Submit\" b-t4gj8982ag></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n    ");
            __builder.OpenElement(65, "h3");
            __builder.AddAttribute(66, "b-t4gj8982ag");
            __builder.AddContent(67, 
#nullable restore
#line 45 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreateBankAccount.razor"
         goodMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n    ");
            __builder.OpenElement(69, "h4");
            __builder.AddAttribute(70, "b-t4gj8982ag");
            __builder.AddContent(71, 
#nullable restore
#line 46 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreateBankAccount.razor"
         badNessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreateBankAccount.razor"
       private BankAccount bankAccount = new BankAccount();

    private List<BankAccount> bankAccounts = new List<BankAccount>();

    private List<string> accountTypes = new List<string>();

    private static Timer aTimer;
    private string goodMessage = "";
    private string badNessage = "";

    [Required(AllowEmptyStrings = false, ErrorMessage = "The Balance field is required.")]
    [RegularExpression(@"^[0-9]+[.][0-9]+|[0-9]+$", ErrorMessage = "Balance must be like \"40\" or \"40.5\".")]
    public string BalanceToSend { get; set; }

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
        var id = await localStorage.GetItemAsync<string>("id");
        bankAccount.UserId = Int32.Parse(id);
        bankAccount.Id = await GenerateId(16);

        if (AccountTypeToSend == null)
        {
            bankAccount.AccountType = "Student";
        }
        else
        {
            bankAccount.AccountType = AccountTypeToSend;
        }

        HttpResponseMessage response = await httpClient.PostAsJsonAsync<BankAccount>("/api/v1/bankaccounts", bankAccount);

        if (response.StatusCode.ToString() == "Created")
        {
            goodMessage = "";
            badNessage = "";
            badNessage += "Bank account added successfully, you will be redirected to your profile in 3 seconds...";

            aTimer = new Timer();
            aTimer.Interval = 3000;
            aTimer.Elapsed += (sender, args) =>
            {
                NavManager.NavigateTo("users/" + bankAccount.UserId,true);
            };

            aTimer.AutoReset = true;
            aTimer.Enabled = true;

        }
        else
        {
            goodMessage = "";
            goodMessage += "Something is wrong, try again! ";
        }
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
namespace __Blazor.BlazorPaymentManagementApp.Pages.CreateBankAccount
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
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
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
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
