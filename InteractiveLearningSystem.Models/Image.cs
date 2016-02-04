namespace InteractiveLearningSystem.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Image
    {
        public int Id { get; set; }

        public string ImageUrl { get; set; }

        public string Title { get; set; }

        public DateTime DateCreated { get; set; }

        //[Required]
        public string AuthorId { get; set; }

        [ForeignKey("AuthorId")]
        public virtual User Author { get; set; }

        //public int ProblemId { get; set; }

        //[ForeignKey("ProblemId")]
        //public virtual Problem Problem { get; set; }

        public int AnswerId { get; set; }

        [ForeignKey("AnswerId")]
        public virtual Answer Answer { get; set; }
    }
}
