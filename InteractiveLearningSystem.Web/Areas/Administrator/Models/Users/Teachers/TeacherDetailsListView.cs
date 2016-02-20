namespace InteractiveLearningSystem.Web.Areas.Administrator.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;
    using AutoMapper;
    using Infrastructure.Mapping;
    using InteractiveLearningSystem.Models;

    public class TeacherDetailsListView : BaseDetailsListView, IMapFrom<User>, IHaveCustomMappings
    {
        [HiddenInput(DisplayValue = false)]
        public int SchoolId { get; set; }

        [Display(Name = "School")]
        public string SchoolName { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<User, TeacherDetailsListView>()
               .ForMember(x => x.SchoolName, opt => opt.MapFrom(x => x.Group.School.Name));
            configuration.CreateMap<User, TeacherDetailsListView>()
                .ForMember(x => x.SchoolId, opt => opt.MapFrom(x => x.Group.School.Id));
        }
    }
}