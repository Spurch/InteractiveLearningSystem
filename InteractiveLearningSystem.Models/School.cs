namespace InteractiveLearningSystem.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class School
    {
        private ICollection<Group> groups;

        public School()
        {
            this.groups = new HashSet<Group>();
        }

        public int Id { get; set; }

        //[Required]
        [MinLength(10)]
        [MaxLength(100)]
        public string Name { get; set; }

        //[Required]
        [MinLength(10)]
        [MaxLength(100)]
        public string Address { get; set; }

        //[Required]
        public string Affinity { get; set; }

        public string Mobile { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string SiteUrl { get; set; }

        public string AvatarUrl { get; set; }

        public double Points { get; set; }

        public double Experience { get; set; }

        [Range(0,100)]
        public int Level { get; set; }

        [MinLength(50)]
        [MaxLength(1000)]
        public string Notes { get; set; }

        [Required]
        public string ModeratorId { get; set; }

        [ForeignKey("ModeratorId")]
        public virtual User Moderator { get; set; }

        [Required]
        public string ConsultantId { get; set; }

        [ForeignKey("ConsultantId")]
        public virtual User Consultant { get; set; }

        public virtual ICollection<Group> Groups { get { return this.groups; } set { this.groups = value; }  }
    }
}
