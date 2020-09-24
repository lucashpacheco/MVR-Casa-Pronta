using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVR_Casa_Pronta.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Sobre a MVR Casa Pronta";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Entre em contato com a MVR";

            return View();
        }

        public ActionResult Projects()
        {
            ViewBag.Message = "Galeria de Projetos";

            return View();
        }
    }
}