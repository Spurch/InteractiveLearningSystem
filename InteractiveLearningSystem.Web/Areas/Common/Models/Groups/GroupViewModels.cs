namespace InteractiveLearningSystem.Web.Areas.Common.Models.Groups
{
    using System.ComponentModel.DataAnnotations;
    using Base;
    using Infrastructure.Mapping;
    using InteractiveLearningSystem.Models;

    public class GroupSnippetViewModel : BaseSnippetViewModel, IMapFrom<Group>
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }
    }
}
