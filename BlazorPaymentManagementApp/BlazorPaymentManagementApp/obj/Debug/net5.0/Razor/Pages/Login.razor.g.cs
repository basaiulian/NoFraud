#pragma checksum "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "185f40b083f9a8c2b6a943662e33c8a96c98e165"
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
#line 3 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\Login.razor"
using BlazorPaymentManagementApp.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\Login.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\Login.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\Login.razor"
using System.Text.Json.Serialization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\Login.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\Login.razor"
using System.Timers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.13.0/css/all.min.css\" b-kkxyimxcrz>\n    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "register-photo");
            __builder.AddAttribute(3, "b-kkxyimxcrz");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "form-container");
            __builder.AddAttribute(6, "b-kkxyimxcrz");
            __builder.AddMarkupContent(7, "<div class=\"image-holder\" b-kkxyimxcrz></div>\n            ");
            __builder.OpenElement(8, "form");
            __builder.AddAttribute(9, "method", "post");
            __builder.AddAttribute(10, "b-kkxyimxcrz");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(11);
            __builder.AddAttribute(12, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 18 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\Login.razor"
                                  user

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 18 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\Login.razor"
                                                       LoginUser

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(15, "<h2 class=\"text-center\" b-kkxyimxcrz><strong b-kkxyimxcrz>Welcome back</strong></h2>\n\n                    ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "form-group");
                __builder2.AddAttribute(18, "b-kkxyimxcrz");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(19);
                __builder2.AddAttribute(20, "id", "username");
                __builder2.AddAttribute(21, "class", "form-control");
                __builder2.AddAttribute(22, "placeholder", "Username");
                __builder2.AddAttribute(23, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\Login.razor"
                                                                                                          username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => username = __value, username))));
                __builder2.AddAttribute(25, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => username));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\n\n                    ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "form-group");
                __builder2.AddAttribute(29, "style", "display:inline-flex");
                __builder2.AddAttribute(30, "b-kkxyimxcrz");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(31);
                __builder2.AddAttribute(32, "type", 
#nullable restore
#line 26 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\Login.razor"
                                          showType

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(33, "id", "password");
                __builder2.AddAttribute(34, "class", "form-control");
                __builder2.AddAttribute(35, "placeholder", "Password");
                __builder2.AddAttribute(36, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\Login.razor"
                                                                                                                           password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => password = __value, password))));
                __builder2.AddAttribute(38, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => password));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\n\n                    ");
                __builder2.OpenElement(40, "i");
                __builder2.AddAttribute(41, "class", "far fa-eye");
                __builder2.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\Login.razor"
                                                    () => showPassword()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "b-kkxyimxcrz");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\n\n                    ");
                __builder2.AddMarkupContent(45, @"<div class=""form-group"" b-kkxyimxcrz><input class=""btn btn-success btn-block"" type=""submit"" value=""Submit"" b-kkxyimxcrz> <a class=""already"" href=""/register"" b-kkxyimxcrz> Don't have an account? Register here.</a> <a class=""already"" href=""/forgotpassword"" b-kkxyimxcrz> Forgot your password? Click here.</a></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\n        ");
            __builder.OpenElement(47, "h3");
            __builder.AddAttribute(48, "b-kkxyimxcrz");
            __builder.AddContent(49, 
#nullable restore
#line 38 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\Login.razor"
             goodMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\n        ");
            __builder.OpenElement(51, "h4");
            __builder.AddAttribute(52, "b-kkxyimxcrz");
            __builder.AddContent(53, 
#nullable restore
#line 39 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\Login.razor"
             badMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "D:\Facultate\Anul III\[INET] Introducere in .NET\NOFRAUD\Versiune13.48-12.1.2021\BlazorPaymentManagementApp\BlazorPaymentManagementApp\Pages\Login.razor"
      
    private List<User> users;

    private string showType = "password";

    private static Timer aTimer;

    private string goodMessage = "";
    private string badMessage = "";

    private User user = new User();
    private string username { get; set; }
    private string password { get; set; }

    HttpClient httpClient = new HttpClient()
    {
        BaseAddress = new Uri("http://localhost:5000")
    };

    private void showPassword()
    {
        if(showType == "password")
        {
            showType = "text";
        } else if (showType == "text")
        {
            showType = "password";
        }
    }

    protected async Task LoginUser()
    {
        List<string> my_request = new List<string> { username.ToLower(), password };

        var raspuns = await httpClient.PostAsJsonAsync<List<string>>("/api/v1/users/find", my_request);
        string returnValue = await raspuns.Content.ReadAsStringAsync();
        Console.WriteLine(returnValue);
        if (returnValue != "-1")
        {
            badMessage = "";
            goodMessage = "";
            goodMessage += "Logged in successfully, you will be redirected to your profile in one second... !";

            await localStorage.SetItemAsync("autentificat", "True");
            await localStorage.SetItemAsync("id", returnValue);

            aTimer = new Timer();
            aTimer.Interval = 1000;
            aTimer.Elapsed += (sender, args) =>
            {
                NavManager.NavigateTo("/users/" + returnValue, true);
            };

            aTimer.AutoReset = true;
            aTimer.Enabled = true;

        } else
        {
            badMessage = "";
            badMessage += "Invalid credentials, try again!";
        }


    }

    protected override async Task OnInitializedAsync()
    {

        users = await httpClient.GetFromJsonAsync<List<User>>("/api/v1/users");

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
    }
}
#pragma warning restore 1591
