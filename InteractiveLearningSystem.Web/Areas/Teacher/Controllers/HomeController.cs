namespace InteractiveLearningSystem.Web.Areas.Teacher.Controllers
{
    using System.Web.Mvc;

    public class HomeController : BaseController
    {
        // GET: Teacher/Teacher
        public ActionResult Index()
        {
            return View();
        }
    }
}