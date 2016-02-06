namespace InteractiveLearningSystem.Web.Areas.Admin.Controllers
{
    using System.Web.Mvc;
   
    public class AdminController : AdminBaseController
    {
        // GET: Admin/Admin
        public ActionResult Index()
        {
            return View();
        }
    }
}