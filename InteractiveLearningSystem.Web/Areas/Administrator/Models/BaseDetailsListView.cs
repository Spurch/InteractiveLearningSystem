namespace InteractiveLearningSystem.Web.Areas.Administrator.Models
{
    using System.ComponentModel.DataAnnotations;

    public class BaseDetailsListView
    {
        public string Id { get; set; }

        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Display(Name = "Avatar")]
        public string AvatarUrl { get; set; }

        [Display(Name = "Points")]
        public double Points { get; set; }

        [Display(Name = "Experience")]
        public double Experience { get; set; }

        [Display(Name = "Level")]
        public int Level { get; set; }

        public int? GroupId { get; set; }

        public string GroupName { get; set; }
    }
}