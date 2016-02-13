namespace InteractiveLearningSystem.Web.Areas.Common.Controllers
{
    using Models;
    using Services;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

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
            var schoolSnippet = new SchoolSnippetViewModel
            {
                Id = school.Id,
                Name = school.Name,
                AvatarUrl = school.AvatarUrl,
                Points = school.Points,
                Experience = school.Experience,
                Level = school.Level,
            };
            return PartialView("_SchoolSnippetPartial", schoolSnippet);
        }
    }
}