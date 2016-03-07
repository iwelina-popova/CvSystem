namespace CvSystem.Web.ViewModels.Home
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using AutoMapper;

    using CvSystem.Data.Models;
    using CvSystem.Web.Infrastructure.Mapping;

    public class EducationViewModel : IMapFrom<Education>, IHaveCustomMappings
    {
        public string School { get; set; }

        public int From { get; set; }

        public int To { get; set; }

        public Degree Degree { get; set; }

        public string FieldOfStudy { get; set; }

        public string Description { get; set; }

        public IEnumerable<string> Courses { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<Education, EducationViewModel>()
                .ForMember(m => m.Courses, opt => opt.MapFrom(m => m.Courses.Where(c => !c.IsDeleted).Select(c => c.CourseName)));
        }
    }
}
