namespace InteractiveLearningSystem.Web.Areas.Adviser.Controllers
{
    using System.Web.Mvc;

    public class IndexController : AdviserBaseController
    {
        // GET: Adviser/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}