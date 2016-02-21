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
            UserServices userServices, SchoolServices schoolServices, GroupServices groupServices)
        {
            this.userServices = userServices;
            this.roleServices = roleServices;
            this.schoolServices = schoolServices;
            this.groupServices = groupServices;
        }

        [HttpGet]
        public ActionResult SearchPartial()
        {
            var id = User.Identity.GetUserId();
            var user = userServices.GetById(id);
            var roles = userServices.GetUserRoles(id);
            if (roles.Any(x => x.Name == "Administrator"))
            {
                TempData["ViewField"] = "Name";
                TempData["Action"] = "SchoolAutocomplete";
                TempData["SearchFor"] = "School";
                TempData["Placeholder"] = "Search schools...";
            }
            else if (roles.Any(x => x.Name == "Moderator"))
            {
                TempData["ViewField"] = "UserName";
                TempData["Action"] = "UserAutocomplete";
                TempData["SearchFor"] = "User";
                TempData["Placeholder"] = "Search people...";
            }else if (roles.Any(x => x.Name == "Teacher"))
            {
                TempData["ViewField"] = "UserName";
                TempData["Action"] = "UserAutocomplete";
                TempData["SearchFor"] = "User";
                TempData["Placeholder"] = "Search students...";
            }
            else if (roles.Any(x => x.Name == "Adviser"))
            {
                TempData["ViewField"] = "Name";
                TempData["Action"] = "GroupAutocomplete";
                TempData["SearchFor"] = "Group";
                TempData["Placeholder"] = "Search groups...";
            }

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

        [HttpGet]
        public ActionResult GroupAutocomplete(string text)
        {
            var result = groupServices.GetAll()
                .Where(x => x.Name.ToLower()
                .Contains(text.ToLower()))
                .To<GroupAutoCompleteView>()
                .ToArray();

            return this.Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult UserAutocomplete(string text)
        {
            var result = userServices.GetAll()
                .Where(x => x.UserName.ToLower()
                .Contains(text.ToLower()))
                .To<UserAutoCompleteView>()
                .ToArray();

            return this.Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}