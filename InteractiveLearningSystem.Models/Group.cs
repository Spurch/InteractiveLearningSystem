namespace InteractiveLearningSystem.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Group
    {

        private ICollection<User> students;

        public Group()
        {
            this.students = new HashSet<User>();
        }

        public int Id { get; set; }

        [Display(Name = "Points")]
        public double Points { get; set; }

        [Display(Name = "Experience")]
        public double Experience { get; set; }

        public bool isDeleted { get; set; }

        [Range(0,100)]
        [Display(Name = "Level")]
        public int Level { get; set; }

        [MinLength(1)]
        [MaxLength(100)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [MinLength(10)]
        [MaxLength(1000)]
        [Display(Name = "Notes")]
        public string Notes { get; set; }

        [Display(Name = "Affinity")]
        public string Affinity { get; set; }

        [Display(Name = "Avatar")]
        public string AvatarUrl { get; set; }

        [ForeignKey("Teacher")]
        public string TeacherId { get; set;}

        [Display(Name = "Master")]
        public virtual User Teacher { get; set; }

        [ForeignKey("School")]
        public int? SchoolId { get; set; }

        [Display(Name = "Guild")]
        public virtual School School { get; set; }

        public virtual ICollection<User> Students { get { return this.students; } set { this.students = value; } }
    }
}
