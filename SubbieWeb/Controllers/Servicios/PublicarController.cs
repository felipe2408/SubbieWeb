using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Datos;
using LogicaDeNegocios;
using Microsoft.AspNetCore.Cors;
using Utilitarios;
namespace SubbieWeb.Controllers.Servicios
{
    [DisableCors]
    [RoutePrefix("api/producto")]
    public class PublicarController : ApiController
    {
        [Route("publicar")]
        [HttpPost]
        public IHttpActionResult crearPublicacion(UPublicaciones publicacionU)
        {
            if (!ModelState.IsValid)
            {
                string error = "Datos incorrectos, ";
                foreach (var state in ModelState)
                {
                    foreach (var item in state.Value.Errors)
                    {
                        error += $"{item.ErrorMessage}";
                    }
                }
                return BadRequest(error);
            }
            bool correcto = new LUPublicacion().publicar(publicacionU);
           
            return Ok(correcto);
        }
    }
}
