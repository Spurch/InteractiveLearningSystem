namespace InteractiveLearningSystem.Web.Areas.Common.Controllers
{
    using InteractiveLearningSystem.Services;
    using Microsoft.AspNet.Identity;
    using Models;
    using Models.Users;
    using System.Linq;
    using System.Web.Mvc;

    public class UsersPartialController : BaseController
    {
        public UsersPartialController(MessageServices messageServices, RoleServices roleServices,
            UserServices userServices)
        {
            this.userServices = userServices;
            this.messageServices = messageServices;
            this.roleServices = roleServices;
        }

        public ActionResult HomePartial()
        {
            var currentUser = User.Identity.GetUserId();
            var roleId = userServices.GetById(currentUser).Roles.First().RoleId;
            var roleName = roleServices.GetById(roleId).Name;

            ViewData["Role"] = roleName;
            return PartialView("_HomePartial");
        }

        public ActionResult UserSnippetPartial(string userId)
        {
            var currentUser = userServices.GetById(userId);
            var userSnippet = Mapper.Map<UserSnippetViewModel>(currentUser);

            return PartialView("_UserSnippetPartial", userSnippet);
        }

        public ActionResult UsersPartial()
        {
            var currentUser = User.Identity.GetUserId();
            var roleId = userServices.GetById(currentUser).Roles.First().RoleId;
            var roleName = roleServices.GetById(roleId).Name;
            var roles = roleServices.GetAllRolesExcluding(roleName);

            ViewData["Role"] = roleName;
            return PartialView("_UsersPartial", roles);
        }

        public ActionResult RolesPartial(string role)
        {
            ViewData["Role"] = role;
            return PartialView("_RolesPartial");
        }
    }
}