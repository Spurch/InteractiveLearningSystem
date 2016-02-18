namespace InteractiveLearningSystem.Web.Areas.Administrator.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;
    using Infrastructure.Mapping;
    using InteractiveLearningSystem.Models;

    public class ModeratorDetailsListView : BaseDetailsListView, IMapFrom<User>
    {
        [HiddenInput(DisplayValue = false)]
        public int SchoolId { get; set; }

        [Display(Name = "School")]
        public string SchoolName { get; set; }
    }
}