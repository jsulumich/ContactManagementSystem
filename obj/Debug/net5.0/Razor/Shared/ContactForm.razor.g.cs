#pragma checksum "C:\Users\jsult\Documents\Tech Interview\ContactManagement\ContactManagementSystem\Shared\ContactForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86f4fa5e6210bdad918354c710ee104e2337a97a"
// <auto-generated/>
#pragma warning disable 1591
namespace ContactManagementSystem.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\jsult\Documents\Tech Interview\ContactManagement\ContactManagementSystem\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jsult\Documents\Tech Interview\ContactManagement\ContactManagementSystem\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jsult\Documents\Tech Interview\ContactManagement\ContactManagementSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jsult\Documents\Tech Interview\ContactManagement\ContactManagementSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\jsult\Documents\Tech Interview\ContactManagement\ContactManagementSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\jsult\Documents\Tech Interview\ContactManagement\ContactManagementSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\jsult\Documents\Tech Interview\ContactManagement\ContactManagementSystem\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\jsult\Documents\Tech Interview\ContactManagement\ContactManagementSystem\_Imports.razor"
using ContactManagementSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\jsult\Documents\Tech Interview\ContactManagement\ContactManagementSystem\_Imports.razor"
using ContactManagementSystem.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\jsult\Documents\Tech Interview\ContactManagement\ContactManagementSystem\_Imports.razor"
using ContactManagementSystem.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jsult\Documents\Tech Interview\ContactManagement\ContactManagementSystem\Shared\ContactForm.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
    public partial class ContactForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddContent(1, 
#nullable restore
#line 4 "C:\Users\jsult\Documents\Tech Interview\ContactManagement\ContactManagementSystem\Shared\ContactForm.razor"
     actionType

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(2, " Contact");
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n<hr>");
#nullable restore
#line 7 "C:\Users\jsult\Documents\Tech Interview\ContactManagement\ContactManagementSystem\Shared\ContactForm.razor"
 if (contact != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
            __builder.AddAttribute(5, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "C:\Users\jsult\Documents\Tech Interview\ContactManagement\ContactManagementSystem\Shared\ContactForm.razor"
                      contact

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "OnInvalidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\Users\jsult\Documents\Tech Interview\ContactManagement\ContactManagementSystem\Shared\ContactForm.razor"
                               (async () => await HandleSubmitAsync(false))

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "C:\Users\jsult\Documents\Tech Interview\ContactManagement\ContactManagementSystem\Shared\ContactForm.razor"
                             (async () => await HandleSubmitAsync(true))

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(9);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n      \r\n        ");
                __builder2.OpenElement(13, "p");
                __builder2.OpenElement(14, "label");
                __builder2.AddMarkupContent(15, "\r\n                Last Name:\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(16);
                __builder2.AddAttribute(17, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\jsult\Documents\Tech Interview\ContactManagement\ContactManagementSystem\Shared\ContactForm.razor"
                                        contact.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => contact.LastName = __value, contact.LastName))));
                __builder2.AddAttribute(19, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => contact.LastName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n        ");
                __builder2.OpenElement(21, "p");
                __builder2.OpenElement(22, "label");
                __builder2.AddMarkupContent(23, "\r\n                First Name:\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(24);
                __builder2.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\jsult\Documents\Tech Interview\ContactManagement\ContactManagementSystem\Shared\ContactForm.razor"
                                        contact.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => contact.FirstName = __value, contact.FirstName))));
                __builder2.AddAttribute(27, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => contact.FirstName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n        ");
                __builder2.OpenElement(29, "p");
                __builder2.OpenElement(30, "label");
                __builder2.AddMarkupContent(31, "\r\n                Birth Date:\r\n                ");
                __Blazor.ContactManagementSystem.Shared.ContactForm.TypeInference.CreateInputDate_0(__builder2, 32, 33, 
#nullable restore
#line 30 "C:\Users\jsult\Documents\Tech Interview\ContactManagement\ContactManagementSystem\Shared\ContactForm.razor"
                                        contact.BirthDate

#line default
#line hidden
#nullable disable
                , 34, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => contact.BirthDate = __value, contact.BirthDate)), 35, () => contact.BirthDate);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n        ");
                __builder2.OpenElement(37, "p");
                __builder2.OpenElement(38, "label");
                __builder2.AddMarkupContent(39, "\r\n                Phone Number:\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(40);
                __builder2.AddAttribute(41, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "C:\Users\jsult\Documents\Tech Interview\ContactManagement\ContactManagementSystem\Shared\ContactForm.razor"
                                        contact.PhoneNumber

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => contact.PhoneNumber = __value, contact.PhoneNumber))));
                __builder2.AddAttribute(43, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => contact.PhoneNumber));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(45, "button");
                __builder2.AddAttribute(46, "class", "btn btn-warning");
                __builder2.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\jsult\Documents\Tech Interview\ContactManagement\ContactManagementSystem\Shared\ContactForm.razor"
                                                  CancelAsync

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(48, "\r\n            Cancel\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "&nbsp;\r\n        ");
                __builder2.AddMarkupContent(50, "<button type=\"submit\" class=\"btn btn-primary\">\r\n            Save\r\n        </button>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 47 "C:\Users\jsult\Documents\Tech Interview\ContactManagement\ContactManagementSystem\Shared\ContactForm.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\jsult\Documents\Tech Interview\ContactManagement\ContactManagementSystem\Shared\ContactForm.razor"
       
    [Parameter]
    public EventCallback<bool> ValidationResult { get; set; }

    [Parameter]
    public EventCallback CancelRequest { get; set; }

    // true if "add contact" page
    [Parameter]
    public bool IsAdd { get; set; }
  
    
    [Parameter]
    public bool Busy { get; set; }

    [Parameter]
    public Contact contact { get; set; }

    // different wording depending on the page
    private string actionType => IsAdd ? "Add a" : "Edit a";

    // Ask to cancel.
    private Task CancelAsync()
    {
        return CancelRequest.InvokeAsync(null);
    }

    // Handle form submission request.
    private Task HandleSubmitAsync(bool isValid)
    {
        return ValidationResult.InvokeAsync(isValid);
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.ContactManagementSystem.Shared.ContactForm
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
