namespace InteractiveLearningSystem.Web.Areas.Common.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Microsoft.AspNet.Identity;
    using Services;
    using Models;

    public class MessageController : BaseController
    {
        private static bool lastStatus;

        public MessageController(MessageServices messageServices, UserServices userServices)
        {
            this.messageServices = messageServices;
            this.userServices = userServices;
        }

        public ActionResult Index(bool status = false)
        {
            lastStatus = status;
            var id = User.Identity.GetUserId();
            var messages = from n in messageServices.GetAll()
                           where n.Receiver.Id == id && n.isViewed == status && n.isDeleted == false
                           select n;
            return View(messages);
        }

        public ActionResult Details(int id)
        {
            ViewData["Status"] = lastStatus;
            messageServices.UpdateViewedState(id, true);

            return View(messageServices.GetById(id));
        }

        public ActionResult Create()
        {
            var senderEmail = userServices.GetById(User.Identity.GetUserId()).Email;
            TempData["Sender"] = senderEmail;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MessageCreateViewModel message)
        {
            if (!ModelState.IsValid)
            {
                return View(message);
            }

            var receiver = userServices.GetByEmail(message.ReceiverEmail);
            var sender = userServices.GetById(User.Identity.GetUserId());

            if (receiver == sender)
            {
                ModelState.AddModelError("ReceiverEmail", "You cannot send e-mail to yourself!");
                return View(message);
            }

            messageServices.Create(sender.Id, receiver.Id, message.Title, message.Content, message.Flag, message.Notes);

            return Redirect("/");
        }

        public ActionResult Delete(int id)
        {
            messageServices.DeleteId(id);
            return Redirect("/");
        }
    }
}
