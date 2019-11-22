using System.Collections.Generic;
using System.Threading.Tasks;
using FormBuilder.Data.Entities.Forms;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FormBuilder.Data.Interfaces
{
    /// <summary>
    /// The interface for the service class for forms that allows the front end to interact with the database
    /// </summary>
    public interface IFormService : IBaseService<Form>
    {  /// <summary>
       /// Get a list of all the forms in the database
       /// </summary>
       /// <returns> A list of all the forms in the database</returns>
        Task<List<Form>> GetFormsAsync();

        /// <summary>
        /// Gets the form with the corresponding form id
        /// </summary>
        /// <param name="formId"> the form id of the form you are trying to retrieve </param>
        /// <returns></returns>
        Task<Form> GetFormAsync(string formId);

        /// <summary>
        /// Inserts the new Form into the database
        /// </summary>
        /// <param name="form"> The form to be inserted </param>
        /// <returns> The form entity </returns>
        Task<Form> InsertFormAsync(Form form);

        /// <summary>
        /// Updates the form
        /// </summary>
        /// <param name="f"> the form to be updated </param>
        /// <param name="selectedFormFields"> the new fields on the form </param>
        /// <returns></returns>
        Task<Form> UpdateFormAsync(Form f, List<FormField> selectedFormFields);

        // <summary>
        /// Updates the form, use this if your just updating the namedescription
        /// </summary>
        /// <param name="f"> the form to be updated </param>
        /// <returns></returns>
        Task<Form> UpdateFormAsync(Form f);

        /// <summary>
        /// Deletes a form with the supplied id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Form> DeleteFormAsync(string id);

        /// <summary>
        /// Returns all of the form fields as a list of select list items
        /// </summary>
        /// <returns></returns>
        List<SelectListItem> GetFormFieldsMultiSelectListAsync();

        /// <summary>
        /// Get a list of all the FormsFields in the database
        /// </summary>
        /// <returns> A list of all the FormFields in the database</returns>
        Task<List<FormField>> GetFormFieldsAsync();

        /// <summary>
        /// Gets the formField with the corresponding formFieldId
        /// </summary>
        /// <param name="formFieldId"> the formFieldId of the formField you are trying to retrieve </param>
        /// <returns></returns>
        Task<FormField> GetFormFieldAsync(string formFieldId);

        /// <summary>
        /// Creates a form with the selected formFields
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="selectedFormFields"></param>
        /// <returns></returns>
        Task<Form> CreateFormAsync(string name, string description, List<FormField> selectedFormFields);

        /// <summary>
        /// See if the form exists given the Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool FormExists(string id);

        /// <summary>
        /// Inserts the new form field to the database
        /// </summary>
        /// <param name="formField">The form field to be inserted</param>
        /// <returns></returns>
        Task<FormField> InsertFormFieldAsync(FormField formField);

        /// <summary>
        /// Deletes a form field with the supplied id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<FormField> DeleteFormFieldAsync(string id);

        /// <summary>
        /// Updates a form field
        /// </summary>
        /// <param name="formField"></param>
        void UpdateFormFieldAsync(FormField formField);
    }
}