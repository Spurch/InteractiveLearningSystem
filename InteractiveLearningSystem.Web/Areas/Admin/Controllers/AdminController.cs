namespace InteractiveLearningSystem.Web.Areas.Admin.Controllers
{
    using System.Web.Mvc;
    using InteractiveLearningSystem.Data;
    using System.Linq;
    public class AdminController : AdminBaseController
    {
        // GET: Admin/Admin
        public ActionResult Index()
        {
            var Users = InteractiveLearningSystemDbContext.Create().Users.ToList();
            return View(Users);
        }
    }
}