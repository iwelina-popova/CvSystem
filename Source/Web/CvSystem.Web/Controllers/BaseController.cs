namespace CvSystem.Web.Controllers
{
    using System.Web.Mvc;

    using AutoMapper;

    using CvSystem.Services.Web;
    using CvSystem.Web.Infrastructure.Mapping;

    public abstract class BaseController : Controller
    {
        public ICacheService Cache { get; set; }

        protected IMapper Mapper
        {
            get
            {
                return AutoMapperConfig.Configuration.CreateMapper();
            }
        }
    }
}
