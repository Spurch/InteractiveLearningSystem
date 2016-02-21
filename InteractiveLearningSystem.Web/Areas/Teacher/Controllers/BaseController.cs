namespace InteractiveLearningSystem.Web.Areas.Teacher.Controllers
{
    using System.Web.Mvc;
    using Helpers;
    using Infrastructure.Helpers;
    using Ninject;
    using Services.Contracts;

    [RoleAuthorize(Roles = "Teacher")]
    public class BaseController : Controller
    {
        [Inject]
        protected IMessageServices messageServices;
        [Inject]
        protected IRoleServices roleServices;
        [Inject]
        protected IUserServices userServices;
        [Inject]
        protected ISchoolServices schoolServices;
        [Inject]
        protected IUsersFilter usersFilter;
        [Inject]
        protected IGroupServices groupServices;
    }
}