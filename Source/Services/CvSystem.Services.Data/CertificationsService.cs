namespace CvSystem.Services.Data
{
    using System.Linq;

    using CvSystem.Data.Common;
    using CvSystem.Data.Models;
    using CvSystem.Services.Data.Contracts;

    public class CertificationsService : ICertificationsService
    {
        private readonly IDbRepository<Certification> certifications;

        public CertificationsService(IDbRepository<Certification> certifications)
        {
            this.certifications = certifications;
        }

        public IQueryable<Certification> GetByCvId(int cvId)
        {
            return this.certifications
                .All()
                .Where(c => c.CvId == cvId);
        }
    }
}
