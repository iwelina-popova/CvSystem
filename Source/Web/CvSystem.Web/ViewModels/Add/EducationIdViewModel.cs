namespace CvSystem.Web.ViewModels.Add
{
    using CvSystem.Data.Models;
    using CvSystem.Web.Infrastructure.Mapping;

    public class EducationIdViewModel : IMapFrom<Education>
    {
        public int Id { get; set; }
    }
}
