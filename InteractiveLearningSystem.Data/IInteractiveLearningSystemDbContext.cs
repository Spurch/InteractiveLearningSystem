﻿namespace InteractiveLearningSystem.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using InteractiveLearningSystem.Models;

    public interface IInteractiveLearningSystemDbContext : IDisposable
    {
        int SaveChanges();

        IDbSet<User> Users { get; set; }

        IDbSet<School> Schools { get; set; }

        IDbSet<Group> Groups { get; set; }

        IDbSet<Answer> Answers { get; set; }

        IDbSet<Task> Tasks { get; set; }

        IDbSet<Image> Images { get; set; }

        IDbSet<Log> Logs { get; set; }

        IDbSet<Message> Messages { get; set; }

        IDbSet<TaskStat> TaskStats { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
    }
}
