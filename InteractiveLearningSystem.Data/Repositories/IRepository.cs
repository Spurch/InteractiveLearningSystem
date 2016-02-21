﻿namespace InteractiveLearningSystem.Data.Repositories
{
    using System;
    using System.Linq;

    public interface IRepository<T> : IDisposable where T : class
    {
        IQueryable<T> All();

        T GetById(int? id);

        T GetById(string id);

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        void Delete(int id);

        void Detach(T entity);

        int SaveChanges();
    }
}
