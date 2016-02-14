namespace InteractiveLearningSystem.Models
{
    using Common;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GroupSnippetViewModel : BaseSnippetViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }
    }
}
