namespace InteractiveLearningSystem.Web.Infrastructure.Helpers
{
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
    public sealed class EmailSimilarityChecker : ValidationAttribute
    {
        private const string _defaultErrorMessage = "'{0}' and '{1}' are the same!";

        private readonly object _typeId = new object();

        public EmailSimilarityChecker(string originalProperty, string confirmProperty)
            : base(_defaultErrorMessage)
        {
            OriginalProperty = originalProperty;
            ConfirmProperty = confirmProperty;
        }

        public string ConfirmProperty
        {
            get;
            private set;
        }

        public string OriginalProperty
        {
            get;
            private set;
        }

        public override object TypeId
        {
            get
            {
                return _typeId;
            }
        }

        public override string FormatErrorMessage(string name)
        {
            return String.Format(CultureInfo.CurrentUICulture, ErrorMessageString,
                OriginalProperty, ConfirmProperty);
        }

        public override bool IsValid(object value)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(value);
            object originalValue = properties.Find(OriginalProperty, true).GetValue(value);
            object confirmValue = properties.Find(ConfirmProperty, true).GetValue(value);
            return !Object.Equals(originalValue, confirmValue);
        }
    }
}