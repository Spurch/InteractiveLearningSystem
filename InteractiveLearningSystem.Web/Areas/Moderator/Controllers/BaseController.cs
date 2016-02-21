namespace InteractiveLearningSystem.Web.Areas.Moderator.Controllers
{
    using Helpers;
    using System.Web.Mvc;

    [RoleAuthorize(Roles = "Moderator")]
    public class BaseController : Controller
    {

    }
}