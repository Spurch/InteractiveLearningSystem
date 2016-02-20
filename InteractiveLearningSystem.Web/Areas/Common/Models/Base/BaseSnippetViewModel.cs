namespace InteractiveLearningSystem.Web.Areas.Common.Models.Base
{
    using System.ComponentModel.DataAnnotations;

    public class BaseSnippetViewModel
    {
        [Display(Name = "Avatar")]
        public string AvatarUrl { get; set; }

        [Display(Name = "Points")]
        public double Points { get; set; }

        [Display(Name = "Experience")]
        public double Experience { get; set; }

        [Display(Name = "Level")]
        public int Level { get; set; }

    }
}
