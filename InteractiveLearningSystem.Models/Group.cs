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

        public int Level { get; set; }

        public string Name { get; set; }

        public string Notes { get; set; }

        public string AvatarUrl { get; set; }

        //[Required]
        public string TeacherId { get; set;}

        [ForeignKey("TeacherId")]
        public virtual User Teacher { get; set; }

        //[Required]
        public int SchoolId { get; set; }

        [ForeignKey("SchoolId")]
        public virtual School School { get; set; }

        public virtual ICollection<User> Students { get { return this.students; } set { this.students = value; } }
    }
}
