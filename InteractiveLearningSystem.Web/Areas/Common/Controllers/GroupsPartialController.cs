namespace InteractiveLearningSystem.Web.Areas.Common.Controllers
{
    using System.Web.Mvc;
    using Models.Groups;
    using Services;

    public class GroupsPartialController : BaseController
    {
        public GroupsPartialController(MessageServices messageServices, RoleServices roleServices,
            UserServices userServices, SchoolServices schoolServices, GroupServices groupServices)
        {
            this.userServices = userServices;
            this.messageServices = messageServices;
            this.roleServices = roleServices;
            this.schoolServices = schoolServices;
            this.groupServices = groupServices;
        }


        public ActionResult GroupSnippetPartial(int groupId)
        {
            var group = groupServices.GetById(groupId);
            var groupSnippet = Mapper.Map<GroupSnippetViewModel>(group);

            return PartialView("_GroupSnippetPartial", groupSnippet);
        }
    }
}