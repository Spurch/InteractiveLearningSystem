namespace InteractiveLearningSystem.Models
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Security.Claims;
    using System.Threading.Tasks;

    public class User : IdentityUser
    {
        private ICollection<Log> logs;
        private ICollection<Image> images;
        private ICollection<Problem> problems;
        private ICollection<ProblemStat> problemStats;

        private ICollection<Group> groups;
        private ICollection<School> moderators;
        private ICollection<School> consultants;
        private ICollection<Message> sender;
        private ICollection<Message> receiver;

        public User()
        {
            this.moderators = new HashSet<School>();
            this.consultants = new HashSet<School>();
            this.groups = new HashSet<Group>();
            this.sender = new HashSet<Message>();
            this.receiver = new HashSet<Message>();

            this.logs = new HashSet<Log>();
            this.images = new HashSet<Image>();
            this.problems = new HashSet<Problem>();
            this.problemStats = new HashSet<ProblemStat>();
        }

        //[Required]
        [MinLength(3)]
        [MaxLength(50)]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        //[Required]
        [MinLength(3)]
        [MaxLength(50)]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Display(Name = "Facebook")]
        public string FaceBookUrl { get; set; }

        [Display(Name = "Google+")]
        public string GooglePlusUrl { get; set; }

        [Display(Name = "Avatar")]
        public string AvatarUrl { get; set; }

        [MinLength(10)]
        [MaxLength(1000)]
        public string Notes { get; set; }

        public double Points { get; set; }

        public double Experience { get; set; }

        [Range(0,100)]
        public int Level { get; set; }

        [ForeignKey("Group")]
        public int? GroupId { get; set; }

        public virtual Group Group { get; set; }

        public ICollection<School> Moderator { get { return this.moderators; } set { this.moderators = value; } }
        public ICollection<School> Consultant { get { return this.consultants; } set { this.consultants = value; } }
        public ICollection<Group> Groups { get { return this.groups; } set { this.groups = value; } }
  
        [Display(Name = "Sender")]
        public ICollection<Message> Sender { get { return this.sender; } set { this.sender = value; } }
        [Display(Name = "Receiver")]
        public ICollection<Message> Receiver { get { return this.receiver; } set { this.receiver = value; } }

        public virtual ICollection<Log> Logs { get { return this.logs; } set { this.logs = value; } }
        public virtual ICollection<Image> Images { get { return this.images; } set { this.images = value; } }
        public virtual ICollection<Problem> Problems { get { return this.problems; } set { this.problems = value; } }
        public virtual ICollection<ProblemStat> ProblemStats { get { return this.problemStats; } set { this.problemStats = value; } }

        public ClaimsIdentity GenerateUserIdentity(UserManager<User> manager)
        {
            var userIdentity = manager.CreateIdentity(this, DefaultAuthenticationTypes.ApplicationCookie);

            return userIdentity;
        }

        public Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
        {
            return Task.FromResult(GenerateUserIdentity(manager));
        }
    }
}
