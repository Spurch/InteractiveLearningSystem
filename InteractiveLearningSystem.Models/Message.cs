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

        public DateTime DateCreated { get; set; }

        public string Flag { get; set; }

        [MinLength(10)]
        [MaxLength(100)]
        public string Notes { get; set; }

        [ForeignKey("Sender")]
        public string SenderId { get; set; }

        public virtual User Sender { get; set; }

        [ForeignKey("Receiver")]
        public string ReceiverId { get; set; }

        public virtual User Receiver { get; set; }
    }
}
