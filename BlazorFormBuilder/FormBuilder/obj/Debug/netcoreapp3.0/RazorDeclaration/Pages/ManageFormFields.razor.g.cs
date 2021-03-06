#pragma checksum "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageFormFields.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "633a87d1f28a9fb50570c5fcc55bb844e47d8115"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 3 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageFormFields.razor"
using FormBuilder.Data.Entities.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageFormFields.razor"
using FormBuilder.Data.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageFormFields.razor"
using FormBuilder.Shared.Enums;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ManageFormFields")]
    public class ManageFormFields : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 128 "D:\Repos\BlazorFormBuilder\BlazorFormBuilder\FormBuilder\Pages\ManageFormFields.razor"
            
    /// <summary>
    /// The list of form fields
    /// </summary>
    public List<FormField> FieldsList;
    public FormField Field = null;
    public FormInputType InputType = FormInputType.Text;
    /// <summary>
    /// the private backing field for showing the modal to create a form field
    /// </summary>
    private bool _createModal = false;
    /// <summary>
    /// the private backing field for showing the modal to update a form field
    /// </summary>
    private bool _updateModal = false;

    /// <summary>
    /// the backing field for showing values box
    /// </summary>
    private bool _showValuesBox = false;

    /// <summary>
    /// Method invoked when the component is ready to start, having received its initial parameters from its parent in the render tree.
    /// Gets the forms from the form services and assigns them to FormsList
    /// </summary>
    /// <returns></returns>
    protected override async Task OnInitializedAsync()

    {
        FieldsList = await Service.GetFormFieldsAsync();
    }
    /// <summary>
    /// Toggles the modal on/off
    /// </summary>
    protected void ToggleCreateModal()
    {
        _createModal = !_createModal;

    }/// <summary>
     /// Toggles the modal on/off
     /// </summary>
    protected void ToggleUpdateModal()
    {
        _updateModal = !_updateModal;
    }

    /// <summary>
    /// Creates a new form field and opens the modal
    /// </summary>
    protected void OpenCreateField()
    {
        Field = new FormField();
        ToggleCreateModal();

    }

    protected void ToggleValuesBoxClearValues()
    {
        if (!_showValuesBox && Field.UseValues)
        {
            Field.UseValues = false;
            Field.Values = null;
        }
        else
        {
            _showValuesBox = !_showValuesBox;
        }
    }

    protected void ToggleValuesBox()
    {
        _showValuesBox = !_showValuesBox;
    }
    /// <summary>
    /// Opens the modal to update the form field
    /// </summary>
    protected async void OpenUpdateFormField(string id)
    {
        Field = await Service.GetFormFieldAsync(id);
        if (Field.UseValues)
            _showValuesBox = true;
        else
            _showValuesBox = false;

        ToggleUpdateModal();
        this.StateHasChanged();
    }

    protected void UpdateFormField()
    {
        if (_showValuesBox)
        {
            Field.UseValues = true;
            ToggleValuesBox();
        }
        else
        {
            Field.UseValues = false;
            Field.Values = null;
        }

        ToggleUpdateModal();

        Field.FormInputType = InputType;
        Service.UpdateFormFieldAsync(Field);
    }

    /// <summary>
    /// Inserts the created form field into the database
    /// </summary>
    protected async void InsertField()
    {
        if (Field.Values != null)
            Field.UseValues = true;

        if (_showValuesBox)
            ToggleValuesBox();

        Field.FormInputType = InputType;
        await Service.InsertFormFieldAsync(Field);
        FieldsList.Add(Field);
        ToggleCreateModal();

        this.StateHasChanged();
    }

    protected async void RemoveFormField(string id)
    {

        if (id == null) return;
        await Service.DeleteFormFieldAsync(id);
        FieldsList.Remove(FieldsList.Find(formField => formField.Id == id));
        this.StateHasChanged();
    }
    /// <summary>
    /// Updates the state when the selected form changes
    /// and assigns the form to FormSelected
    /// </summary>
    /// <param name="e"></param>
    protected void InputTypeClicked(ChangeEventArgs e)
    {

        InputType = Enum.Parse<FormInputType>(e.Value.ToString());
        this.StateHasChanged();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFormService Service { get; set; }
    }
}
#pragma warning restore 1591
