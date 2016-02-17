namespace InteractiveLearningSystem.Web.Areas.Administrator.Models
{
    using Infrastructure.Mapping;
    using InteractiveLearningSystem.Models;
    using System.ComponentModel.DataAnnotations;

    public class ModeratorDetailsListView : BaseDetailsListView, IMapFrom<User>
    {
        public int SchoolId { get; set; }

        [Display(Name = "School")]
        public string SchoolName { get; set; }
    }
}