namespace InteractiveLearningSystem.Web.Areas.Common.Models.Schools
{
    using System.ComponentModel.DataAnnotations;
    using InteractiveLearningSystem.Models;
    using InteractiveLearningSystem.Web.Infrastructure.Mapping;

    public class SchoolAutoCompleteView : IMapFrom<School>
    {
        public int Id { get; set; }

        [Display(Name = "Avatar")]
        public string AvatarUrl { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }
    }
}