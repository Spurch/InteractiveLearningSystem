namespace InteractiveLearningSystem.Web.Areas.Common.Controllers
{
    using System.Web.Mvc;
    using Models.Schools;
    using Services;

    public class SchoolsPartialController : BaseController
    {
        public SchoolsPartialController(MessageServices messageServices, RoleServices roleServices,
            UserServices userServices, SchoolServices schoolServices)
        {
            this.userServices = userServices;
            this.messageServices = messageServices;
            this.roleServices = roleServices;
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