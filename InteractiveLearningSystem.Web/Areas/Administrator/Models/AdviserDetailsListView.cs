namespace InteractiveLearningSystem.Web.Areas.Administrator.Models
{
    using Infrastructure.Mapping;
    using InteractiveLearningSystem.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;

    public class AdviserDetailsListView : BaseDetailsListView, IMapFrom<User>
    {
        public int SchoolId { get; set; }

        [Display(Name = "School")]
        public string SchoolName { get; set; }
    }
}