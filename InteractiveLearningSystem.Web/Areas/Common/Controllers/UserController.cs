namespace InteractiveLearningSystem.Web.Areas.Common.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Kendo.Mvc.UI;
    using Kendo.Mvc.Extensions;
    using Services;
    using Models;
    using Microsoft.AspNet.Identity;
    using Infrastructure.Helpers;
    using Administrator.Models;
    using Infrastructure.Mapping;
    using Administrator.Models.Users;
    public class UserController : BaseController
    {
        public UserController(UserServices userServices, RoleServices roleServices, MessageServices messageServices, UsersFilter usersFilter)
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

        //GET: Admin/User/Details/5
        public ActionResult Details(string id)
        {
            var user = userServices.GetById(id);
            var role = roleServices.GetById(user.Roles.First().RoleId);
            if (role.Name == "Moderator")
            {
                var school = user.Moderator.First();
                var userView = new UserDetailsAdminView
                {
                    Id = user.Id,
                    UserName = user.UserName,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Level = user.Level,
                    Experience = user.Experience,
                    Points = user.Points,
                    FaceBookUrl = user.FaceBookUrl,
                    GooglePlusUrl = user.GooglePlusUrl,
                    AvatarUrl = user.AvatarUrl,
                    GroupName = "",
                    GroupLevel = 0,
                    GroupExperience = 0,
                    GroupPoints = 0,
                    SchoolId = school.Id,
                    SchoolName = school.Name,
                    SchoolExperience = school.Experience,
                    SchoolLevel = school.Level,
                    SchoolPoints = school.Points
                };
                return View(userView);
            }
            else if (role.Name == "Adviser")
            {
                var school = user.Consultant.First();
                var userView = new UserDetailsAdminView
                {
                    Id = user.Id,
                    UserName = user.UserName,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Level = user.Level,
                    Experience = user.Experience,
                    Points = user.Points,
                    FaceBookUrl = user.FaceBookUrl,
                    GooglePlusUrl = user.GooglePlusUrl,
                    AvatarUrl = user.AvatarUrl,
                    GroupName = "",
                    GroupLevel = 0,
                    GroupExperience = 0,
                    GroupPoints = 0,
                    SchoolId = school.Id,
                    SchoolName = school.Name,
                    SchoolExperience = school.Experience,
                    SchoolLevel = school.Level,
                    SchoolPoints = school.Points
                };
                return View(userView);
            }
            else
            {
                var userView = new UserDetailsAdminView
                {
                    Id = user.Id,
                    UserName = user.UserName,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Level = user.Level,
                    Experience = user.Experience,
                    Points = user.Points,
                    FaceBookUrl = user.FaceBookUrl,
                    GooglePlusUrl = user.GooglePlusUrl,
                    AvatarUrl = user.AvatarUrl,
                    GroupId = user.GroupId,
                    GroupName = user.Group.Name,
                    GroupLevel = user.Group.Level,
                    GroupExperience = user.Group.Experience,
                    GroupPoints = user.Group.Points,
                    SchoolId = user.Group.SchoolId,
                    SchoolName = user.Group.School.Name,
                    SchoolExperience = user.Group.School.Experience,
                    SchoolLevel = user.Group.School.Level,
                    SchoolPoints = user.Group.School.Points
                };
                return View(userView);
            }
        }

        // GET: Admin/User/AddUser
        public ActionResult Add()
        {
            return View();
        }

        // POST: Admin/User/Add
        [HttpPost]
        public ActionResult Add(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
