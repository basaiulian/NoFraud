#pragma checksum "C:\Users\gabby\Documents\GitHub\NoFraud\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreateCard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5936f142be043d0f0e343d98a05c53dbafc133ce"
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
#line 3 "C:\Users\gabby\Documents\GitHub\NoFraud\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreateCard.razor"
using BlazorPaymentManagementApp.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/createcard")]
    public partial class CreateCard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "register-photo");
            __builder.AddAttribute(2, "b-mrxb3qfwvc");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "form-container");
            __builder.AddAttribute(5, "b-mrxb3qfwvc");
            __builder.AddMarkupContent(6, "<div class=\"image-holder\" b-mrxb3qfwvc></div>\r\n        ");
            __builder.OpenElement(7, "form");
            __builder.AddAttribute(8, "method", "post");
            __builder.AddAttribute(9, "b-mrxb3qfwvc");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(10);
            __builder.AddAttribute(11, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "C:\Users\gabby\Documents\GitHub\NoFraud\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreateCard.razor"
                              card

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 13 "C:\Users\gabby\Documents\GitHub\NoFraud\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreateCard.razor"
                                                   Create

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(14);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n\r\n                ");
                __builder2.AddMarkupContent(16, "<h2 class=\"text-center\" b-mrxb3qfwvc><strong b-mrxb3qfwvc>Create Card </strong></h2>\r\n\r\n\r\n                ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "form-group");
                __builder2.AddAttribute(19, "b-mrxb3qfwvc");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(20);
                __builder2.AddAttribute(21, "id", "number");
                __builder2.AddAttribute(22, "class", "form-control");
                __builder2.AddAttribute(23, "placeholder", "Number");
                __builder2.AddAttribute(24, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\gabby\Documents\GitHub\NoFraud\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreateCard.razor"
                                                                                                  card.Number

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => card.Number = __value, card.Number))));
                __builder2.AddAttribute(26, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => card.Number));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n                    ");
                __Blazor.BlazorPaymentManagementApp.Pages.CreateCard.TypeInference.CreateValidationMessage_0(__builder2, 28, 29, 
#nullable restore
#line 21 "C:\Users\gabby\Documents\GitHub\NoFraud\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreateCard.razor"
                                              () => card.Number

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n\r\n                ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "form-group");
                __builder2.AddAttribute(33, "b-mrxb3qfwvc");
                __Blazor.BlazorPaymentManagementApp.Pages.CreateCard.TypeInference.CreateInputDate_1(__builder2, 34, 35, "expirationDate", 36, "form-control", 37, 
#nullable restore
#line 25 "C:\Users\gabby\Documents\GitHub\NoFraud\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreateCard.razor"
                                                                                     card.ExpirationDate

#line default
#line hidden
#nullable disable
                , 38, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => card.ExpirationDate = __value, card.ExpirationDate)), 39, () => card.ExpirationDate);
                __builder2.AddMarkupContent(40, "\r\n                    ");
                __Blazor.BlazorPaymentManagementApp.Pages.CreateCard.TypeInference.CreateValidationMessage_2(__builder2, 41, 42, 
#nullable restore
#line 26 "C:\Users\gabby\Documents\GitHub\NoFraud\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreateCard.razor"
                                              () => card.ExpirationDate

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n\r\n                ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "class", "form-group");
                __builder2.AddAttribute(46, "b-mrxb3qfwvc");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(47);
                __builder2.AddAttribute(48, "id", "pinCode");
                __builder2.AddAttribute(49, "class", "form-control");
                __builder2.AddAttribute(50, "placeholder", "PIN Code");
                __builder2.AddAttribute(51, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\Users\gabby\Documents\GitHub\NoFraud\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreateCard.razor"
                                                                                                     card.PinCode

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => card.PinCode = __value, card.PinCode))));
                __builder2.AddAttribute(53, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => card.PinCode));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(54, "\r\n                    ");
                __Blazor.BlazorPaymentManagementApp.Pages.CreateCard.TypeInference.CreateValidationMessage_3(__builder2, 55, 56, 
#nullable restore
#line 31 "C:\Users\gabby\Documents\GitHub\NoFraud\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreateCard.razor"
                                              () => card.PinCode

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n\r\n\r\n                ");
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "form-group");
                __builder2.AddAttribute(60, "b-mrxb3qfwvc");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(61);
                __builder2.AddAttribute(62, "id", "cvvCode");
                __builder2.AddAttribute(63, "class", "form-control");
                __builder2.AddAttribute(64, "placeholder", "CVV Code");
                __builder2.AddAttribute(65, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "C:\Users\gabby\Documents\GitHub\NoFraud\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreateCard.razor"
                                                                                                     card.CvvCode

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(66, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => card.CvvCode = __value, card.CvvCode))));
                __builder2.AddAttribute(67, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => card.CvvCode));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(68, "\r\n                    ");
                __Blazor.BlazorPaymentManagementApp.Pages.CreateCard.TypeInference.CreateValidationMessage_4(__builder2, 69, 70, 
#nullable restore
#line 37 "C:\Users\gabby\Documents\GitHub\NoFraud\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreateCard.razor"
                                              () => card.CvvCode

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n\r\n\r\n                ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "form-group");
                __builder2.AddAttribute(74, "b-mrxb3qfwvc");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(75);
                __builder2.AddAttribute(76, "id", "bankName");
                __builder2.AddAttribute(77, "class", "form-control");
                __builder2.AddAttribute(78, "placeholder", "Bank Name");
                __builder2.AddAttribute(79, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 42 "C:\Users\gabby\Documents\GitHub\NoFraud\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreateCard.razor"
                                                                                                       card.BankName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(80, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => card.BankName = __value, card.BankName))));
                __builder2.AddAttribute(81, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => card.BankName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(82, "\r\n                    ");
                __Blazor.BlazorPaymentManagementApp.Pages.CreateCard.TypeInference.CreateValidationMessage_5(__builder2, 83, 84, 
#nullable restore
#line 43 "C:\Users\gabby\Documents\GitHub\NoFraud\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreateCard.razor"
                                              () => card.BankName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(85, ">\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\r\n\r\n                ");
                __builder2.OpenElement(87, "div");
                __builder2.AddAttribute(88, "class", "form-group");
                __builder2.AddAttribute(89, "b-mrxb3qfwvc");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(90);
                __builder2.AddAttribute(91, "id", "bankAccountId");
                __builder2.AddAttribute(92, "class", "form-control");
                __builder2.AddAttribute(93, "placeholder", "Bank Account Id");
                __builder2.AddAttribute(94, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 47 "C:\Users\gabby\Documents\GitHub\NoFraud\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreateCard.razor"
                                                                                                                  card.BankAccountId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(95, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => card.BankAccountId = __value, card.BankAccountId))));
                __builder2.AddAttribute(96, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => card.BankAccountId));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(97, "\r\n                    ");
                __Blazor.BlazorPaymentManagementApp.Pages.CreateCard.TypeInference.CreateValidationMessage_6(__builder2, 98, 99, 
#nullable restore
#line 48 "C:\Users\gabby\Documents\GitHub\NoFraud\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreateCard.razor"
                                              () => card.BankAccountId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(100, "\r\n                ");
                __builder2.OpenElement(101, "div");
                __builder2.AddAttribute(102, "class", "form-group");
                __builder2.AddAttribute(103, "b-mrxb3qfwvc");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(104);
                __builder2.AddAttribute(105, "id", "ownerId");
                __builder2.AddAttribute(106, "class", "form-control");
                __builder2.AddAttribute(107, "placeholder", "Owner Id");
                __builder2.AddAttribute(108, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 51 "C:\Users\gabby\Documents\GitHub\NoFraud\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreateCard.razor"
                                                                                                     card.OwnerId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(109, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => card.OwnerId = __value, card.OwnerId))));
                __builder2.AddAttribute(110, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => card.OwnerId));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(111, "\r\n                    ");
                __Blazor.BlazorPaymentManagementApp.Pages.CreateCard.TypeInference.CreateValidationMessage_7(__builder2, 112, 113, 
#nullable restore
#line 52 "C:\Users\gabby\Documents\GitHub\NoFraud\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreateCard.razor"
                                              () => card.OwnerId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(114, "\r\n\r\n                ");
                __builder2.AddMarkupContent(115, "<div class=\"form-group\" b-mrxb3qfwvc><input class=\"btn btn-success btn-block\" type=\"submit\" value=\"Submit\" b-mrxb3qfwvc></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "C:\Users\gabby\Documents\GitHub\NoFraud\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\CreateCard.razor"
       private Card card = new Card();

    HttpClient httpClient = new HttpClient()
    {
        BaseAddress = new Uri("http://localhost:5000")
    };

    protected async Task Create()
    {
        await httpClient.PostAsJsonAsync<Card>("/api/cards", card);
        NavManager.NavigateTo("users/" + card.OwnerId);

    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
namespace __Blazor.BlazorPaymentManagementApp.Pages.CreateCard
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
        public static void CreateInputDate_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
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
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
