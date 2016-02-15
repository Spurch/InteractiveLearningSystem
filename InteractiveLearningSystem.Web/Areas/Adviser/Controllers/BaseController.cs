namespace InteractiveLearningSystem.Web.Areas.Adviser.Controllers
{
    using Infrastructure.Helpers;
    using Ninject;
    using Services.Contracts;
    using System.Web.Mvc;

    [Authorize(Roles = "Adviser")]
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