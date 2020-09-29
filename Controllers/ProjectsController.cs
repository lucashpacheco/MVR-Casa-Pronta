using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVR_Casa_Pronta.Repository;
using MVR_Casa_Pronta.Service;
using Unity;


namespace MVR_Casa_Pronta.Controllers
{
    public class ProjectsController : Controller
    {
        public IGaleryCreator galeryCreator { get; set; }
        // GET: Projects
        public ActionResult Index()
        {

            object divFinal = galeryCreator.GaleryCreatorMethod();


            return View();
        }


        
    }
}