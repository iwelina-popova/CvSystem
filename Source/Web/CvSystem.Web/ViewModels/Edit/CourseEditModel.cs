namespace CvSystem.Web.ViewModels.Edit
{
    using System.ComponentModel.DataAnnotations;

    using CvSystem.Common.ErrorConstants;
    using CvSystem.Common.ModelsConstants;
    using CvSystem.Data.Models;
    using CvSystem.Web.Infrastructure.Mapping;

    public class CourseEditModel : IMapFrom<Course>, IMapTo<Course>
    {
        [Required]
        [StringLength(
            CourseConstants.CourseNameMaxLength,
            ErrorMessage = ModelValidationError.ValidationErrorForRange,
            MinimumLength = CourseConstants.CourseNameMinLength)]
        public string CourseName { get; set; }

        public bool IsDeleted { get; set; }
    }
}