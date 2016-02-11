using InteractiveLearningSystem.Services;
using InteractiveLearningSystem.Services.Contracts;
using Microsoft.AspNet.Identity;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InteractiveLearningSystem.Web.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        [Inject]
        IMessageServices messageServices;
        [Inject]
        IRoleServices roleServices;
        [Inject]
        IUserServices userServices;

        public HomeController(MessageServices messageServices, RoleServices roleServices,
            UserServices userServices)
        {
            this.userServices = userServices;
            this.roleServices = roleServices;
            this.messageServices = messageServices;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult InboxPartial()
        {
            var id = User.Identity.GetUserId();
            var messageCount = (from n in messageServices.GetAll()
                                where n.Receiver.Id == id && n.isViewed == false
                                select n).Count();
            var user = userServices.GetById(id);
            var role = roleServices.GetById(user.Roles.First().RoleId).Name;
            ViewData["NewMessages"] = messageCount;
            ViewData["Area"] = role;
            return PartialView("_InboxPartial");
        }

        public ActionResult UsersPartial(string currentUser)
        {
            var roleId = userServices.GetById(currentUser).Roles.First().RoleId;
            var roleName = roleServices.GetById(roleId).Name;
            var roles = roleServices.GetAllRolesExcluding(roleName);

            return PartialView("_UsersPartial", roles);
        }
    }
}