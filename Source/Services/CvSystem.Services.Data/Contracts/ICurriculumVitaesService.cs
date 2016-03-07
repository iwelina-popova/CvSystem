namespace CvSystem.Services.Data.Contracts
{
    using System.Collections.Generic;
    using System.Linq;

    using CvSystem.Data.Models;

    public interface ICurriculumVitaesService
    {
        void AddCv(CurriculumVitae cv);

        IQueryable<CurriculumVitae> GetAll();

        IQueryable<CurriculumVitae> GetChoosen();

        CurriculumVitae GetById(int id);

        IQueryable<ICollection<Certification>> GetCertificationForCv(int id);

        IQueryable<ICollection<Education>> GetEducationForCv(int id);

        void Update();
    }
}
