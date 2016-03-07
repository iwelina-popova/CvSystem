namespace CvSystem.Services.Data.Contracts
{
    using System.Linq;

    using CvSystem.Data.Models;

    public interface ICertificationsService
    {
        IQueryable<Certification> GetByCvId(int cvId);
    }
}
