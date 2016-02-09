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

        public double Points { get; set; }
        
        public double Experience { get; set; }

        [Range(0,100)]
        public int Level { get; set; }

        [MinLength(1)]
        [MaxLength(100)]
        public string Name { get; set; }

        [MinLength(10)]
        [MaxLength(1000)]
        public string Notes { get; set; }

        public string Affinity { get; set; }

        public string AvatarUrl { get; set; }

        [ForeignKey("Teacher")]
        public string TeacherId { get; set;}

        public virtual User Teacher { get; set; }

        [ForeignKey("School")]
        public int? SchoolId { get; set; }
   
        public virtual School School { get; set; }

        public virtual ICollection<User> Students { get { return this.students; } set { this.students = value; } }
    }
}
