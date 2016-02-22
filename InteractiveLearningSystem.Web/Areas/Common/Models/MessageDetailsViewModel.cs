namespace InteractiveLearningSystem.Web.Areas.Common.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using AutoMapper;
    using Infrastructure.Mapping;
    using InteractiveLearningSystem.Models;

    public class MessageDetailsViewModel : IMapFrom<Message>
    {
        public int Id { get; set; }

        [MinLength(1)]
        [MaxLength(100)]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [MinLength(1)]
        [MaxLength(2000)]
        [Display(Name = "Content")]
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }

        [Display(Name = "Date")]
        public DateTime DateCreated { get; set; }

        [Display(Name = "Flag")]
        public string Flag { get; set; }

        [MaxLength(1000)]
        [Display(Name = "Notes")]
        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }

        [Display(Name = "Sender")]
        public User Sender { get; set; }

        [Display(Name = "Sender e-mail")]
        [DataType(DataType.EmailAddress)]
        public string SenderEmail { get; set; }

        [Display(Name = "Receiver e-mail")]
        [DataType(DataType.EmailAddress)]
        public string ReceiverEmail { get; set; }
    }
}