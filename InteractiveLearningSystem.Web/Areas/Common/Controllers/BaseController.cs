namespace InteractiveLearningSystem.Web.Areas.Common.Controllers
{
    using AutoMapper;
    using Infrastructure.Helpers;
    using Infrastructure.Mapping;
    using Ninject;
    using Services.Contracts;
    using System.Web.Mvc;

    [Authorize]
    [HandleResourceNotFound]
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

        protected IMapper Mapper
        {
            get
            {
                return AutoMapperConfig.Configuration.CreateMapper();
            }
        }
    }
}