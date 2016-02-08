namespace InteractiveLearningSystem.Web.Areas.Moderator.Controllers
{
    using System.Web.Mvc;

    public class IndexController : ModeratorBaseController
    {
        // GET: Moderator/Moderator
        public ActionResult Index()
        {
            return View();
        }
    }
}