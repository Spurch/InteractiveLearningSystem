
namespace InteractiveLearningSystem.Services.Contracts
{
    using System.Linq;
    using Microsoft.AspNet.Identity.EntityFramework;

    public interface IRoleServices
    {
        IQueryable<IdentityRole> GetAll();

        IdentityRole GetById(string id);

        IdentityRole Create(string name);

        IdentityRole GetByName(string name);

        IQueryable<IdentityRole> GetAllRolesExcluding(string name);

        void Update(string id);
    }
}
