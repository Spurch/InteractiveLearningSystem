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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="users"></param>
        /// <param name="roles"></param>
        public UserServices(IRepository<User> users, IRepository<IdentityRole> roles)
        {
            this.roles = roles;
            this.users = users;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public User GetById(string id)
        {
            return users.GetById(id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public User Create(string name)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void DeleteId(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IQueryable<User> GetAll()
        {
            return users.All();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void Update(string id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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

        public void UpdateNotes(string id, string notes)
        {
            var user = users.GetById(id);
            user.Notes = notes;
            users.SaveChanges();
        }

        public User GetByEmail(string email)
        {
            return users.All().Where(x => x.Email == email).FirstOrDefault();
        }
    }
}
