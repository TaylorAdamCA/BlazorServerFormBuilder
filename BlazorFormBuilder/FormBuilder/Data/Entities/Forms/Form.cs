using System.Collections.Generic;

namespace FormBuilder.Data.Entities.Forms
{
    /// <summary>
    /// Represents a form
    /// </summary>
    public class Form : BaseEntity
    {
        /// <summary>
        /// Name of the form
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The id of the form creator - may not be used right away
        /// </summary>
        public string CreatorId { get; set; }

        /// <summary>
        /// The list of form fields that use this form this form uses - reference navigation property
        /// </summary>
        public List<FormWithFields> FormWithFields { get; set; }
    }
}