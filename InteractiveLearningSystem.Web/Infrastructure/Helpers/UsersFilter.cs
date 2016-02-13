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
            List<User> resultList = new List<User>();
            switch (userRole.Name)
            {
                case "Administrator":
                    resultList = usersList.ToList();
                    break;
                case "Moderator":
                    foreach (var currentUser in usersList)
                    {
                        if (currentUser.Group != null && currentUser.Group.SchoolId == user.Moderator.First().Id)
                        {
                            resultList.Add(currentUser);
                        }
                        else if (currentUser.Group == null && currentUser.Consultant.First().Id == user.Moderator.First().Id)
                        {
                            resultList.Add(currentUser);
                        }
                    }
                    break;
                case "Adviser":
                    foreach (var currentUser in usersList)
                    {
                        if (currentUser.Group != null && currentUser.Group.SchoolId == user.Consultant.First().Id)
                        {
                            resultList.Add(currentUser);
                        }
                    }
                    break;
                case "Teacher":
                    foreach (var currentUser in usersList)
                    {
                        if (currentUser.Group != null && currentUser.Group.SchoolId == user.Group.SchoolId)
                        {
                            resultList.Add(currentUser);
                        }
                    }
                    break;
                case "Student":
                    break;
                default:
                    resultList = usersList.ToList();
                    break;
            }

            return resultList.AsQueryable();
        }

        public bool IsUserAuthorizedToViewRole(User user, string role)
        {
            var userRole = userServices.GetUserRoles(user.Id).First();

            switch (userRole.Name)
            {
                case "Administrator":
                    return true;
                case "Moderator":
                    if (role == "Administrator" || role == "Moderator")
                    {
                        return false;
                    }
                    break;
                case "Adviser":
                    if (role == "Administrator" || role == "Moderator")
                    {
                        return false;
                    }
                    break;
                case "Teacher":
                    if (role == "Administrator" || role == "Moderator"
                        || role == "Adviser")
                    {
                        return false;
                    }
                    break;
            }
            return true;
        }
    }
}