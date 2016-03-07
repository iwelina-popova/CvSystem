namespace CvSystem.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using CvSystem.Common.ModelsConstants;
    using CvSystem.Data.Common.Models;

    public class Education : BaseModel<int>
    {
        private ICollection<Course> courses;

        public Education()
        {
            this.courses = new HashSet<Course>();
        }

        [Required]
        [MinLength(EducationConstants.SchoolMinLength)]
        [MaxLength(EducationConstants.SchoolMaxLength)]
        public string School { get; set; }

        public int From { get; set; }

        public int To { get; set; }

        public Degree Degree { get; set; }

        [MinLength(EducationConstants.FieldOfStudyMinLength)]
        [MaxLength(EducationConstants.FieldOfStudyMaxLength)]
        public string FieldOfStudy { get; set; }

        [MinLength(EducationConstants.DescriptionMinLength)]
        [MaxLength(EducationConstants.DescriptionMaxLength)]
        public string Description { get; set; }

        public int CvId { get; set; }

        public virtual CurriculumVitae Cv { get; set; }

        public virtual ICollection<Course> Courses
        {
            get { return this.courses; }
            set { this.courses = value; }
        }
    }
}
