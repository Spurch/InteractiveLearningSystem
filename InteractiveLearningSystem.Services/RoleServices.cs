namespace InteractiveLearningSystem.Services
{
    using System;
    using System.Linq;
    using Contracts;
    using Data.Repositories;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class RoleServices : IRoleServices
    {
        private IRepository<IdentityRole> roles;

        public RoleServices(IRepository<IdentityRole> roles)
        {
            this.roles = roles;
        }

        public IdentityRole Create(string name)
        {
            var role = new IdentityRole()
            {
                Name = name
            };
            roles.Add(role);

            roles.SaveChanges();

            return role;
        }

        public IQueryable<IdentityRole> GetAll()
        {
            return roles.All();
        }

        public IQueryable<IdentityRole> GetAllRolesExcluding(string name)
        {
            return roles.All().Where(x => x.Name != name);
        }

        public IdentityRole GetById(string id)
        {
            return roles.GetById(id);
        }

        public IdentityRole GetByName(string name)
        {
            var temp = roles.All().Where(x => x.Name == name).First();
            return temp;
        }

        public void Update(string id)
        {
            throw new NotImplementedException();
        }
    }
}
