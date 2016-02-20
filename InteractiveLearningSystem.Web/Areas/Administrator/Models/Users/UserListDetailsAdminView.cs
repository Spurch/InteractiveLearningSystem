namespace InteractiveLearningSystem.Web.Areas.Administrator.Models.Users
{
    using System.ComponentModel.DataAnnotations;

    public class UserListDetailsAdminView
    {
        public string Id { get; set; }

        [Display(Name = "Avatar")]
        public string AvatarUrl { get; set; }

        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Display(Name = "Points")]
        public double Points { get; set; }

        [Display(Name = "Experience")]
        public double Experience { get; set; }

        [Display(Name = "Level")]
        public int Level { get; set; }

        [Display(Name = "Guild")]
        public string SchoolName { get; set; }

        public int? SchoolId { get; set; }

        [Display(Name = "Clan")]
        public string GroupName { get; set; }

        public int? GroupId { get; set; }
    }
}