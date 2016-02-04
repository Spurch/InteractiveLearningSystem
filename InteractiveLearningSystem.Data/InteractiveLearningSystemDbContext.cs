namespace InteractiveLearningSystem.Data
{
    using System;
    using System.Data.Entity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using InteractiveLearningSystem.Models;

    public class InteractiveLearningSystemDbContext : IdentityDbContext<User>, IInteractiveLearningSystemDbContext
    {

        public InteractiveLearningSystemDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public IDbSet<Answer> Answers { get; set; }

        public IDbSet<Group> Groups { get; set; }

        public IDbSet<Image> Images { get; set; }

        public IDbSet<Log> Logs { get; set; }

        public IDbSet<Message> Messages { get; set; }

        public IDbSet<School> Schools { get; set; }

        public IDbSet<Task> Tasks { get; set; }

        public IDbSet<TaskStat> TaskStats { get; set; }

        public static InteractiveLearningSystemDbContext Create()
        {
            return new InteractiveLearningSystemDbContext();
        }
    }
}
