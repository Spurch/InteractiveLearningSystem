namespace InteractiveLearningSystem.Web.Areas.Administrator.Models.Users
{
    using Infrastructure.Mapping;
    using InteractiveLearningSystem.Models;
    using System.ComponentModel.DataAnnotations;
    using AutoMapper;
    using System;
    using System.Web.Mvc;
    using System.Linq;
    public class ModeratorDetailsAdminView : BaseDetailsListView, IMapFrom<User>, IHaveCustomMappings
    {
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Display(Name = "Facebook")]
        public string FaceBookUrl { get; set; }

        [Display(Name = "Google+")]
        public string GooglePlusUrl { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Notes")]
        public string Notes { get; set; }

        [Display(Name = "Points")]
        public double GroupPoints { get; set; }

        [Display(Name = "Experience")]
        public double GroupExperience { get; set; }

        [Display(Name = "Level")]
        public int GroupLevel { get; set; }

        [Display(Name = "Points")]
        public double SchoolPoints { get; set; }

        [Display(Name = "Experience")]
        public double SchoolExperience { get; set; }

        [Display(Name = "Level")]
        public int SchoolLevel { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int SchoolId { get; set; }

        [Display(Name = "School")]
        public string SchoolName { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<User, ModeratorDetailsAdminView>()
                .ForMember(x => x.SchoolName, opt => opt.MapFrom(x => x.Moderator.FirstOrDefault().Name));
            configuration.CreateMap<User, ModeratorDetailsAdminView>()
                .ForMember(x => x.SchoolId, opt => opt.MapFrom(x => x.Moderator.FirstOrDefault().Id));

            configuration.CreateMap<User, ModeratorDetailsAdminView>()
                .ForMember(x => x.SchoolLevel, opt => opt.MapFrom(x => x.Moderator.FirstOrDefault().Level));
            configuration.CreateMap<User, ModeratorDetailsAdminView>()
                .ForMember(x => x.SchoolPoints, opt => opt.MapFrom(x => x.Moderator.FirstOrDefault().Points));
            configuration.CreateMap<User, ModeratorDetailsAdminView>()
                .ForMember(x => x.SchoolExperience, opt => opt.MapFrom(x => x.Moderator.FirstOrDefault().Experience));
        }
    }
}