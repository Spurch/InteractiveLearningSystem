namespace InteractiveLearningSystem.Web.Controllers
{
    using System.Web.Mvc;

    [Authorize]
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public ActionResult About()
        {
            return View();
        }
    }
}