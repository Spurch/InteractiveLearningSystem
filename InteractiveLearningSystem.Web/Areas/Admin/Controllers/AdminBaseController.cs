namespace InteractiveLearningSystem.Web.Areas.Admin.Controllers
{
    using Helpers;
    using System.Web.Mvc;

    [RoleAuthorize(Roles = "Administrator")]
    public class AdminBaseController : Controller
    {
    }
}