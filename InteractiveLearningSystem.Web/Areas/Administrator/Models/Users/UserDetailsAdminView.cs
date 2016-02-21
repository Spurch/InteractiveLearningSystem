namespace InteractiveLearningSystem.Web.Areas.Administrator.Models.Users
{
    using Infrastructure.Mapping;
    using InteractiveLearningSystem.Models;
    using System.ComponentModel.DataAnnotations;
    using AutoMapper;
    using System;

    public class UserDetailsAdminView : BaseDetailsListView, IMapFrom<User>, IHaveCustomMappings
    {
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Display(Name = "Facebook")]
        public string FaceBookUrl { get; set; }

        [Display(Name = "Google+")]
        public string GooglePlusUrl { get; set; }

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

        [Display(Name = "Guild")]
        public string SchoolName { get; set; }

        public int? SchoolId { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<User, UserDetailsAdminView>()
                .ForMember(x => x.SchoolName, opt => opt.MapFrom(x => x.Group.School.Name));
            configuration.CreateMap<User, UserDetailsAdminView>()
                .ForMember(x => x.SchoolId, opt => opt.MapFrom(x => x.Group.School.Id));
            configuration.CreateMap<User, UserDetailsAdminView>()
                .ForMember(x => x.GroupName, opt => opt.MapFrom(x => x.Group.Name));
            configuration.CreateMap<User, UserDetailsAdminView>()
                .ForMember(x => x.GroupId, opt => opt.MapFrom(x => x.Group.Id));

            configuration.CreateMap<User, UserDetailsAdminView>()
                .ForMember(x => x.SchoolLevel, opt => opt.MapFrom(x => x.Group.School.Level));
            configuration.CreateMap<User, UserDetailsAdminView>()
                .ForMember(x => x.SchoolPoints, opt => opt.MapFrom(x => x.Group.School.Points));
            configuration.CreateMap<User, UserDetailsAdminView>()
                .ForMember(x => x.SchoolExperience, opt => opt.MapFrom(x => x.Group.School.Experience));

            configuration.CreateMap<User, UserDetailsAdminView>()
                .ForMember(x => x.GroupLevel, opt => opt.MapFrom(x => x.Group.Level));
            configuration.CreateMap<User, UserDetailsAdminView>()
                .ForMember(x => x.GroupPoints, opt => opt.MapFrom(x => x.Group.Points));
            configuration.CreateMap<User, UserDetailsAdminView>()
                .ForMember(x => x.GroupExperience, opt => opt.MapFrom(x => x.Group.Experience));
        }
    }
}