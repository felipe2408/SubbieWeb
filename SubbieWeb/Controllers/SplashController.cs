using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Utilitarios;
using Datos;
using LogicaDeNegocios;
using SubbieWeb.Controllers.Servicios;
namespace SubbieWeb.Controllers

{
    public class SplashController : Controller
    {
        public ActionResult Login()
        {
           
            ViewBag.Messague = "LOGIN ";
            return View();
        }
        [HttpPost]
        public ActionResult Login(UUsuarios usuario)
        {
            UsuariosController data = new UsuariosController();
            if (data.sesionOK(false))
            {
                return RedirectToAction("Login", "Splash");
            }
            return View(usuario);

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
