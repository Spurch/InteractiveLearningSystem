namespace InteractiveLearningSystem.Web.Infrastructure.Helpers
{
    using Models;
    using Ninject;
    using Services;
    using Services.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class UsersFilter : IUsersFilter
    {
        [Inject]
        IUserServices userServices;

        public UsersFilter(UserServices userServices)
        {
            this.userServices = userServices;
        }

        public IQueryable<User> GetUsersPerUser(User user, IQueryable<User> usersList)
        {
            var userRole = userServices.GetUserRoles(user.Id).First();
            IQueryable<User> resultList = usersList;
            switch (userRole.Name)
            {
                case "Administrator":
                    break;
                case "Moderator":

                    break;
                case "Adviser":
                    break;
                case "Teacher":
                    break;
                case "Student":
                    break;
            }

            return resultList;
        }
    }
}