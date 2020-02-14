using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormBuilder.Data.Entities.Forms;
using FormBuilder.Data.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace FormBuilder.Data.Services
{
    /// <summary>
    /// The service class for forms that allows the front end to interact with the database
    /// </summary>
    public class FormService : BaseService<Form>, IFormService
    {
        private readonly AppDbContext _appDbContext;

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="appDbContext"> the injected db context</param>
        public FormService(AppDbContext appDbContext) : base(appDbContext)
        {
            _appDbContext = appDbContext;
        }

        /// <summary>
        /// Get a list of all the forms in the database
        /// </summary>
        /// <returns> A list of all the forms in the database</returns>
        public async Task<List<Form>> GetFormsAsync()
        {
            return await _appDbContext.Forms
                .Include(f => f.FormWithFields)
                .ToListAsync();
        }

        /// <summary>
        /// Get a list of all the FormsFields in the database
        /// </summary>
        /// <returns> A list of all the FormFields in the database</returns>
        public async Task<List<FormField>> GetFormFieldsAsync()
        {
            return await _appDbContext.FormFields
                .ToListAsync();
        }

        /// <summary>
        /// Gets the form with the corresponding form id
        /// </summary>
        /// <param name="formId"> the form id of the form you are trying to retrieve </param>
        /// <returns></returns>
        public async Task<Form> GetFormAsync(string formId)
        {
            var form = await _appDbContext.Forms
                 .Include(f => f.FormWithFields)
                     .ThenInclude(f => f.FormField)
                 .SingleOrDefaultAsync(f => f.Id == formId);

            return form;
        }

        /// <summary>
        /// Gets the formField with the corresponding formFieldId
        /// </summary>
        /// <param name="formFieldId"> the formFieldId of the formField you are trying to retrieve </param>
        /// <returns></returns>
        public async Task<FormField> GetFormFieldAsync(string formFieldId)
        {
            var formField = await _appDbContext.FormFields
                .Include(f => f.FormWithFields)
                .SingleOrDefaultAsync(f => f.Id == formFieldId);

            return formField;
        }

        /// <summary>
        /// Inserts the new form field to the database
        /// </summary>
        /// <param name="formField">The form field to be inserted</param>
        /// <returns></returns>
        public async Task<FormField> InsertFormFieldAsync(FormField formField)
        {
            formField.Id = Guid.NewGuid().ToString();
            formField.DateCreated = DateTime.Now;
            formField.DateUpdated = DateTime.Now;
            var result = await _appDbContext.FormFields.AddAsync(formField);
            await _appDbContext.SaveChangesAsync();

            return formField;
        }

        /// <summary>
        /// Inserts the new Form into the database
        /// </summary>
        /// <param name="form"> The form to be inserted </param>
        /// <returns> The form entity </returns>
        public async Task<Form> InsertFormAsync(Form form)
        {
            var result = await _appDbContext.Forms.AddAsync(form);
            await _appDbContext.SaveChangesAsync();

            return form;
        }

        /// <summary>
        /// Updates the form, use this if your updating the fields and not just the name/description
        /// </summary>
        /// <param name="f"> the form to be updated </param>
        /// <param name="selectedFormFields" > </param>
        /// <returns></returns>
        public async Task<Form> UpdateFormAsync(Form f, List<FormField> selectedFormFields)
        {
            var form = await _appDbContext.Forms.FindAsync(f.Id);
            if (form == null)
                return null;

            _appDbContext.FormWithFields.RemoveRange(form.FormWithFields);

            List<FormWithFields> formWithFields = CreateFormWithFields(f.Description, selectedFormFields, form);

            form.FormWithFields = formWithFields;
            form.DateUpdated = DateTime.Now;
            _appDbContext.Forms.Update(form);
            await _appDbContext.SaveChangesAsync();

            return form;
        }

        // <summary>
        /// Updates the form, use this if your just updating the name/description
        /// </summary>
        /// <param name="f"> the form to be updated </param>
        /// <returns></returns>
        public async Task<Form> UpdateFormAsync(Form form)
        {

            _appDbContext.Forms.Update(form);
            await _appDbContext.SaveChangesAsync();

            return form;
        }

        /// <summary>
        /// Deletes a form with the supplied id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Form> DeleteFormAsync(string id)
        {
            var form = await _appDbContext.Forms.FindAsync(id);

            if (form == null)
                return null;

            _appDbContext.Forms.Remove(form);
            await _appDbContext.SaveChangesAsync();

            return form;
        }

        /// <summary>
        /// Deletes a form field with the supplied id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<FormField> DeleteFormFieldAsync(string id)
        {
            // TODO: Delete the form if it's the only field?
            var formField = await _appDbContext.FormFields
                .Include(f => f.FormWithFields)
                .FirstOrDefaultAsync(f => f.Id == id);

            if (formField == null)
                return null;

            // Delete any FormWithFields entries related to this field, not sure why this isn't automatic like it is when we delete a form
            foreach (var formWithFields in formField.FormWithFields)
            {
                _appDbContext.FormWithFields.Remove(formWithFields);
            }

            _appDbContext.FormFields.Remove(formField);

            await _appDbContext.SaveChangesAsync();

            return formField;
        }

        public async void UpdateFormFieldAsync(FormField formField)
        {
            formField.DateUpdated = DateTime.Now;

            _appDbContext.FormFields.Update(formField);
            await _appDbContext.SaveChangesAsync();
        }

        /// <summary>
        /// Returns all of the form fields as a list of select list items
        /// </summary>
        /// <returns></returns>
        public List<SelectListItem> GetFormFieldsMultiSelectListAsync()
        {
            return _appDbContext.FormFields.Select(a =>
             new SelectListItem
             {
                 Value = a.Id.ToString(),
                 Text = a.FieldName
             }).ToList();
        }

        /// <summary>
        /// Creates a form with the selected formFields
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="selectedFormFields"></param>
        /// <returns></returns>
        public async Task<Form> CreateFormAsync(string name, string description, List<FormField> selectedFormFields)
        {
            // Create a new form
            var form = new Form()
            {
                Id = Guid.NewGuid().ToString(),
                Name = name,
                Description = description,
                DateCreated = DateTime.Now,
                DateUpdated = DateTime.Now,
            };

            List<FormWithFields> formWithFields = CreateFormWithFields(description, selectedFormFields, form);

            // TODO: Save all to db
            _appDbContext.FormWithFields.AddRange(formWithFields);

            return await InsertFormAsync(form);
        }

        private static List<FormWithFields> CreateFormWithFields(string description, List<FormField> selectedFormFields, Form form)
        {
            // The list of all the formsWithFields
            List<FormWithFields> formsWithFields = new List<FormWithFields>();
            // Create all the new FormWithFields
            foreach (var formField in selectedFormFields)
            {
                var formWithFields = new FormWithFields()
                {
                    Id = Guid.NewGuid().ToString(),
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    Description = description,
                    Form = form,
                    FormField = formField,
                    FormId = form.Id,
                    FormFieldId = formField.Id
                };
                formsWithFields.Add(formWithFields);
            }

            return formsWithFields;
        }

        /// <summary>
        /// See if the form exists given the Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool FormExists(string id)
        {
            return _appDbContext.Forms.Any(e => e.Id == id);
        }
    }
}