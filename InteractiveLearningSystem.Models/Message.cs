namespace InteractiveLearningSystem.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Message
    {

        public int Id { get; set; }

        [MinLength(10)]
        [MaxLength(100)]
        public string Title { get; set; }

        [MinLength(10)]
        [MaxLength(1000)]
        public string Content { get; set; }

        [Display(Name = "Date")]
        public DateTime DateCreated { get; set; }

        [Display(Name = "Flag")]
        public string Flag { get; set; }

        public bool isViewed { get; set; }

        public bool isDeleted { get; set; }

        [MinLength(10)]
        [MaxLength(100)]
        [Display(Name = "Notes")]
        public string Notes { get; set; }

        [ForeignKey("Sender")]
        public string SenderId { get; set; }

        [Display(Name = "Sender")]
        public virtual User Sender { get; set; }

        [ForeignKey("Receiver")]
        public string ReceiverId { get; set; }

        [Display(Name = "Receiver")]
        public virtual User Receiver { get; set; }
    }
}
