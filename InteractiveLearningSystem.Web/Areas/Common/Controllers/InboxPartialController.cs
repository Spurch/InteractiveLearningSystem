namespace InteractiveLearningSystem.Web.Areas.Common.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Microsoft.AspNet.Identity;
    using Services;

    public class InboxPartialController : BaseController
    {
        public InboxPartialController(MessageServices messageServices, RoleServices roleServices,
            UserServices userServices)
        {
            this.messageServices = messageServices;
            this.roleServices = roleServices;
            this.userServices = userServices;
        }

        public ActionResult InboxPartial()
        {
            var id = User.Identity.GetUserId();
            var messageCount = (from n in messageServices.GetAll()
                                where n.Receiver.Id == id && n.isViewed == false && n.isDeleted == false
                                select n).Count();
            var user = userServices.GetById(id);
            var role = roleServices.GetById(user.Roles.First().RoleId).Name;
            ViewData["NewMessages"] = messageCount;
            ViewData["Area"] = role;
            return PartialView("_InboxPartial");
        }
    }
}