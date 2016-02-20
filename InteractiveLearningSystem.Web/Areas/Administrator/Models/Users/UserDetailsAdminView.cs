namespace InteractiveLearningSystem.Web.Areas.Administrator.Models.Users
{
    using Infrastructure.Mapping;
    using InteractiveLearningSystem.Models;
    using System.ComponentModel.DataAnnotations;
    using AutoMapper;
    using System;

    public class UserDetailsAdminView : BaseDetailsListView, IMapFrom<User>
    {
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Display(Name = "Facebook")]
        public string FaceBookUrl { get; set; }

        [Display(Name = "Google+")]
        public string GooglePlusUrl { get; set; }

        [Display(Name = "Notes")]
        public string Notes { get; set; }

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

        public int? SchoolId { get; set; }
    }
}