using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SubbieWeb.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Publicar()
        {
            //Guid g = Guid.NewGuid();
            //Console.WriteLine(g);
            return View();
        }
        public ActionResult Chat()
        {

            return View();
        }
        public ActionResult Productos()
        {

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page a.";

            return View();
        }
    }
}