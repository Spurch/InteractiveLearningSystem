namespace InteractiveLearningSystem.Web.Areas.Administrator.Models.Schools
{
    using InteractiveLearningSystem.Models;
    using InteractiveLearningSystem.Web.Infrastructure.Mapping;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;
    using AutoMapper;

    public class SchoolDetailsAdminView : IMapFrom<School>, IHaveCustomMappings
    {
        public int Id { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(100)]
        public string Address { get; set; }

        [MinLength(2)]
        [MaxLength(100)]
        public string City { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(100)]
        public string Affinity { get; set; }

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

        public User Moderator { get; set; }

        public User Consultant { get; set; }

        public ICollection<Group> Groups { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<School, SchoolDetailsAdminView>()
                .ForMember(x => x.Groups, opt => opt.MapFrom(x => x.Groups.OrderByDescending(y => y.Level)));
        }
    }
}