namespace InteractiveLearningSystem.Web.Areas.Common.Controllers
{
    using System.Linq;
    using System.Threading.Tasks;
    using System.Web.Mvc;
    using Microsoft.AspNet.Identity;
    using Models;
    using Services.Contracts;
    using Infrastructure.Helpers;
    public class MessageController : BaseController
    {
        private static bool lastStatus;

        public MessageController(IMessageServices messageServices, IUserServices userServices, IRoleServices roleServices)
            : base(userServices, messageServices, roleServices)
        {

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

        public ActionResult OutboxIndex()
        {
            var id = User.Identity.GetUserId();
            var messages = from n in messageServices.GetAll()
                           where n.Sender.Id == id
                           select n;
            return View(messages);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                throw new ResourceNotFoundException();
            }

            var userId = User.Identity.GetUserId();
            ViewData["Status"] = lastStatus;
            ViewData["User"] = userId; 
            messageServices.UpdateViewedState(id, true);
            var viewResult = Mapper.Map<MessageDetailsViewModel>(messageServices.GetById(id));
            return View(viewResult);
        }

        public ActionResult Create()
        {
            var senderEmail = userServices.GetById(User.Identity.GetUserId()).Email;
            TempData["Sender"] = senderEmail;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(MessageCreateViewModel message)
        {
            if (!ModelState.IsValid)
            {
                return View(message);
            }

            var receiver = userServices.GetByEmail(message.ReceiverEmail);
            var sender = User.Identity.GetUserId();

            if (receiver.Id == sender)
            {
                ModelState.AddModelError("ReceiverEmail", "You cannot send e-mail to yourself!");
                return View(message);
            }

            var newMessage = await messageServices.Create(sender, receiver.Id, message.Title, message.Content, message.Flag, message.Notes);

            return RedirectToAction("Index", "Message", new { status = lastStatus });
        }

        public ActionResult Delete(int id)
        {
            messageServices.DeleteId(id);
            return RedirectToAction("Index", "Message", new { status = lastStatus });
        }
    }
}
