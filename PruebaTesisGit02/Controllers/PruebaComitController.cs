using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaTesisGit02.Controllers
{
    public class PruebaComitController : Controller
    {
        // GET: PruebaComit
        public ActionResult Index()
        {
            return View();
            //holip es una prueba:(

            Console.WriteLine("Hola sin morir");
        }
    }
}