namespace InteractiveLearningSystem.Web.Areas.Common.Controllers
{
    using System.Web.Mvc;
    using Models.Groups;
    using Services;
    using Services.Contracts;
    public class GroupsPartialController : BaseController
    {
        public GroupsPartialController(IMessageServices messageServices, IRoleServices roleServices,
            IUserServices userServices, SchoolServices schoolServices, GroupServices groupServices)
            :base(userServices, messageServices, roleServices)
        {
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