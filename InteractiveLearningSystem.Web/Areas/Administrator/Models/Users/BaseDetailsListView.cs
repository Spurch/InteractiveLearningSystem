namespace InteractiveLearningSystem.Web.Areas.Administrator.Models
{
    using Infrastructure.Helpers;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public class BaseDetailsListView
    {
        ISanitizer sanitizer;
        public BaseDetailsListView()
        {
            sanitizer = new HtmlSanitizerAdapter();
        }

        [HiddenInput(DisplayValue = false)]
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

        [Display(Name = "Notes")]
        [DataType(DataType.MultilineText)]
        [AllowHtml]
        public string Notes { get; set; }

        public int? GroupId { get; set; }

        [Display(Name = "Clan")]
        public string GroupName { get; set; }

        public string sanitizedNotes
        {
            get
            {
                return this.sanitizer.Sanitize(this.Notes);
            }
        }
    }
}