namespace CvSystem.Web.ViewModels.Home
{
    using System.Collections.Generic;

    public class IndexViewModel
    {
        public CvViewModel PersonalInfo { get; set; }

        public IEnumerable<CertificationViewModel> Certificates { get; set; }

        public IEnumerable<EducationViewModel> Education { get; set; }
    }
}
