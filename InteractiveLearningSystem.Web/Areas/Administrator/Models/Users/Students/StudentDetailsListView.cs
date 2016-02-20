namespace InteractiveLearningSystem.Web.Areas.Administrator.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;
    using AutoMapper;
    using Infrastructure.Mapping;
    using InteractiveLearningSystem.Models;

    public class StudentDetailsListView : BaseDetailsListView, IMapFrom<User>, IHaveCustomMappings
    {
        [Display(Name = "Guild")]
        public string SchoolName { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int SchoolId { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<User, StudentDetailsListView>()
               .ForMember(x => x.SchoolName, opt => opt.MapFrom(x => x.Group.School.Name));
            configuration.CreateMap<User, StudentDetailsListView>()
                .ForMember(x => x.SchoolId, opt => opt.MapFrom(x => x.Group.School.Id));
        }
    }
}