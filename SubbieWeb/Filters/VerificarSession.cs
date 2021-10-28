using SubbieWeb.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Utilitarios;
namespace SubbieWeb.Filters
{
    public class VerificarSession : ActionFilterAttribute
    {
        private UUsuarios oUsuario;

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {

            try {
                base.OnActionExecuted(filterContext);
                oUsuario = (UUsuarios)HttpContext.Current.Session["User"];
                if (oUsuario == null)
                {
                    if (filterContext.Controller is SplashController == false)
                    {
                        filterContext.HttpContext.Response.Redirect("/Splash/Login");
                   
                    }
                }


            }
            catch (Exception)
            {
                filterContext.Result = new RedirectResult("~/Splash/Login");
            }




        }

    }
}