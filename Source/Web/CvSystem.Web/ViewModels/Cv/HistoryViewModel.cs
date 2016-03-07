namespace CvSystem.Web.ViewModels.Cv
{
    using System;

    using CvSystem.Data.Models;
    using CvSystem.Web.Infrastructure.Mapping;

    public class HistoryViewModel : IMapFrom<CurriculumVitae>
    {
        public int Id { get; set; }

        public bool IsChoosen { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
