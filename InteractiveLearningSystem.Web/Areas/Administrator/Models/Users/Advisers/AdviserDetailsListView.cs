namespace InteractiveLearningSystem.Web.Areas.Administrator.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;
    using Infrastructure.Mapping;
    using InteractiveLearningSystem.Models;
    using AutoMapper;
    using System.Linq;

    public class AdviserDetailsListView : BaseDetailsListView, IMapFrom<User>, IHaveCustomMappings
    {
        [HiddenInput(DisplayValue = false)]
        public int SchoolId { get; set; }

        [Display(Name = "School")]
        public string SchoolName { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<User, AdviserDetailsListView>()
                .ForMember(x => x.SchoolName, opt => opt.MapFrom(x => x.Consultant.FirstOrDefault().Name));
            configuration.CreateMap<User, AdviserDetailsListView>()
                .ForMember(x => x.SchoolId, opt => opt.MapFrom(x => x.Consultant.FirstOrDefault().Id));
        }
    }
}