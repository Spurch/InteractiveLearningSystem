namespace InteractiveLearningSystem.Web.Areas.Common.Models.Schools
{
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;
    using InteractiveLearningSystem.Models;
    using InteractiveLearningSystem.Web.Infrastructure.Mapping;

    public class UserAutoCompleteView : IMapFrom<User>
    {
        [HiddenInput(DisplayValue = false)]
        public string Id { get; set; }

        [Display(Name = "Avatar")]
        public string AvatarUrl { get; set; }

        [Display(Name = "Name")]
        public string UserName { get; set; }
    }
}