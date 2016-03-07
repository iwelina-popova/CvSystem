namespace CvSystem.Web.ViewModels.Add
{
    using System.ComponentModel.DataAnnotations;

    using CvSystem.Common.ErrorConstants;
    using CvSystem.Common.ModelsConstants;
    using CvSystem.Data.Models;
    using CvSystem.Web.Infrastructure.Mapping;

    public class CourseInputModel : IMapTo<Course>
    {
        [Required]
        [StringLength(
            CourseConstants.CourseNameMaxLength,
            ErrorMessage = ModelValidationError.ValidationErrorForRange,
            MinimumLength = CourseConstants.CourseNameMinLength)]
        [Display(Name = "Course name")]
        public string CourseName { get; set; }
    }
}
