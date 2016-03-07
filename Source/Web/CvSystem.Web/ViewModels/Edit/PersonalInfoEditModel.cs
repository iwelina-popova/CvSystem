namespace CvSystem.Web.ViewModels.Edit
{
    using System.ComponentModel.DataAnnotations;

    using CvSystem.Common.ErrorConstants;
    using CvSystem.Common.ModelsConstants;
    using CvSystem.Data.Models;
    using CvSystem.Web.Infrastructure.Mapping;

    public class PersonalInfoEditModel : IMapFrom<CurriculumVitae>, IMapTo<CurriculumVitae>
    {
        [Required]
        [StringLength(
            PersonalInfoConstants.NameMaxLength,
            ErrorMessage = ModelValidationError.ValidationErrorForRange,
            MinimumLength = PersonalInfoConstants.NameMinLength)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(
            PersonalInfoConstants.NameMaxLength,
            ErrorMessage = ModelValidationError.ValidationErrorForRange,
            MinimumLength = PersonalInfoConstants.NameMinLength)]
        public string LastName { get; set; }

        [StringLength(
            PersonalInfoConstants.AddressMaxLength,
            ErrorMessage = ModelValidationError.ValidationErrorForRange,
            MinimumLength = PersonalInfoConstants.AddressMinLength)]
        public string Address { get; set; }

        [StringLength(
            PersonalInfoConstants.AddressMaxLength,
            ErrorMessage = ModelValidationError.ValidationErrorForRange,
            MinimumLength = PersonalInfoConstants.AddressMinLength)]
        public string City { get; set; }

        [StringLength(
            PersonalInfoConstants.AddressMaxLength,
            ErrorMessage = ModelValidationError.ValidationErrorForRange,
            MinimumLength = PersonalInfoConstants.AddressMinLength)]
        public string Country { get; set; }

        [StringLength(
            PersonalInfoConstants.TelephoneMaxLength,
            ErrorMessage = ModelValidationError.ValidationErrorForRange,
            MinimumLength = PersonalInfoConstants.TelephoneMinLength)]
        public string Telephone { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [StringLength(
            SocialNetworkConstants.WebsiteMaxLength,
            ErrorMessage = ModelValidationError.ValidationErrorForRange,
            MinimumLength = SocialNetworkConstants.WebsiteMinLength)]
        public string Website { get; set; }

        [StringLength(
            SocialNetworkConstants.SkypeMaxLength,
            ErrorMessage = ModelValidationError.ValidationErrorForRange,
            MinimumLength = SocialNetworkConstants.SkypeMinLength)]
        public string Skype { get; set; }

        [StringLength(
            SocialNetworkConstants.FacebookMaxLength,
            ErrorMessage = ModelValidationError.ValidationErrorForRange,
            MinimumLength = SocialNetworkConstants.FacebookMinLength)]
        public string Facebook { get; set; }

        [StringLength(
            SocialNetworkConstants.LinkedInMaxLength,
            ErrorMessage = ModelValidationError.ValidationErrorForRange,
            MinimumLength = SocialNetworkConstants.LinkedInMinLength)]
        public string LinkedIn { get; set; }

        [StringLength(
            SocialNetworkConstants.GitHubMaxLength,
            ErrorMessage = ModelValidationError.ValidationErrorForRange,
            MinimumLength = SocialNetworkConstants.GitHubMinLength)]
        public string GitHub { get; set; }
    }
}
