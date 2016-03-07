namespace CvSystem.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using CvSystem.Common.ModelsConstants;
    using CvSystem.Data.Common.Models;

    public class Certification : BaseModel<int>
    {
        [Required]
        [MinLength(CertificationConstants.NameMinLength)]
        [MaxLength(CertificationConstants.NameMaxLength)]
        public string CertificateName { get; set; }

        [Required]
        [MinLength(CertificationConstants.AuthorityMinLength)]
        [MaxLength(CertificationConstants.AuthorityMaxLength)]
        public string Authority { get; set; }

        [MinLength(CertificationConstants.NumberMinLength)]
        [MaxLength(CertificationConstants.NumberMaxLength)]
        public string LicenseNumber { get; set; }

        [Required]
        [MinLength(CertificationConstants.UrlMinLength)]
        [MaxLength(CertificationConstants.UrlMaxLength)]
        public string CertificateUrl { get; set; }

        public DateTime From { get; set; }

        public DateTime? To { get; set; }

        public int CvId { get; set; }

        public virtual CurriculumVitae Cv { get; set; }
    }
}
