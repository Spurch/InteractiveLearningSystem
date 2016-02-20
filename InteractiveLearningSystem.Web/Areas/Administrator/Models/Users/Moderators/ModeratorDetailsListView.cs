namespace InteractiveLearningSystem.Web.Areas.Administrator.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;
    using AutoMapper;
    using Infrastructure.Mapping;
    using InteractiveLearningSystem.Models;
    using System.Linq;
    public class ModeratorDetailsListView : BaseDetailsListView, IMapFrom<User>, IHaveCustomMappings
    {
        [HiddenInput(DisplayValue = false)]
        public int SchoolId { get; set; }

        [Display(Name = "School")]
        public string SchoolName { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<User, ModeratorDetailsListView>()
                .ForMember(x => x.SchoolName, opt => opt.MapFrom(x => x.Moderator.FirstOrDefault().Name));
            configuration.CreateMap<User, ModeratorDetailsListView>()
                .ForMember(x => x.SchoolId, opt => opt.MapFrom(x => x.Moderator.FirstOrDefault().Id));
        }
    }
}