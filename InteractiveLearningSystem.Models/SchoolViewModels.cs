namespace InteractiveLearningSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SchoolSnippetViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Avatar")]
        public string AvatarUrl { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Points")]
        public double Points { get; set; }

        [Display(Name = "Experience")]
        public double Experience { get; set; }

        [Display(Name = "Level")]
        public int Level { get; set; }

    }
}
