#pragma checksum "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreatePayment.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b0efd5280e37d562aea5a12ab788d796c21b8cd"
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
#nullable restore
#line 4 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreatePayment.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreatePayment.razor"
using BlazorPaymentManagementApp.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(CardLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/createpayment")]
    public partial class CreatePayment : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "register-photo");
            __builder.AddAttribute(2, "b-1qhdc9h047");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "form-container");
            __builder.AddAttribute(5, "b-1qhdc9h047");
            __builder.AddMarkupContent(6, "<div class=\"image-holder\" b-1qhdc9h047></div>\n        ");
            __builder.OpenElement(7, "form");
            __builder.AddAttribute(8, "method", "post");
            __builder.AddAttribute(9, "b-1qhdc9h047");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(10);
            __builder.AddAttribute(11, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 17 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreatePayment.razor"
                              payment

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 17 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreatePayment.razor"
                                                      Create

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(14);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\n\n                ");
                __builder2.AddMarkupContent(16, "<h2 class=\"text-center\" b-1qhdc9h047><strong b-1qhdc9h047>Payment </strong></h2>\n\n\n                ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "form-group");
                __builder2.AddAttribute(19, "b-1qhdc9h047");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(20);
                __builder2.AddAttribute(21, "id", "amount");
                __builder2.AddAttribute(22, "class", "form-control");
                __builder2.AddAttribute(23, "placeholder", "Amount");
                __builder2.AddAttribute(24, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreatePayment.razor"
                                                                                                  AmountToSend

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AmountToSend = __value, AmountToSend))));
                __builder2.AddAttribute(26, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => AmountToSend));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\n                    ");
                __Blazor.BlazorPaymentManagementApp.Pages.CreatePayment.TypeInference.CreateValidationMessage_0(__builder2, 28, 29, 
#nullable restore
#line 25 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreatePayment.razor"
                                              () => payment.Amount

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\n                ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "form-group");
                __builder2.AddAttribute(33, "b-1qhdc9h047");
                __Blazor.BlazorPaymentManagementApp.Pages.CreatePayment.TypeInference.CreateInputSelect_1(__builder2, 34, 35, "currency", 36, "form-control", 37, 
#nullable restore
#line 28 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreatePayment.razor"
                                                                                 payment.Currency

#line default
#line hidden
#nullable disable
                , 38, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => payment.Currency = __value, payment.Currency)), 39, () => payment.Currency, 40, (__builder3) => {
                    __builder3.AddMarkupContent(41, "<option b-1qhdc9h047>RON(Default)</option>");
#nullable restore
#line 30 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreatePayment.razor"
                         foreach (var currency in currencyList)
                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(42, "option");
                    __builder3.AddAttribute(43, "b-1qhdc9h047");
                    __builder3.AddContent(44, 
#nullable restore
#line 32 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreatePayment.razor"
             currency

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 32 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreatePayment.razor"
                              }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(45, "\n                    ");
                __Blazor.BlazorPaymentManagementApp.Pages.CreatePayment.TypeInference.CreateValidationMessage_2(__builder2, 46, 47, 
#nullable restore
#line 34 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreatePayment.razor"
                                              () => payment.Currency

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\n                ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "form-group");
                __builder2.AddAttribute(51, "b-1qhdc9h047");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(52);
                __builder2.AddAttribute(53, "id", "source");
                __builder2.AddAttribute(54, "class", "form-control");
                __builder2.AddAttribute(55, "placeholder", "Source");
                __builder2.AddAttribute(56, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreatePayment.razor"
                                                                                                  payment.Source

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(57, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => payment.Source = __value, payment.Source))));
                __builder2.AddAttribute(58, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => payment.Source));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(59, "\n                    ");
                __Blazor.BlazorPaymentManagementApp.Pages.CreatePayment.TypeInference.CreateValidationMessage_3(__builder2, 60, 61, 
#nullable restore
#line 38 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreatePayment.razor"
                                              () => payment.Source

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\n                ");
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "class", "form-group");
                __builder2.AddAttribute(65, "b-1qhdc9h047");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(66);
                __builder2.AddAttribute(67, "id", "destination");
                __builder2.AddAttribute(68, "class", "form-control");
                __builder2.AddAttribute(69, "placeholder", "Destination");
                __builder2.AddAttribute(70, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreatePayment.razor"
                                                                                                            payment.Destination

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(71, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => payment.Destination = __value, payment.Destination))));
                __builder2.AddAttribute(72, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => payment.Destination));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(73, "\n                    ");
                __Blazor.BlazorPaymentManagementApp.Pages.CreatePayment.TypeInference.CreateValidationMessage_4(__builder2, 74, 75, 
#nullable restore
#line 42 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreatePayment.razor"
                                              () => payment.Destination

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\n                ");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", "form-group");
                __builder2.AddAttribute(79, "b-1qhdc9h047");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(80);
                __builder2.AddAttribute(81, "id", "status");
                __builder2.AddAttribute(82, "class", "form-control");
                __builder2.AddAttribute(83, "placeholder", "Status");
                __builder2.AddAttribute(84, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 45 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreatePayment.razor"
                                                                                                  payment.Status

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(85, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => payment.Status = __value, payment.Status))));
                __builder2.AddAttribute(86, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => payment.Status));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(87, "\n                    ");
                __Blazor.BlazorPaymentManagementApp.Pages.CreatePayment.TypeInference.CreateValidationMessage_5(__builder2, 88, 89, 
#nullable restore
#line 46 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreatePayment.razor"
                                              () => payment.Status

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(90, "\n\n                ");
                __builder2.AddMarkupContent(91, "<div class=\"form-group\" b-1qhdc9h047><input class=\"btn btn-success btn-block\" type=\"submit\" value=\"Submit\" b-1qhdc9h047></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreatePayment.razor"
       public string AmountToSend { get; set; }

    private List<string> currencyList = new List<string>()
        {
            "RON",
            "EUR",
            "GBP",
            "USD"
        };

    private Payment payment = new Payment();

    HttpClient httpClient = new HttpClient()
    {
        BaseAddress = new Uri("http://localhost:5000")
    };

    HttpClient predictorHttpClient = new HttpClient()
    {
        BaseAddress = new Uri("http://localhost:5020")
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
        //payment.Amount = float.Parse(AmountToSend);
        //payment.Id = Int32.Parse(await GenerateId(4));

        ModelInput modelToSend = new ModelInput
        {
            Col0 = 5,
            Trans_date_trans_time = DateTime.Now.ToShortDateString(),
            Cc_num = 5819219885842813f,
            Amt = 5.5f,
            First = "Gion",
            Last = "John",
            City = "Galati",
            State = "Romania",
            Lat = 43.5f,
            Long = 88.2f,
            Merch_lat = 90.04f,
            Merch_long = 33.9f
        };

        var predict_response = await predictorHttpClient.PostAsJsonAsync<ModelInput>("/fraud/index", modelToSend);
        string returnValue = await predict_response.Content.ReadAsStringAsync();
        Console.WriteLine(returnValue);

        //await httpClient.PostAsJsonAsync<Payment>("/api/v1/payments", payment);
        //NavManager.NavigateTo("payments");
    }

    public class ModelInput
    {
        public float Col0 { get; set; }


        public string Trans_date_trans_time { get; set; }

        public float Cc_num { get; set; }

        public float Amt { get; set; }

        public string First { get; set; }

        public string Last { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public float Lat { get; set; }

        public float Long { get; set; }

        public float Merch_lat { get; set; }

        public float Merch_long { get; set; }

        public string Is_fraud { get; set; }
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
namespace __Blazor.BlazorPaymentManagementApp.Pages.CreatePayment
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
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
