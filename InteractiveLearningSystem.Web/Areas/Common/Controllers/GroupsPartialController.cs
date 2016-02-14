namespace InteractiveLearningSystem.Web.Areas.Common.Controllers
{
    using Models;
    using Services;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

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
            var groupSnippet = new GroupSnippetViewModel
            {
                Id = group.Id,
                Name = group.Name,
                AvatarUrl = group.AvatarUrl,
                Points = group.Points,
                Experience = group.Experience,
                Level = group.Level,
            };
            return PartialView("_GroupSnippetPartial", groupSnippet);
        }
    }
}