namespace InteractiveLearningSystem.Web.Areas.Common.Models.Schools
{
    using System.ComponentModel.DataAnnotations;
    using Base;
    using InteractiveLearningSystem.Models;
    using Infrastructure.Mapping;
    public class SchoolSnippetViewModel : BaseSnippetViewModel, IMapFrom<School>
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }
    }
}
