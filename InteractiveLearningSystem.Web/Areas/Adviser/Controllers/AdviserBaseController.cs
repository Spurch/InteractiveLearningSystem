namespace InteractiveLearningSystem.Web.Areas.Adviser.Controllers
{
    using System.Web.Mvc;

    [Authorize(Roles = "Adviser")]
    public class AdviserBaseController : Controller
    {
    }
}