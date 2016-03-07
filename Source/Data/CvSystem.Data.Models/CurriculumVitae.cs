namespace CvSystem.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using CvSystem.Common.ModelsConstants;
    using CvSystem.Data.Common.Models;

    public class CurriculumVitae : BaseModel<int>
    {
        private ICollection<Certification> certificates;
        private ICollection<Education> educations;

        public CurriculumVitae()
        {
            this.certificates = new HashSet<Certification>();
            this.educations = new HashSet<Education>();
        }

        public bool IsChoosen { get; set; }

        [Required]
        [MinLength(PersonalInfoConstants.NameMinLength)]
        [MaxLength(PersonalInfoConstants.NameMaxLength)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(PersonalInfoConstants.NameMinLength)]
        [MaxLength(PersonalInfoConstants.NameMaxLength)]
        public string LastName { get; set; }

        [Required]
        [MinLength(PersonalInfoConstants.AddressMinLength)]
        [MaxLength(PersonalInfoConstants.AddressMaxLength)]
        public string Address { get; set; }

        [Required]
        [MinLength(PersonalInfoConstants.AddressMinLength)]
        [MaxLength(PersonalInfoConstants.AddressMaxLength)]
        public string City { get; set; }

        [Required]
        [MinLength(PersonalInfoConstants.AddressMinLength)]
        [MaxLength(PersonalInfoConstants.AddressMaxLength)]
        public string Country { get; set; }

        [Required]
        [MinLength(PersonalInfoConstants.TelephoneMinLength)]
        [MaxLength(PersonalInfoConstants.TelephoneMaxLength)]
        public string Telephone { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [MinLength(SocialNetworkConstants.WebsiteMinLength)]
        [MaxLength(SocialNetworkConstants.WebsiteMaxLength)]
        public string Website { get; set; }

        [MinLength(SocialNetworkConstants.SkypeMinLength)]
        [MaxLength(SocialNetworkConstants.SkypeMaxLength)]
        public string Skype { get; set; }

        [MinLength(SocialNetworkConstants.FacebookMinLength)]
        [MaxLength(SocialNetworkConstants.FacebookMaxLength)]
        public string Facebook { get; set; }

        [MinLength(SocialNetworkConstants.LinkedInMinLength)]
        [MaxLength(SocialNetworkConstants.LinkedInMaxLength)]
        public string LinkedIn { get; set; }

        [MinLength(SocialNetworkConstants.GitHubMinLength)]
        [MaxLength(SocialNetworkConstants.GitHubMaxLength)]
        public string GitHub { get; set; }

        public virtual ICollection<Certification> Certificates
        {
            get { return this.certificates; }
            set { this.certificates = value; }
        }

        public virtual ICollection<Education> Educations
        {
            get { return this.educations; }
            set { this.educations = value; }
        }
    }
}
