namespace InteractiveLearningSystem.Web.Areas.Admin.Controllers
{
    using System.Web.Mvc;

    [Authorize(Roles = "Administrator")]
    public class BaseController : Controller
    {
    }
}