namespace InteractiveLearningSystem.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Task
    {
        private ICollection<Image> images;
        private ICollection<Answer> answers;

        public Task()
        {
            this.images = new HashSet<Image>();
            this.answers = new HashSet<Answer>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Notes { get; set; }

        public double Experience { get; set;}

        public int Difficulty { get; set; }

        [Required]
        public string AuthorId { get; set; }

        [ForeignKey("AuthorId")]
        public virtual User Author { get; set; }

        public virtual ICollection<Image> Images { get { return this.images; } set { this.images = value; } }

        public virtual ICollection<Answer> Answers { get { return this.answers; } set { this.answers = value; } }
    }
}
