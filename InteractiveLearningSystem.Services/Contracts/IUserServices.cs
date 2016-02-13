namespace InteractiveLearningSystem.Services.Contracts
{
    using System.Linq;
    using Models;
    using Microsoft.AspNet.Identity.EntityFramework;

    public interface IUserServices
    {
        IQueryable<User> GetAll();

        IQueryable<IdentityRole> GetUserRoles(string id);

        User GetById(string id);

        User Create(string name);

        void Update(string id);

        void DeleteId(int id);
    }
}
