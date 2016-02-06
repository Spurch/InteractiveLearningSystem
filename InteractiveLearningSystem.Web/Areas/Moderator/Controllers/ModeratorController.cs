namespace InteractiveLearningSystem.Web.Areas.Moderator.Controllers
{
    using System.Web.Mvc;

    public class ModeratorController : ModeratorBaseController
    {
        // GET: Moderator/Moderator
        public ActionResult Index()
        {
            return View();
        }
    }
}