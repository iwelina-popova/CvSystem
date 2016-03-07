namespace CvSystem.Services.Data.Contracts
{
    using System.Linq;

    using CvSystem.Data.Models;

    public interface IEducationsService
    {
        IQueryable<Education> GetByCvId(int cvId);
    }
}
