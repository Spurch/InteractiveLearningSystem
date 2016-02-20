namespace InteractiveLearningSystem.Web.Areas.Common.Controllers
{
    using Infrastructure.Mapping;
    using Microsoft.AspNet.Identity;
    using Models.Schools;
    using Services;
    using System.Linq;
    using System.Web.Mvc;

    public class SearchPartialController : BaseController
    {
        public SearchPartialController(RoleServices roleServices,
            UserServices userServices, SchoolServices schoolServices)
        {
            this.userServices = userServices;
            this.roleServices = roleServices;
            this.schoolServices = schoolServices;
        }

        public ActionResult SearchPartial()
        {
            var id = User.Identity.GetUserId();
            var user = userServices.GetById(id);
            var roles = userServices.GetUserRoles(id);

            return PartialView("_SearchPartial", roles);
        }

        [HttpGet]
        public ActionResult SchoolAutocomplete(string text)
        {
            var result = schoolServices.GetAll()
                .Where(x => x.Name.ToLower()
                .Contains(text.ToLower()))
                .To<SchoolAutoCompleteView>()
                .ToArray();

            return this.Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}