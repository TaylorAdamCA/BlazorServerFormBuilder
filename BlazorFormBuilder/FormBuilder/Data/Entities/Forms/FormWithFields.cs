namespace FormBuilder.Data.Entities.Forms
{
    /// <summary>
    /// The bridge table for the forms
    /// </summary>
    public class FormWithFields : BaseEntity
    {
        /// <summary>
        /// Foreign Key
        /// </summary>
        public string FormId { get; set; }

        /// <summary>
        /// Navigation Property
        /// </summary>
        public Form Form { get; set; }

        /// <summary>
        /// Foreign Key
        /// </summary>
        public string FormFieldId { get; set; }

        /// <summary>
        /// Navigation Property
        /// </summary>
        public FormField FormField { get; set; }
    }
}