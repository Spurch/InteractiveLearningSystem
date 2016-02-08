namespace InteractiveLearningSystem.Web.Areas.Teacher.Controllers
{
    using System.Web.Mvc;

    public class IndexController : TeacherBaseController
    {
        // GET: Teacher/Teacher
        public ActionResult Index()
        {
            return View();
        }
    }
}