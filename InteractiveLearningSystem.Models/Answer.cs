namespace InteractiveLearningSystem.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Answer
    {
        private ICollection<Image> images;

        public Answer()
        {
            this.images = new HashSet<Image>();
        }

        public int Id { get; set; }

        public bool isDeleted { get; set; }

        [MinLength(10)]
        [MaxLength(100)]
        public string Name { get; set; }

        [MinLength(50)]
        [MaxLength(1000)]
        public string Content { get; set; }

        [MinLength(50)]
        [MaxLength(1000)]
        public string Notes { get; set; }

        [MinLength(10)]
        [MaxLength(100)]
        public string Context { get; set; }

        [Required]
        public int QuestionId { get; set; }

        [ForeignKey("QuestionId")]
        public virtual Problem Question { get; set; }

        public ICollection<Image> Images { get { return this.images; } set { this.images = value; } }
    }
}
