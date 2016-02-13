namespace InteractiveLearningSystem.Web.Infrastructure.Helpers
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IUsersFilter
    {
        IQueryable<User> GetUsersPerUser(User user, IQueryable<User> usersList);

        bool IsUserAuthorizedToViewRole(User user, string role);
    }
}
