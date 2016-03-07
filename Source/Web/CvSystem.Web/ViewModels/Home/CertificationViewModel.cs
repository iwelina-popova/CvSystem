namespace CvSystem.Web.ViewModels.Home
{
    using System;

    using CvSystem.Data.Models;
    using CvSystem.Web.Infrastructure.Mapping;

    public class CertificationViewModel : IMapFrom<Certification>
    {
        public string CertificateName { get; set; }

        public string Authority { get; set; }

        public string LicenseNumber { get; set; }

        public string CertificateUrl { get; set; }

        public DateTime From { get; set; }

        public DateTime? To { get; set; }
    }
}
