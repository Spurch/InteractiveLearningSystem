namespace InteractiveLearningSystem.Services
{
    using System;
    using System.Linq;
    using Contracts;
    using Data.Repositories;
    using Models;

    public class UserServices : IUserServices
    {
        private IRepository<User> users;

        public UserServices(IRepository<User> users)
        {
            this.users = users;
        }

        public User GetById(string id)
        {
            return users.GetById(id);
        }

        public User Create(string name)
        {
            throw new NotImplementedException();
        }

        public void DeleteId(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<User> GetAll()
        {
            return users.All();
        }

        public void Update(string id)
        {
            throw new NotImplementedException();
        }
    }
}
