using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace SubbieWeb.Controllers
{
    public class SplashController : Controller
    {
        public ActionResult Login()
        {
           
            ViewBag.Messague = "LOGIN ";
            return View();
        }
        public ActionResult Registrer()
        {

            return View();
        }
        public ActionResult Contenedor()
        {

            return View();
        }
    }
}
