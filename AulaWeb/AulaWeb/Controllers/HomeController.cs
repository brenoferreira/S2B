using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AulaWeb.Models;

namespace AulaWeb.Controllers
{
    public class HomeController : Controller
    {
        //GET: /Home/Index
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        //GET: /Home/About
        public ActionResult About()
        {
            return View();
        }

        public ActionResult OlaMundo()
        {
            return View();
        }

        //GET: /Home/Formulario
        public ActionResult Formulario()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Formulario(Cadastro cadastro)
        {
            //salvei no Banco

            return RedirectToAction("FormularioConcluido");
        }

        public ActionResult FormularioConcluido()
        {
            return View();
        }
    }
}
