namespace InteractiveLearningSystem.Web.Areas.Common.Models
{
    using Infrastructure.Mapping;
    using InteractiveLearningSystem.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    public class MessageCreateViewModel : IMapFrom<Message>
    {
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
        public virtual User Sender { get; set; }

        [ForeignKey("Receiver")]
        [Display(Name = "Receiver e-mail")]
        [DataType(DataType.EmailAddress)]
        public string ReceiverEmail { get; set; }

        [Display(Name = "Receiver")]
        public virtual User Receiver { get; set; }

    }
}