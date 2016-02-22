namespace InteractiveLearningSystem.Web.Areas.Common.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Microsoft.AspNet.Identity;
    using Services;
    using Services.Contracts;
    public class InboxPartialController : BaseController
    {
        public InboxPartialController(IMessageServices messageServices, IRoleServices roleServices,
            IUserServices userServices)
            :base(userServices, messageServices, roleServices)
        {
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