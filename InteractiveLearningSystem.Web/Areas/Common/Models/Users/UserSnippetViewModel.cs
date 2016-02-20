namespace InteractiveLearningSystem.Web.Areas.Common.Models.Users
{
    using Infrastructure.Mapping;
    using InteractiveLearningSystem.Models;
    using System.ComponentModel.DataAnnotations;

    public class UserSnippetViewModel: IMapFrom<User>
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
    }
}