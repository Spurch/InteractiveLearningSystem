namespace InteractiveLearningSystem.Web.Areas.Administrator.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;
    using Infrastructure.Mapping;
    using InteractiveLearningSystem.Models;

    public class StudentDetailsListView : BaseDetailsListView, IMapFrom<User>
    {
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Display(Name = "Facebook")]
        public string FaceBookUrl { get; set; }

        [Display(Name = "Google+")]
        public string GooglePlusUrl { get; set; }

        [Display(Name = "Mobile")]
        public string Mobile { get; set; }

        [Display(Name = "Notes")]
        public string Notes { get; set; }

        [Display(Name = "Clan")]
        public string GroupName { get; set; }

        [Display(Name = "Points")]
        public double GroupPoints { get; set; }

        [Display(Name = "Experience")]
        public double GroupExperience { get; set; }

        [Display(Name = "Level")]
        public int GroupLevel { get; set; }

        [Display(Name = "Points")]
        public double SchoolPoints { get; set; }

        [Display(Name = "Experience")]
        public double SchoolExperience { get; set; }

        [Display(Name = "Level")]
        public int SchoolLevel { get; set; }

        [Display(Name = "Guild")]
        public string SchoolName { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int SchoolId { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int GroupId { get; set; }
    }
}