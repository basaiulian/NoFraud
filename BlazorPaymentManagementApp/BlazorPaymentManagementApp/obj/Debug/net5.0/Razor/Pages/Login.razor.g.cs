#pragma checksum "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a694cbc3983a3dfca5669216d371e631612aca1"
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
#line 2 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\Login.razor"
using BlazorPaymentManagementApp.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\Login.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\Login.razor"
using System.Text.Json.Serialization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\Login.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\Login.razor"
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
            __builder.AddMarkupContent(0, "<h3>Login</h3>\r\n\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 18 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\Login.razor"
                  user

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 18 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\Login.razor"
                                       LoginUser

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    <hr>\r\n\r\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-group row");
                __builder2.AddMarkupContent(9, "<label for=\"username\" class=\"col-sm-2 col-form-label\">\r\n            Username\r\n        </label>\r\n        ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "col-sm-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(12);
                __builder2.AddAttribute(13, "id", "balance");
                __builder2.AddAttribute(14, "class", "form-control");
                __builder2.AddAttribute(15, "placeholder", "Username");
                __builder2.AddAttribute(16, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\Login.razor"
                                                                                             user.Username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Username = __value, user.Username))));
                __builder2.AddAttribute(18, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.Username));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n            ");
                __Blazor.BlazorPaymentManagementApp.Pages.Login.TypeInference.CreateValidationMessage_0(__builder2, 20, 21, 
#nullable restore
#line 28 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\Login.razor"
                                      () => user.Username

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n\r\n    ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "form-group row");
                __builder2.AddMarkupContent(25, "<label for=\"password\" class=\"col-sm-2 col-form-label\">\r\n            Password\r\n        </label>\r\n        ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "col-sm-10");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(28);
                __builder2.AddAttribute(29, "id", "password");
                __builder2.AddAttribute(30, "class", "form-control");
                __builder2.AddAttribute(31, "placeholder", "Password");
                __builder2.AddAttribute(32, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\Login.razor"
                                                                                              user.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Password = __value, user.Password))));
                __builder2.AddAttribute(34, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n            ");
                __Blazor.BlazorPaymentManagementApp.Pages.Login.TypeInference.CreateValidationMessage_1(__builder2, 36, 37, 
#nullable restore
#line 38 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\Login.razor"
                                      () => user.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n    <hr>\r\n\r\n    <input type=\"submit\" value=\"Submit\">");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune8.33-20.12.2020\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\Login.razor"
      
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

        var raspuns = await httpClient.PostAsJsonAsync<List<string>>("/api/users/find", my_request);
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

        users = await httpClient.GetFromJsonAsync<List<User>>("/api/users");

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
