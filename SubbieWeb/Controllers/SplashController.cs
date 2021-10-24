using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Utilitarios;
using Datos;
using LogicaDeNegocios;
using SubbieWeb.Controllers.Servicios;
using Datos;
namespace SubbieWeb.Controllers

{
    public class SplashController : Controller
    {
       
       
        public ActionResult Login()
        {
        
            return View();
        }
        [HttpPost]
        public ActionResult Login(string correo,string password)
        {
            try {

                UUsuarios user = new UUsuarios();
                using (var db = new DBMapeo())
                {
                    user = db.usuarios.Where(x => x.Correo.Equals(correo) && x.Password.Equals(password)).FirstOrDefault();
                    if (user == null)
                    {

                        return View();
                    }
                    Session["User"] = user;
                }
                return RedirectToAction("Index","Home");

            }
            catch (Exception ex) {
                ViewBag.Error = ex.Message;
                return View();
            
            }
           
   

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
