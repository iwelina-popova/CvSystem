namespace CvSystem.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using CvSystem.Data.Common;
    using CvSystem.Data.Models;
    using CvSystem.Services.Data.Contracts;

    public class CurriculumVitaesService : ICurriculumVitaesService
    {
        private readonly IDbRepository<CurriculumVitae> cvs;

        public CurriculumVitaesService(IDbRepository<CurriculumVitae> cvs)
        {
            this.cvs = cvs;
        }

        public void AddCv(CurriculumVitae cv)
        {
            this.cvs.Add(cv);
            this.cvs.SaveChanges();
        }

        public IQueryable<CurriculumVitae> GetAll()
        {
            return this.cvs
                .All()
                .OrderByDescending(cv => cv.CreatedOn);
        }

        public IQueryable<CurriculumVitae> GetChoosen()
        {
            return this.cvs
                .All()
                .Where(cv => cv.IsChoosen)
                .OrderByDescending(cv => cv.CreatedOn);
        }

        public CurriculumVitae GetById(int id)
        {
            return this.cvs.GetById(id);
        }

        public IQueryable<ICollection<Certification>> GetCertificationForCv(int id)
        {
            return this.cvs.All()
                .Where(cv => cv.Id == id)
                .Select(cv => cv.Certificates);
        }

        public IQueryable<ICollection<Education>> GetEducationForCv(int id)
        {
            return this.cvs.All()
                .Where(cv => cv.Id == id)
                .Select(cv => cv.Educations);
        }

        public void Update()
        {
            this.cvs.SaveChanges();
        }
    }
}
