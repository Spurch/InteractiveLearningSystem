namespace InteractiveLearningSystem.Models
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Security.Claims;
    using System.Threading.Tasks;

    public class User : IdentityUser
    {
        private ICollection<Message> messages;
        private ICollection<Log> logs;
        private ICollection<Group> groups;
        private ICollection<Image> images;
        private ICollection<Problem> problems;
        private ICollection<ProblemStat> problemStats;

        public User()
        {
            this.messages = new HashSet<Message>();
            this.logs = new HashSet<Log>();
            this.groups = new HashSet<Group>();
            this.images = new HashSet<Image>();
            this.problems = new HashSet<Problem>();
            this.problemStats = new HashSet<ProblemStat>();
        }

        //[Required]
        public string FirstName { get; set; }

        //[Required]
        public string LastName { get; set; }

        public string FaceBookUrl { get; set; }

        public string GooglePlusUrl { get; set; }

        public string AvatarUrl { get; set; }

        public string Notes { get; set; }

        public double Points { get; set; }

        public double Experience { get; set; }

        public int Level { get; set; }

        public int SchoolId { get; set; }

        public virtual ICollection<School> School { get; set; }
        public virtual ICollection<Message> Messages { get { return this.messages; } set { this.messages = value; } }
        public virtual ICollection<Log> Logs { get { return this.logs; } set { this.logs = value; } }
        public virtual ICollection<Group> Groups { get { return this.groups; } set { this.groups = value; } }
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
