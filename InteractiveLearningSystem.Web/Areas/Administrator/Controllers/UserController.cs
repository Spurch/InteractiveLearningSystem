﻿namespace InteractiveLearningSystem.Web.Areas.Administrator.Controllers
{
    using Admin.Controllers;
    using Infrastructure.Helpers;
    using Infrastructure.Mapping;
    using Services;
    using Kendo.Mvc.Extensions;
    using Kendo.Mvc.UI;
    using Microsoft.AspNet.Identity;
    using Models;
    using System.Linq;
    using System.Web.Mvc;

    public class UserController : BaseController
    {
        public UserController(UserServices userServices, RoleServices roleServices, MessageServices messageServices, UsersFilter usersFilter)
        {
            this.roleServices = roleServices;
            this.userServices = userServices;
            this.messageServices = messageServices;
            this.usersFilter = usersFilter;
        }

        public ActionResult Index(string role = "")
        {
            var currentUserId = User.Identity.GetUserId();
            var currentUser = userServices.GetById(currentUserId);

            if (!usersFilter.IsUserAuthorizedToViewRole(currentUser, role))
            {
                return View("~/Views/Shared/_Unauthorized.cshtml");
            }
            else
            {
                switch (role)
                {
                    case "Moderator":
                        return RedirectToAction("Moderator");
                    case "Adviser":
                        return RedirectToAction("Adviser");
                    case "Teacher":
                        return RedirectToAction("Teacher");
                    case "Student":
                        return RedirectToAction("Student");
                }
            }

            return View();
        }

        public ActionResult Moderator()
        {
            return View();
        }

        public ActionResult Adviser()
        {
            return View();
        }

        public ActionResult Teacher()
        {
            return View();
        }

        public ActionResult Student()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Read([DataSourceRequest]DataSourceRequest request, string role)
        {
            var RoleId = roleServices.GetByName(role);
            var users = (from u in userServices.GetAll()
                         where u.Roles.Any(r => r.RoleId == RoleId.Id)
                         select u);
            switch (role)
            {
                case "Moderator":
                    var result = users.To<ModeratorDetailsListView>()
               .ToDataSourceResult(request);
                    return this.Json(result);
                case "Adviser":
                    result = users.To<AdviserDetailsListView>()
               .ToDataSourceResult(request);
                    return this.Json(result);
                case "Teacher":
                    result = users.To<TeacherDetailsListView>()
               .ToDataSourceResult(request);
                    return this.Json(result);
                case "Student":
                    result = users.To<StudentDetailsListView>()
               .ToDataSourceResult(request);
                    return this.Json(result);
            }
            return View("Index");
        }
    }
}