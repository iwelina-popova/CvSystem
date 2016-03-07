namespace CvSystem.Web.ViewModels.Home
{
    using CvSystem.Data.Models;
    using CvSystem.Web.Infrastructure.Mapping;

    public class CvViewModel : IMapFrom<CurriculumVitae>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string Telephone { get; set; }

        public string Email { get; set; }

        public string Website { get; set; }

        public string Skype { get; set; }

        public string Facebook { get; set; }

        public string LinkedIn { get; set; }

        public string GitHub { get; set; }
    }
}
