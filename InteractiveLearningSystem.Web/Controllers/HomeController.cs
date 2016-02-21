namespace InteractiveLearningSystem.Web.Controllers
{
    using Infrastructure.Helpers;
    using System.Web.Mvc;

    [Authorize]
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public ActionResult About()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult PageNotFound()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Unauthorized()
        {
            return View();
        }
    }
}