namespace InteractiveLearningSystem.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Problem
    {
        private ICollection<Image> images;
        private ICollection<Answer> answers;
        private ICollection<ProblemStat> problemStats;

        public Problem()
        {
            this.images = new HashSet<Image>();
            this.answers = new HashSet<Answer>();
            this.problemStats = new HashSet<ProblemStat>();
        }

        public int Id { get; set; }

        [MinLength(10)]
        [MaxLength(100)]
        public string Name { get; set; }
        
        [MinLength(50)]
        [MaxLength(1000)]
        public string Description { get; set; }

        [MinLength(50)]
        [MaxLength(1000)]
        public string Notes { get; set; }

        public string Affinity { get; set; }

        public double Experience { get; set;}
        
        public bool HasContext { get; set; }

        [Range(1, 10)]
        public int Difficulty { get; set; }

        [Required]
        public string AuthorId { get; set; }

        [ForeignKey("AuthorId")]
        public virtual User Author { get; set; }

        public virtual ICollection<Image> Images { get { return this.images; } set { this.images = value; } }

        public virtual ICollection<Answer> Answers { get { return this.answers; } set { this.answers = value; } }

        public virtual ICollection<ProblemStat> ProblemStats { get { return this.problemStats; } set { this.problemStats = value; } }
    }
}
