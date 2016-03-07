namespace CvSystem.Web.ViewModels.Edit
{
    using System.Collections.Generic;

    public class CvEditModel
    {
        public PersonalInfoEditModel PersonalInfo { get; set; }

        public IList<EducationEditModel> Education { get; set; }

        public IList<CertificationEditModel> Certification { get; set; }
    }
}
