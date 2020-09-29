using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVR_Casa_Pronta.Repository;
using MVR_Casa_Pronta.Service;
using Unity;
using static MVR_Casa_Pronta.Service.ImageSeparator;

namespace MVR_Casa_Pronta.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly IGaleryCreator _galeryCreator;

        public ProjectsController() 
        {
            _galeryCreator = new GaleryCreator(new ImageSeparator(new ImagesRepository()));
        }

        //public ProjectsController(IGaleryCreator galeryCreator)
        //{
        //    _galeryCreator = galeryCreator;
        //}
        // GET: Projects
        public ActionResult Index()
        {
            object divFinal = _galeryCreator.GaleryCreatorMethod();
            return View();
        }
    }
}