namespace InteractiveLearningSystem.Web.Areas.Common.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;
    using Infrastructure.Helpers;
    using Infrastructure.Mapping;
    using InteractiveLearningSystem.Models;

    [EmailSimilarityChecker("ReceiverEmail", "SenderEmail", ErrorMessage = "Sender and Receiver email addresses cannot be the same!")]
    public class MessageCreateViewModel : IMapFrom<Message>
    {
        ISanitizer sanitizer;
        public MessageCreateViewModel()
        {
            sanitizer = new HtmlSanitizerAdapter();
        }

        [MinLength(1)]
        [MaxLength(100)]
        [Display(Name = "Title")]
        [AllowHtml]
        public string Title { get; set; }

        [MinLength(1)]
        [MaxLength(2000)]
        [Display(Name = "Content")]
        [DataType(DataType.MultilineText)]
        [AllowHtml]
        public string Content { get; set; }

        [Display(Name = "Date")]
        public DateTime DateCreated { get; set; }

        [Display(Name = "Flag")]
        public string Flag { get; set; }

        [MaxLength(1000)]
        [Display(Name = "Notes")]
        [DataType(DataType.MultilineText)]
        [AllowHtml]
        public string Notes { get; set; }

        [Display(Name = "Sender e-mail")]
        [DataType(DataType.EmailAddress)]
        [HiddenInput(DisplayValue = false)]
        public string SenderEmail { get; set; }

        [Display(Name = "Receiver e-mail")]
        [DataType(DataType.EmailAddress)]
        public string ReceiverEmail { get; set; }


        public string sanitizedContent
        {
            get
            {
                return this.sanitizer.Sanitize(this.Content);
            }
        }
        public string sanitizedNotes
        {
            get
            {
                return this.sanitizer.Sanitize(this.Notes);
            }
        }
        public string sanitizedFlag
        {
            get
            {
                return this.sanitizer.Sanitize(this.Flag);
            }
        }
        public string sanitizedTitle
        {
            get
            {
                return this.sanitizer.Sanitize(this.Title);
            }
        }
    }
}