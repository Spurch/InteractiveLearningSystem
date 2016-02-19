namespace InteractiveLearningSystem.Data
{
    using System;
    using System.Data.Entity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using InteractiveLearningSystem.Models;
    using System.Data.Entity.ModelConfiguration.Conventions;
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

        public IDbSet<Problem> Tasks { get; set; }

        public IDbSet<ProblemStat> TaskStats { get; set; }

        DbSet<TEntity> IInteractiveLearningSystemDbContext.Set<TEntity>()
        {
            return base.Set<TEntity>();
        }

        public static InteractiveLearningSystemDbContext Create()
        {
            return new InteractiveLearningSystemDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
      
            modelBuilder.Entity<School>().HasOptional(b => b.Consultant).WithMany(a => a.Consultant).HasForeignKey(b => b.ConsultantId);
            modelBuilder.Entity<School>().HasOptional(b => b.Moderator).WithMany(a => a.Moderator).HasForeignKey(b => b.ModeratorId);

            modelBuilder.Entity<Message>().HasOptional(b => b.Sender).WithMany(a => a.Sender).HasForeignKey(b => b.SenderId);
            modelBuilder.Entity<Message>().HasOptional(b => b.Receiver).WithMany(a => a.Receiver).HasForeignKey(b => b.ReceiverId);

            modelBuilder.Entity<Group>().HasOptional(b => b.Teacher).WithMany(a => a.Groups).HasForeignKey(b => b.TeacherId);
            modelBuilder.Entity<User>().HasOptional(b => b.Group).WithMany(a => a.Students).HasForeignKey(b => b.GroupId);

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

        }
    }
}
