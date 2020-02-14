#pragma checksum "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Shared\Components\FormComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f79244257e7721f78113ca403f7de21f007604a"
// <auto-generated/>
#pragma warning disable 1591
namespace FormBuilder.Shared.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\_Imports.razor"
using FormBuilder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\_Imports.razor"
using FormBuilder.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Shared\Components\FormComponent.razor"
using FormBuilder.Data.Entities.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Shared\Components\FormComponent.razor"
using FormBuilder.Shared.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Shared\Components\FormComponent.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    public class FormComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "form");
            __builder.AddMarkupContent(1, "\r\n");
#nullable restore
#line 6 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Shared\Components\FormComponent.razor"
     foreach (var formWithField in Form.FormWithFields)
    {
        var field = formWithField.FormField;
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Shared\Components\FormComponent.razor"
         if (field != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Shared\Components\FormComponent.razor"
             if (Enum.Parse<FormInputType>(field.FormInputType.ToString()) == Enum.Parse<FormInputType>("Hour"))
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "                ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "form-group");
            __builder.AddMarkupContent(5, "\r\n                    ");
            __builder.OpenElement(6, "label");
            __builder.AddAttribute(7, "class", "col-form-label");
            __builder.AddAttribute(8, "for", 
#nullable restore
#line 15 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Shared\Components\FormComponent.razor"
                                                        field.FieldName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(9, 
#nullable restore
#line 15 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Shared\Components\FormComponent.razor"
                                                                          field.FieldName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                    <input type=\"number\" class=\"form-control mb-4\" min=\"0\" step=\"0.25\" value=\"1.00\">\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 18 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Shared\Components\FormComponent.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "                ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "form-group");
            __builder.AddAttribute(15, "style", "padding-top: 10px");
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "label");
            __builder.AddAttribute(18, "class", "col-form-label");
            __builder.AddAttribute(19, "for", 
#nullable restore
#line 22 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Shared\Components\FormComponent.razor"
                                                        field.FieldName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(20, 
#nullable restore
#line 22 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Shared\Components\FormComponent.razor"
                                                                          field.FieldName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "input");
            __builder.AddAttribute(23, "class", "form-control");
            __builder.AddAttribute(24, "type", 
#nullable restore
#line 23 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Shared\Components\FormComponent.razor"
                                                       field.FormInputType

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
#nullable restore
#line 25 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Shared\Components\FormComponent.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Shared\Components\FormComponent.razor"
             
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Shared\Components\FormComponent.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(27, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
#nullable restore
#line 31 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Shared\Components\FormComponent.razor"
 if (_showModal)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(29, "    \r\n    ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "modal");
            __builder.AddAttribute(32, "tabindex", "-1");
            __builder.AddAttribute(33, "style", "display:block");
            __builder.AddAttribute(34, "role", "dialog");
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "modal-dialog");
            __builder.AddMarkupContent(38, "\r\n            ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "modal-content");
            __builder.AddMarkupContent(41, "\r\n                ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "modal-header");
            __builder.AddMarkupContent(44, "\r\n                    ");
            __builder.AddMarkupContent(45, "<h3 class=\"modal-title\">Success</h3>\r\n                    ");
            __builder.OpenElement(46, "button");
            __builder.AddAttribute(47, "type", "button");
            __builder.AddAttribute(48, "class", "close");
            __builder.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Shared\Components\FormComponent.razor"
                                                                   ToggleModal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "data-dismiss", "modal");
            __builder.AddMarkupContent(51, "\r\n                        ");
            __builder.AddMarkupContent(52, "<span aria-hidden=\"true\">X</span>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                ");
            __builder.AddMarkupContent(55, "<div class=\"modal-body\">\r\n                    <div class=\"p-1\">Your form has been submitted successfully</div>\r\n                </div>\r\n                ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "modal-footer");
            __builder.AddMarkupContent(58, "\r\n                    ");
            __builder.OpenElement(59, "button");
            __builder.AddAttribute(60, "class", "btn btn-block btn-info");
            __builder.AddAttribute(61, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Shared\Components\FormComponent.razor"
                                                                      ToggleModal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(62, "Ok");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n");
#nullable restore
#line 52 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Shared\Components\FormComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Shared\Components\FormComponent.razor"
       
    /// <summary>
    /// The form being displayed
    /// </summary>
    [Parameter]
    public Form Form { get; set; }
    /// <summary>
    /// the private backing field for showing the modal
    /// </summary>
    private bool _showModal = false;

    /// <summary>
    /// Toggles the modal on/off
    /// </summary>
    protected void ToggleModal()
    {
        _showModal = !_showModal;
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591