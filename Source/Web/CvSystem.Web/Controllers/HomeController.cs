namespace CvSystem.Web.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;

    using CvSystem.Data.Models;
    using CvSystem.Services.Data.Contracts;
    using CvSystem.Web.Infrastructure.Mapping;
    using CvSystem.Web.ViewModels.Add;
    using CvSystem.Web.ViewModels.Cv;
    using CvSystem.Web.ViewModels.Edit;
    using CvSystem.Web.ViewModels.Home;

    public class HomeController : BaseController
    {
        private readonly ICurriculumVitaesService cvs;
        private readonly ICertificationsService certifications;
        private readonly IEducationsService educations;

        public HomeController(
            ICurriculumVitaesService cvs,
            ICertificationsService certifications,
            IEducationsService educations)
        {
            this.cvs = cvs;
            this.certifications = certifications;
            this.educations = educations;
        }

        public ActionResult Index()
        {
            var cv = this.cvs.GetChoosen().FirstOrDefault();

            if (cv == null)
            {
                return this.View(new IndexViewModel());
            }

            var viewModel = this.GetIndexModel(cv);

            return this.View(viewModel);
        }

        public ActionResult CvsHistory()
        {
            var allCvs = this.cvs.GetAll()
                .To<HistoryViewModel>()
                .ToList();

            return this.View(allCvs);
        }

        [HttpGet]
        public ActionResult CreateCv(int? id)
        {
            if (id == null)
            {
                return this.RedirectToAction("Index");
            }

            int idInt = id ?? 1;
            var cv = this.cvs.GetById(idInt);
            var personal = this.Mapper.Map<CurriculumVitae, PersonalInfoEditModel>(cv);
            var education = this.educations
                .GetByCvId(idInt)
                .To<EducationEditModel>()
                .ToList();
            var certificates = this.certifications
                .GetByCvId(idInt)
                .To<CertificationEditModel>()
                .ToList();

            var viewModel = new CvEditModel()
            {
                PersonalInfo = personal,
                Education = education,
                Certification = certificates
            };

            return this.View(viewModel);
        }

        /// <summary>
        /// Create new CV and set it to the main page.
        /// </summary>
        /// <param name="model">The model that represent necessary data for creating new CV.</param>
        /// <returns>Redirect to main page.</returns>
        [HttpPost]
        public ActionResult CreateCv(CvEditModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            var newCv = this.Mapper.Map<CurriculumVitae>(model.PersonalInfo);

            var newEducations = new List<Education>();
            foreach (var education in model.Education)
            {
                newEducations.Add(this.Mapper.Map<Education>(education));
            }

            var newCertifications = new List<Certification>();
            foreach (var certificate in model.Certification)
            {
                newCertifications.Add(this.Mapper.Map<Certification>(certificate));
            }

            newCv.Educations = newEducations;
            newCv.Certificates = newCertifications;

            this.cvs.AddCv(newCv);

            this.SetCv(newCv.Id);

            return this.View("AddEducation", new EducationInputModel());
        }

        public ActionResult AddEducation(EducationInputModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            var cv = this.cvs.GetChoosen().FirstOrDefault();
            var education = this.Mapper.Map<Education>(model);

            cv.Educations.Add(education);
            this.cvs.Update();

            return this.View("AddCourse", new EducationIdViewModel() { Id = education.Id });
        }

        public ActionResult AddCourse(int educationId, string[] courses)
        {
            var coursesList = new List<Course>();
            foreach (var course in courses)
            {
                coursesList.Add(new Course() { CourseName = course });
            }

            var education = this.educations.GetById(educationId);
            education.Courses = coursesList;
            this.educations.Update();

            var url = "CvsHistory";
            return this.Json(new { Url = url });
        }

        /// <summary>
        /// Set choosen CV like default on main page.
        /// </summary>
        /// <param name="id">The choosen CV id.</param>
        /// <returns>Redirect to main page.</returns>
        public ActionResult SetCv(int id)
        {
            var choosen = this.cvs.GetChoosen();
            foreach (var choice in choosen)
            {
                choice.IsChoosen = false;
            }

            var cv = this.cvs.GetById(id);
            if (cv == null)
            {
                return this.RedirectToAction("CvsHistory");
            }

            cv.IsChoosen = true;
            this.cvs.Update();

            return this.RedirectToAction("Index");
        }

        public ActionResult ViewCv(int id)
        {
            var cv = this.cvs.GetById(id);
            if (cv == null)
            {
                return this.RedirectToAction("CvsHistory");
            }

            var viewModel = this.GetIndexModel(cv);
            return this.View("Index", viewModel);
        }

        private IndexViewModel GetIndexModel(CurriculumVitae cv)
        {
            var cvId = cv.Id;

            var personalInfo = this.Mapper.Map<CurriculumVitae, CvViewModel>(cv);
            var education = this.educations
                .GetByCvId(cvId)
                .To<EducationViewModel>()
                .ToList();
            var certificates = this.certifications
                .GetByCvId(cvId)
                .To<CertificationViewModel>()
                .ToList();

            var viewModel = new IndexViewModel()
            {
                PersonalInfo = personalInfo,
                Education = education,
                Certificates = certificates
            };

            return viewModel;
        }
    }
}
