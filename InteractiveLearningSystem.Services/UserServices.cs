namespace InteractiveLearningSystem.Services
{
    using System;
    using System.Linq;
    using Contracts;
    using Data.Repositories;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System.Collections.Generic;
    public class UserServices : IUserServices
    {
        private IRepository<User> users;
        private IRepository<IdentityRole> roles;

        public UserServices(IRepository<User> users, IRepository<IdentityRole> roles)
        {
            this.roles = roles;
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

        public IQueryable<IdentityRole> GetUserRoles(string id)
        {
            var rolesList = new List<IdentityRole>();
            var userRoles = users.GetById(id).Roles;
            foreach (var role in userRoles)
            {
                rolesList.Add(roles.GetById(role.RoleId));
            }

            return rolesList.AsQueryable();
        }
    }
}
