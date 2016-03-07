using System.Collections.Generic;

namespace CvSystem.Web.ViewModels.Edit
{
    public class CvEditModel
    {
        public PersonalInfoEditModel PersonalInfo { get; set; }

        public IList<EducationEditModel> Education { get; set; }

        public IList<CertificationEditModel> Certification { get; set; }
    }
}
