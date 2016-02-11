namespace InteractiveLearningSystem.Web.Areas.Admin.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Ninject;
    using Services;
    using Services.Contracts;
    using Models;
    using System.Collections.Generic;

    public class UserController : BaseController
    {

        [Inject]
        IUserServices userServices;

        [Inject]
        IRoleServices roleServices;

        public UserController(UserServices userServices, RoleServices roleServices)
        {
            this.roleServices = roleServices;
            this.userServices = userServices;
        }

        // GET: Admin/User
        public ActionResult Index(string role)
        {
            string name = "";
            int? id = 0;
            var RoleId = roleServices.GetByName(role);
            var users = from u in userServices.GetAll()
                        where u.Roles.Any(r => r.RoleId == RoleId.Id)
                        select u;
            var usersList = new List<UserListDetailsAdminView>();

            if (role == "Moderator")
            {    
                foreach (var user in users)
                {
                    name = user.Moderator.First().Name;
                    id = user.Moderator.First().Id;
                     
                    var newUser = new UserListDetailsAdminView
                    {
                        Id = user.Id,
                        AvatarUrl = user.AvatarUrl,
                        UserName = user.UserName,
                        Experience = user.Experience,
                        Level = user.Level,
                        Points = user.Points,
                        GroupName = "",
                        SchoolName = name,
                        SchoolId = id
                    };
                    usersList.Add(newUser);
                }
            }
            else if (role == "Adviser")
            {
                foreach (var user in users)
                {
                    name = user.Consultant.First().Name;
                    id = user.Consultant.First().Id;

                    var newUser = new UserListDetailsAdminView
                    {
                        Id = user.Id,
                        AvatarUrl = user.AvatarUrl,
                        UserName = user.UserName,
                        Experience = user.Experience,
                        Level = user.Level,
                        Points = user.Points,
                        GroupName = "",
                        SchoolName = name,
                        SchoolId = id
                    };
                    usersList.Add(newUser);
                }
            }
            else
            {
                foreach (var user in users)
                {
                    name = user.Group.School.Name;
                    id = user.Group.SchoolId;

                    var newUser = new UserListDetailsAdminView
                    {
                        Id = user.Id,
                        AvatarUrl = user.AvatarUrl,
                        UserName = user.UserName,
                        Experience = user.Experience,
                        Level = user.Level,
                        Points = user.Points,
                        GroupName = user.Group.Name,
                        GroupId = user.GroupId,
                        SchoolName = user.Group.School.Name,
                        SchoolId = user.Group.SchoolId
                    };
                    usersList.Add(newUser);
                }
            }

            ViewBag.RoleName = RoleId.Name;
            return View(usersList);
        }

        // GET: Admin/User/Details/5
        public ActionResult Details(string id)
        {
            var user = userServices.GetById(id);
            var role = roleServices.GetById(user.Roles.First().RoleId);
            if (role.Name == "Moderator")
            {
                var school = user.Moderator.First();
                var userView = new UserDetailsAdminView
                {
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
