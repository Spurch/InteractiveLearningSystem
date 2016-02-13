namespace InteractiveLearningSystem.Web.Areas.Common.Controllers
{
    using InteractiveLearningSystem.Services;
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

        public ActionResult UsersPartial(string currentUser)
        {
            var roleId = userServices.GetById(currentUser).Roles.First().RoleId;
            var roleName = roleServices.GetById(roleId).Name;
            var roles = roleServices.GetAllRolesExcluding(roleName);

            return PartialView("_UsersPartial", roles);
        }
    }
}