namespace CvSystem.Web.ViewModels.Edit
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using AutoMapper;
    using CvSystem.Common.ErrorConstants;
    using CvSystem.Common.ModelsConstants;
    using CvSystem.Data.Models;
    using CvSystem.Web.Infrastructure.Mapping;

    public class CertificationEditModel : IMapFrom<Certification>, IMapTo<Certification>
    {
        [Required]
        [StringLength(
            CertificationConstants.NameMaxLength,
            ErrorMessage = ModelValidationError.ValidationErrorForRange,
            MinimumLength = CertificationConstants.NameMinLength)]
        [Display(Name = "Name")]
        public string CertificateName { get; set; }

        [Required]
        [StringLength(
            CertificationConstants.AuthorityMaxLength,
            ErrorMessage = ModelValidationError.ValidationErrorForRange,
            MinimumLength = CertificationConstants.AuthorityMinLength)]
        public string Authority { get; set; }

        [StringLength(
            CertificationConstants.NumberMaxLength,
            ErrorMessage = ModelValidationError.ValidationErrorForRange,
            MinimumLength = CertificationConstants.NumberMinLength)]
        public string LicenseNumber { get; set; }

        [StringLength(
            CertificationConstants.UrlMaxLength,
            ErrorMessage = ModelValidationError.ValidationErrorForRange,
            MinimumLength = CertificationConstants.UrlMinLength)]
        [Display(Name = "Url")]
        public string CertificateUrl { get; set; }

        public DateTime From { get; set; }

        public DateTime? To { get; set; }
    }
}
