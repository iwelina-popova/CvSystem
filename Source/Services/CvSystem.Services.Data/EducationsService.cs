namespace CvSystem.Services.Data
{
    using System.Linq;

    using CvSystem.Data.Common;
    using CvSystem.Data.Models;
    using CvSystem.Services.Data.Contracts;

    public class EducationsService : IEducationsService
    {
        private readonly IDbRepository<Education> educations;

        public EducationsService(IDbRepository<Education> educations)
        {
            this.educations = educations;
        }

        public IQueryable<Education> GetByCvId(int cvId)
        {
            return this.educations
                .All()
                .Where(e => e.CvId == cvId)
                .OrderByDescending(e => e.From);
        }
    }
}
