namespace CvSystem.Web.ViewModels.Add
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using CvSystem.Common.ErrorConstants;
    using CvSystem.Common.ModelsConstants;
    using CvSystem.Data.Models;
    using CvSystem.Web.Infrastructure.Mapping;

    public class EducationInputModel : IMapTo<Education>
    {
        [Required]
        [StringLength(
            EducationConstants.SchoolMaxLength,
            ErrorMessage = ModelValidationError.ValidationErrorForRange,
            MinimumLength = EducationConstants.SchoolMinLength)]
        public string School { get; set; }

        [Required]
        public int From { get; set; }

        [Required]
        public int To { get; set; }

        public Degree Degree { get; set; }

        [StringLength(
            EducationConstants.FieldOfStudyMaxLength,
            ErrorMessage = ModelValidationError.ValidationErrorForRange,
            MinimumLength = EducationConstants.FieldOfStudyMinLength)]
        public string FieldOfStudy { get; set; }

        [StringLength(
            EducationConstants.DescriptionMaxLength,
            ErrorMessage = ModelValidationError.ValidationErrorForRange,
            MinimumLength = EducationConstants.DescriptionMinLength)]
        public string Description { get; set; }
    }
}
