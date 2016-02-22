namespace InteractiveLearningSystem.Web.Areas.Common.Controllers
{
    using System.Web.Mvc;
    using Models.Schools;
    using Services;
    using Services.Contracts;

    public class SchoolsPartialController : BaseController
    {
        public SchoolsPartialController(IMessageServices messageServices, IRoleServices roleServices,
            IUserServices userServices, SchoolServices schoolServices)
            :base(userServices, messageServices, roleServices)
        {
            this.schoolServices = schoolServices;
        }
        

        public ActionResult SchoolSnippetPartial(int schoolId)
        {
            var school = schoolServices.GetById(schoolId);
            var schoolSnippet = Mapper.Map<SchoolSnippetViewModel>(school);

            return PartialView("_SchoolSnippetPartial", schoolSnippet);
        }
    }
}