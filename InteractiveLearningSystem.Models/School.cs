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

        [Key]
        public int Id { get; set; }

        public bool isDeleted { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(100)]
        public string Address { get; set; }

        [MinLength(2)]
        [MaxLength(100)]
        public string City { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(100)]
        public string Affinity { get; set; }

        [MinLength(10)]
        [MaxLength(10)]
        public string Mobile { get; set; }

        [MinLength(5)]
        [MaxLength(12)]
        public string Phone { get; set; }

        public string Email { get; set; }

        public string SiteUrl { get; set; }

        public string AvatarUrl { get; set; }

        public double Points { get; set; }

        public double Experience { get; set; }

        [Range(0, 100)]
        public int Level { get; set; }

        [MinLength(50)]
        [MaxLength(1000)]
        public string Notes { get; set; }

        [ForeignKey("Moderator")]
        public string ModeratorId { get; set; }

        public virtual User Moderator { get; set; }

        [ForeignKey("Consultant")]
        public string ConsultantId { get; set; }

        public virtual User Consultant { get; set; }

        public virtual ICollection<Group> Groups { get { return this.groups; } set { this.groups = value; } }
    }
}
