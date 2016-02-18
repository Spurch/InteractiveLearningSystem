namespace InteractiveLearningSystem.Web.Areas.Administrator.Controllers
{
    using Admin.Controllers;
    using AutoMapper;
    using Infrastructure.Helpers;
    using InteractiveLearningSystem.Models;
    using InteractiveLearningSystem.Services;
    using Microsoft.AspNet.Identity;
    using Models;
    using System.Linq;
    using System.Web.Mvc;

    public class UsersController : BaseController
    {
        public UsersController(UserServices userServices, RoleServices roleServices, MessageServices messageServices, UsersFilter usersFilter)
        {
            this.roleServices = roleServices;
            this.userServices = userServices;
            this.messageServices = messageServices;
            this.usersFilter = usersFilter;
        }

        public ActionResult Index(string role)
        {
            var currentUserId = User.Identity.GetUserId();
            var currentUser = userServices.GetById(currentUserId);
            var RoleId = roleServices.GetByName(role);

            //if (role == null || RoleId == null)
            //{
            //    return Redirect("/");
            //}
            //else if (!usersFilter.IsUserAuthorizedToViewRole(currentUser, role))
            //{
            //    return View("~/Views/Shared/_Unauthorized.cshtml");
            //}

            ViewBag.RoleName = RoleId.Name;
            var users = (from u in userServices.GetAll()
                         where u.Roles.Any(r => r.RoleId == RoleId.Id)
                         select u);

            switch (role)
            {
                case "Moderator":
                    var result = this.Mapper.Map<ModeratorDetailsListView>(users);
                    return View(result);
                case "Adviser":
                    return View(Mapper.Map<AdviserDetailsListView>(usersFilter.GetUsersPerUser(currentUser, users)));
                case "Teacher":
                    return View(Mapper.Map<TeacherDetailsListView>(usersFilter.GetUsersPerUser(currentUser, users)));
                case "Student":
                    return View(Mapper.Map<StudentDetailsListView>(usersFilter.GetUsersPerUser(currentUser, users)));
            }

            return View(users);
        }
    }
}