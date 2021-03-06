#pragma checksum "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d1109326cd7c958af0ed8a36be138c34f0ed88f"
// <auto-generated/>
#pragma warning disable 1591
namespace FormBuilder.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
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
#line 22 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor"
using FormBuilder.Data.Entities.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor"
using Microsoft.AspNetCore.Mvc.Rendering;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor"
using FormBuilder.Data.Interfaces;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ManageForms")]
    public class ManageForms : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 27 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor"
 if (FormsList == null) // TODO: Turn this whole page into a reusable CRUD component
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 30 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table table-hover");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.AddMarkupContent(6, "<thead>\r\n            <tr>\r\n                <th>Name</th>\r\n                <th>Modify</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(7, "tbody");
            __builder.AddMarkupContent(8, "\r\n");
#nullable restore
#line 41 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor"
             foreach (var form in FormsList)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "                ");
            __builder.OpenElement(10, "tr");
            __builder.AddMarkupContent(11, "\r\n                    ");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 44 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor"
                         form.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "td");
            __builder.AddMarkupContent(16, "\r\n                        ");
            __builder.OpenElement(17, "i");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor"
                                       e => RemoveForm(form.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "class", "fas fa-trash-alt hover");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, " |\r\n                        ");
            __builder.OpenElement(21, "i");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor"
                                       e => OpenUpdateForm(form.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "class", "fas fa-edit hover");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
#nullable restore
#line 50 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.OpenElement(30, "button");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor"
                       OpenCreateForm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "class", "btn btn-info");
            __builder.AddAttribute(33, "style", "float: right;");
            __builder.AddContent(34, "Create Form");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
#nullable restore
#line 55 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor"
     if (_createModal)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor"
         if (Items != null) // CreateForm form
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(36, "            \r\n            ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "modal");
            __builder.AddAttribute(39, "tabindex", "-1");
            __builder.AddAttribute(40, "style", "display: block");
            __builder.AddAttribute(41, "role", "dialog");
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "modal-dialog");
            __builder.AddMarkupContent(45, "\r\n                    ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "modal-content");
            __builder.AddMarkupContent(48, "\r\n                        ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "modal-header");
            __builder.AddMarkupContent(51, "\r\n                            ");
            __builder.AddMarkupContent(52, "<h3 class=\"modal-title\">Create Form</h3>\r\n                            ");
            __builder.OpenElement(53, "button");
            __builder.AddAttribute(54, "type", "button");
            __builder.AddAttribute(55, "class", "close");
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 65 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor"
                                                                           ToggleCreateModal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(57, "\r\n                                ");
            __builder.AddMarkupContent(58, "<span aria-hidden=\"true\">X</span>\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                        ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "modal-body");
            __builder.AddMarkupContent(63, "\r\n                            ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "form-group");
            __builder.AddMarkupContent(66, "\r\n                                ");
            __builder.AddMarkupContent(67, "<label class=\"col-form-label\">Form Name: </label>\r\n                                ");
            __builder.OpenElement(68, "input");
            __builder.AddAttribute(69, "class", "form-control");
            __builder.AddAttribute(70, "type", "text");
            __builder.AddAttribute(71, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 72 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor"
                                                                    Form.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Form.Name = __value, Form.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                                ");
            __builder.AddMarkupContent(74, "<label class=\"col-form-label\">Brief Description of the form: </label>\r\n                                ");
            __builder.OpenElement(75, "input");
            __builder.AddAttribute(76, "class", "form-control");
            __builder.AddAttribute(77, "type", "text");
            __builder.AddAttribute(78, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 74 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor"
                                                                                Form.Description

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(79, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Form.Description = __value, Form.Description));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                                <br>\r\n");
#nullable restore
#line 76 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor"
                                 if (SelectedFormFields.Count != 0)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(81, "                                    ");
            __builder.AddMarkupContent(82, "<label class=\"col-form-label\">Additional Fields: </label>\r\n                                    ");
            __builder.OpenElement(83, "ul");
            __builder.AddAttribute(84, "class", "list-group-flush");
            __builder.AddMarkupContent(85, "\r\n");
#nullable restore
#line 80 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor"
                                         foreach (var field in SelectedFormFields)
                                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(86, "                                            ");
            __builder.OpenElement(87, "li");
            __builder.AddAttribute(88, "class", "list-group-item d-flex justify-content-between align-items-center");
            __builder.AddMarkupContent(89, "\r\n                                                ");
            __builder.AddContent(90, 
#nullable restore
#line 83 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor"
                                                 field.FieldName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(91, "\r\n                                                ");
            __builder.OpenElement(92, "i");
            __builder.AddAttribute(93, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 84 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor"
                                                               e => RemoveField(field.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(94, "class", "fas fa-trash-alt hover");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n                                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n");
#nullable restore
#line 86 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor"

                                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(97, "                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n");
#nullable restore
#line 89 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(99, "                                ");
            __builder.OpenElement(100, "div");
            __builder.AddAttribute(101, "class", "row");
            __builder.AddMarkupContent(102, "\r\n                                    ");
            __builder.OpenElement(103, "div");
            __builder.AddAttribute(104, "class", "col");
            __builder.AddMarkupContent(105, "\r\n                                        ");
            __builder.OpenElement(106, "select");
            __builder.AddAttribute(107, "class", "custom-select");
            __builder.AddAttribute(108, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 92 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor"
                                                                                 UpdateItem

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(109, "\r\n                                            ");
            __builder.OpenElement(110, "option");
            __builder.AddAttribute(111, "value", "null");
            __builder.AddContent(112, " -- Add additional fields --");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n");
#nullable restore
#line 94 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor"
                                             foreach (var var in Items)
                                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(114, "                                                ");
            __builder.OpenElement(115, "option");
            __builder.AddAttribute(116, "value", 
#nullable restore
#line 96 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor"
                                                               var.Value

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(117, 
#nullable restore
#line 96 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor"
                                                                          var.Text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n");
#nullable restore
#line 97 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor"
                                            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(119, "                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n                                    ");
            __builder.OpenElement(122, "div");
            __builder.AddAttribute(123, "class", "col-2");
            __builder.AddMarkupContent(124, "\r\n                                        ");
            __builder.OpenElement(125, "button");
            __builder.AddAttribute(126, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 101 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor"
                                                           AddField

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(127, "class", "btn btn-info");
            __builder.AddAttribute(128, "style", "float: right;");
            __builder.AddMarkupContent(129, "<span class=\"oi oi-plus p-0\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(132, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(133, "\r\n\r\n                            ");
            __builder.OpenElement(134, "div");
            __builder.AddAttribute(135, "class", "modal-footer");
            __builder.AddMarkupContent(136, "\r\n                                ");
            __builder.OpenElement(137, "button");
            __builder.AddAttribute(138, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 107 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor"
                                                   CreateForm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(139, "class", "btn btn-block btn-info");
            __builder.AddContent(140, "Create Form");
            __builder.CloseElement();
            __builder.AddMarkupContent(141, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(144, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(145, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(146, "\r\n");
#nullable restore
#line 113 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 113 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor"
         
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 116 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor"
     if (_updateModal)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(147, "        \r\n        ");
            __builder.OpenElement(148, "div");
            __builder.AddAttribute(149, "class", "modal");
            __builder.AddAttribute(150, "tabindex", "-1");
            __builder.AddAttribute(151, "style", "display: block");
            __builder.AddAttribute(152, "role", "dialog");
            __builder.AddMarkupContent(153, "\r\n            ");
            __builder.OpenElement(154, "div");
            __builder.AddAttribute(155, "class", "modal-dialog");
            __builder.AddMarkupContent(156, "\r\n                ");
            __builder.OpenElement(157, "div");
            __builder.AddAttribute(158, "class", "modal-content");
            __builder.AddMarkupContent(159, "\r\n                    ");
            __builder.OpenElement(160, "div");
            __builder.AddAttribute(161, "class", "modal-header");
            __builder.AddMarkupContent(162, "\r\n                        ");
            __builder.AddMarkupContent(163, "<h3 class=\"modal-title\">Update Form</h3>\r\n                        ");
            __builder.OpenElement(164, "button");
            __builder.AddAttribute(165, "type", "button");
            __builder.AddAttribute(166, "class", "close");
            __builder.AddAttribute(167, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 124 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor"
                                                                       ToggleUpdateModal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(168, "\r\n                            ");
            __builder.AddMarkupContent(169, "<span aria-hidden=\"true\">X</span>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(170, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(171, "\r\n                    ");
            __builder.OpenElement(172, "div");
            __builder.AddAttribute(173, "class", "modal-body");
            __builder.AddMarkupContent(174, "\r\n                        ");
            __builder.OpenElement(175, "div");
            __builder.AddAttribute(176, "class", "form-group");
            __builder.AddMarkupContent(177, "\r\n                            ");
            __builder.AddMarkupContent(178, "<label class=\"col-form-label\">Form Name: </label>\r\n                            ");
            __builder.OpenElement(179, "input");
            __builder.AddAttribute(180, "class", "form-control");
            __builder.AddAttribute(181, "type", "text");
            __builder.AddAttribute(182, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 131 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor"
                                                                Form.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(183, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Form.Name = __value, Form.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(184, "\r\n                            ");
            __builder.AddMarkupContent(185, "<label class=\"col-form-label\">Brief Description of the form: </label>\r\n                            ");
            __builder.OpenElement(186, "input");
            __builder.AddAttribute(187, "class", "form-control");
            __builder.AddAttribute(188, "type", "text");
            __builder.AddAttribute(189, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 133 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor"
                                                                            Form.Description

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(190, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Form.Description = __value, Form.Description));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(191, "\r\n");
#nullable restore
#line 134 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor"
                             if (SelectedFormFields.Count != 0)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(192, "                                ");
            __builder.AddMarkupContent(193, "<label class=\"col-form-label\">Additional Fields: </label>\r\n                                ");
            __builder.OpenElement(194, "ul");
            __builder.AddAttribute(195, "class", "list-group-flush");
            __builder.AddMarkupContent(196, "\r\n");
#nullable restore
#line 138 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor"
                                     foreach (var field in SelectedFormFields)
                                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(197, "                                        ");
            __builder.OpenElement(198, "li");
            __builder.AddAttribute(199, "class", "list-group-item d-flex justify-content-between align-items-center");
            __builder.AddMarkupContent(200, "\r\n                                            ");
            __builder.AddContent(201, 
#nullable restore
#line 141 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor"
                                             field.FieldName

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(202, "\r\n                                            ");
            __builder.OpenElement(203, "i");
            __builder.AddAttribute(204, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 142 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor"
                                                           e => RemoveField(field.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(205, "class", "fas fa-trash-alt hover");
            __builder.CloseElement();
            __builder.AddMarkupContent(206, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(207, "\r\n");
#nullable restore
#line 144 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor"

                                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(208, "                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(209, "\r\n");
#nullable restore
#line 147 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(210, "                            ");
            __builder.OpenElement(211, "div");
            __builder.AddAttribute(212, "class", "row");
            __builder.AddMarkupContent(213, "\r\n                                ");
            __builder.OpenElement(214, "div");
            __builder.AddAttribute(215, "class", "col");
            __builder.AddMarkupContent(216, "\r\n                                    ");
            __builder.OpenElement(217, "select");
            __builder.AddAttribute(218, "class", "custom-select");
            __builder.AddAttribute(219, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 150 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor"
                                                                             UpdateItem

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(220, "\r\n                                        ");
            __builder.OpenElement(221, "option");
            __builder.AddAttribute(222, "value", "null");
            __builder.AddContent(223, " -- Add additional fields --");
            __builder.CloseElement();
            __builder.AddMarkupContent(224, "\r\n");
#nullable restore
#line 152 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor"
                                         foreach (var var in Items)
                                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(225, "                                            ");
            __builder.OpenElement(226, "option");
            __builder.AddAttribute(227, "value", 
#nullable restore
#line 154 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor"
                                                           var.Value

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(228, 
#nullable restore
#line 154 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor"
                                                                      var.Text

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(229, "\r\n");
#nullable restore
#line 155 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor"
                                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(230, "                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(231, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(232, "\r\n\r\n                                ");
            __builder.OpenElement(233, "div");
            __builder.AddAttribute(234, "class", "col-2");
            __builder.OpenElement(235, "button");
            __builder.AddAttribute(236, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 159 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor"
                                                                      AddField

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(237, "class", "btn btn-info");
            __builder.AddAttribute(238, "style", "float: right;");
            __builder.AddMarkupContent(239, "<span class=\"oi oi-plus p-0\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(240, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(241, "\r\n                            ");
            __builder.OpenElement(242, "div");
            __builder.AddAttribute(243, "class", "modal-footer");
            __builder.AddMarkupContent(244, "\r\n                                ");
            __builder.OpenElement(245, "button");
            __builder.AddAttribute(246, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 162 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor"
                                                   UpdateForm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(247, "class", "btn btn-block btn-info");
            __builder.AddAttribute(248, "style", "float: right;");
            __builder.AddContent(249, "Update Form");
            __builder.CloseElement();
            __builder.AddMarkupContent(250, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(251, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(252, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(253, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(254, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(255, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(256, "\r\n");
#nullable restore
#line 169 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 169 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 172 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageForms.razor"
       
    public List<FormField> Fields;
    public List<FormField> SelectedFormFields = new List<FormField>();
    public List<SelectListItem>
        Items
    { get; set; } = null!;
    public SelectListItem Item { get; set; } = null!;
    public Form Form = null!;
    /// <summary>
    /// List of the forms
    ///</summary>
    public List<Form>
        FormsList;

    /// <summary>
    /// the private backing field for showing the modal
    ///</summary>
    private bool _createModal = false;
    /// <summary>
    /// the private backing field for showing either the update or delete modal
    ///                    </summary>
    private bool _updateModal = false;

    private string Name { get; set; }
    private string Description { get; set; }

    /// <summary>
    /// Initializes the variables
    ///</summary>
    /// <returns></returns>
    protected override async Task OnInitializedAsync()
    {

        Items = Service.GetFormFieldsMultiSelectListAsync();
        Fields = await Service.GetFormFieldsAsync();
        FormsList = await Service.GetFormsAsync();

    }

    /// <summary>
    /// Updates the Item variable to be the selected item from the select input
    ///</summary>
    /// <param name="e"></param>
    protected void UpdateItem(ChangeEventArgs e)
    {
        Item = Items.FirstOrDefault(j => j.Value == e.Value.ToString());
    }
    /// <summary>
    /// Removes the selected item from the list
    ///</summary>
    /// <param name="e"></param>
    protected void RemoveField(string id)
    {
        if (id == null) return;
        SelectedFormFields.Remove(Fields.Find(f => f.Id == id));
        this.StateHasChanged();
    }

    /// <summary>
    /// Adds a field to the page
    ///</summary>
    protected void AddField()
    {
        var i = Items.FirstOrDefault(j => j.Value == Item.Value);
        if (i == null) return;
        SelectedFormFields.Add(Fields.Find(f => f.Id == i.Value));
        this.StateHasChanged();
    }

    /// <summary>
    /// Inserts a new form into the db using form service
    ///</summary>
    /// <returns></returns>
    protected async Task CreateForm()
    {
        await Service.CreateFormAsync(Name, Description, SelectedFormFields);
        await OnInitializedAsync();
        ToggleCreateModal();
        ClearFields();
        this.StateHasChanged();
    }

    /// <summary>
    /// Clears the fields
    ///</summary>
    protected void ClearFields()
    {
        Name = string.Empty;
        Description = string.Empty;
        SelectedFormFields = new List<FormField>
            ();
    }

    /// <summary>
    /// Creates a new form field and opens the modal
    ///</summary>
    protected void OpenCreateForm()
    {
        Form = new Form();
        ToggleCreateModal();
    }

    protected async void RemoveForm(string id)
    {
        if (id == null) return;
        FormsList.Remove(FormsList.Find(form => form.Id == id));
        await Service.DeleteFormAsync(id);
        ClearFields();
        this.StateHasChanged();
    }
    protected async void UpdateForm()
    {
        ToggleUpdateModal();
        await Service.UpdateFormAsync(Form, SelectedFormFields);

        ClearFields();
    }

    protected void OpenUpdateForm(string id)
    {
        if (id == null) return;
        Form = FormsList.Find(form => form.Id == id);
        SelectedFormFields = new List<FormField>
            ();
        foreach (var formWithFields in Form.FormWithFields.ToList())
        {
            SelectedFormFields.Add(formWithFields.FormField);
        }
        ToggleUpdateModal();
        this.StateHasChanged();
    }
    protected void CloseUpdateForm(string id)
    {
        ClearFields();
        ToggleUpdateModal();
        this.StateHasChanged();
    }
    /// <summary>
    /// Toggles the modal on/off
    ///</summary>
    protected void ToggleCreateModal()
    {
        _createModal = !_createModal;

    } /// <summary>
      /// Toggles the modal on/off
      ///</summary>
    protected void ToggleUpdateModal()
    {
        _updateModal = !_updateModal;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFormService Service { get; set; }
    }
}
#pragma warning restore 1591
