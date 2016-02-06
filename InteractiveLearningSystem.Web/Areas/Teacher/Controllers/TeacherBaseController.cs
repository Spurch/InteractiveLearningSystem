namespace InteractiveLearningSystem.Web.Areas.Teacher.Controllers
{
    using Helpers;
    using System.Web.Mvc;

    [RoleAuthorize(Roles = "Teacher")]
    public class TeacherBaseController : Controller
    {
    }
}