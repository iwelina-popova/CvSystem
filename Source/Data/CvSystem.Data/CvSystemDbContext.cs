namespace CvSystem.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    using CvSystem.Data.Common.Models;
    using CvSystem.Data.Models;

    public class CvSystemDbContext : DbContext
    {
        public CvSystemDbContext()
            : base("DefaultConnection")
        {
        }

        public IDbSet<CurriculumVitae> CurriculumVitaes { get; set; }

        public IDbSet<Certification> Certifications { get; set; }

        public IDbSet<Education> Educations { get; set; }

        public static CvSystemDbContext Create()
        {
            return new CvSystemDbContext();
        }

        public override int SaveChanges()
        {
            this.ApplyAuditInfoRules();
            return base.SaveChanges();
        }

        private void ApplyAuditInfoRules()
        {
            // Approach via @julielerman: http://bit.ly/123661P
            foreach (var entry in
                this.ChangeTracker.Entries()
                    .Where(
                        e =>
                        e.Entity is IAuditInfo && ((e.State == EntityState.Added) || (e.State == EntityState.Modified))))
            {
                var entity = (IAuditInfo)entry.Entity;
                if (entry.State == EntityState.Added && entity.CreatedOn == default(DateTime))
                {
                    entity.CreatedOn = DateTime.Now;
                }
                else
                {
                    entity.ModifiedOn = DateTime.Now;
                }
            }
        }
    }
}
