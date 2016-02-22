namespace InteractiveLearningSystem.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using InteractiveLearningSystem.Models;
    using System.Threading.Tasks;
    public interface IInteractiveLearningSystemDbContext : IDisposable
    {
        int SaveChanges();

        Task<int> SaveChangesAsync();

        IDbSet<User> Users { get; set; }

        IDbSet<School> Schools { get; set; }

        IDbSet<Group> Groups { get; set; }

        IDbSet<Answer> Answers { get; set; }

        IDbSet<Problem> Tasks { get; set; }

        IDbSet<Image> Images { get; set; }

        IDbSet<Log> Logs { get; set; }

        IDbSet<Message> Messages { get; set; }

        IDbSet<ProblemStat> TaskStats { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
    }
}
