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

        public string Name { get; set; }

        public string Content { get; set; }

        public string Notes { get; set; }

        [Required]
        public int QuestionId { get; set; }

        [ForeignKey("QuestionId")]
        public virtual Task Question { get; set; }

        public ICollection<Image> Images { get { return this.images; } set { this.images = value; } }
    }
}
