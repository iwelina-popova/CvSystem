namespace CvSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using CvSystem.Common.ModelsConstants;
    using CvSystem.Data.Common.Models;

    public class Course : BaseModel<int>
    {
        [Required]
        [MinLength(CourseConstants.CourseNameMinLength)]
        [MaxLength(CourseConstants.CourseNameMaxLength)]
        public string CourseName { get; set; }
    }
}
