#pragma checksum "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9aef517537d125f592ac58561345ff0897fbe812"
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
#line 2 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\Login.razor"
using BlazorPaymentManagementApp.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\Login.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\Login.razor"
using System.Text.Json.Serialization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\Login.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\Login.razor"
using System.Timers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "register-photo");
            __builder.AddAttribute(2, "b-kkxyimxcrz");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "form-container");
            __builder.AddAttribute(5, "b-kkxyimxcrz");
            __builder.AddMarkupContent(6, "<div class=\"image-holder\" b-kkxyimxcrz></div>\n        ");
            __builder.OpenElement(7, "form");
            __builder.AddAttribute(8, "method", "post");
            __builder.AddAttribute(9, "b-kkxyimxcrz");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(10);
            __builder.AddAttribute(11, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 21 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\Login.razor"
                              user

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 21 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\Login.razor"
                                                   LoginUser

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(14);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\n\n                ");
                __builder2.AddMarkupContent(16, "<h2 class=\"text-center\" b-kkxyimxcrz><strong b-kkxyimxcrz>Welcome back</strong></h2>\n                ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "form-group");
                __builder2.AddAttribute(19, "b-kkxyimxcrz");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(20);
                __builder2.AddAttribute(21, "type", "text");
                __builder2.AddAttribute(22, "id", "Username");
                __builder2.AddAttribute(23, "class", "form-control");
                __builder2.AddAttribute(24, "placeholder", "Username");
                __builder2.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\Login.razor"
                                                                                                                  user.Username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Username = __value, user.Username))));
                __builder2.AddAttribute(27, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.Username));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\n                    ");
                __Blazor.BlazorPaymentManagementApp.Pages.Login.TypeInference.CreateValidationMessage_0(__builder2, 29, 30, 
#nullable restore
#line 27 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\Login.razor"
                                              () => user.Username

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\n                ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "form-group");
                __builder2.AddAttribute(34, "b-kkxyimxcrz");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(35);
                __builder2.AddAttribute(36, "type", "password");
                __builder2.AddAttribute(37, "id", "password");
                __builder2.AddAttribute(38, "class", "form-control");
                __builder2.AddAttribute(39, "placeholder", "Password");
                __builder2.AddAttribute(40, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\Login.razor"
                                                                                                                      user.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Password = __value, user.Password))));
                __builder2.AddAttribute(42, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(43, "\n                    ");
                __Blazor.BlazorPaymentManagementApp.Pages.Login.TypeInference.CreateValidationMessage_1(__builder2, 44, 45, 
#nullable restore
#line 31 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\Login.razor"
                                              () => user.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\n                ");
                __builder2.AddMarkupContent(47, "<div class=\"form-group\" b-kkxyimxcrz><input class=\"btn btn-success btn-block\" type=\"submit\" value=\"Submit\" b-kkxyimxcrz> <a class=\"already\" href=\"/register\" b-kkxyimxcrz> Don\'t have an account? Register here.</a></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune11.20-27.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\Login.razor"
      
    private List<User> users;

    private static Timer aTimer;

    private User user = new User();

    private string username { get; set; }
    private string password { get; set; }

    HttpClient httpClient = new HttpClient()
    {
        BaseAddress = new Uri("http://localhost:5000")
    };

    protected async Task LoginUser()
    {
        //LoginClass loginObject = new LoginClass(username, password);

        username = user.Username;
        password = user.Password;

        List<string> my_request = new List<string> { username, password };

        var raspuns = await httpClient.PostAsJsonAsync<List<string>>("/api/v1/users/find", my_request);
        string returnValue = await raspuns.Content.ReadAsStringAsync();
        if (returnValue != "-1")
        {
            await localStorage.SetItemAsync("autentificat", "1");
            await localStorage.SetItemAsync("id", returnValue);

            aTimer = new System.Timers.Timer();
            aTimer.Interval = 1000;

            // Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += (sender, args) =>
            {
                NavManager.NavigateTo("/users/" + returnValue, true);
            };

            // Have the timer fire repeated events (true is the default)
            aTimer.AutoReset = true;

            // Start the timer
            aTimer.Enabled = true;

        }


    }



    protected override async Task OnInitializedAsync()
    {

        users = await httpClient.GetFromJsonAsync<List<User>>("/api/v1/users");

    }

    public class LoginClass
    {
        private string Username { get; set; }
        private string Password { get; set; }

        public LoginClass(string _username, string _password)
        {
            this.Username = _username;
            this.Password = _password;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
    }
}
namespace __Blazor.BlazorPaymentManagementApp.Pages.Login
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
    }
}
#pragma warning restore 1591
