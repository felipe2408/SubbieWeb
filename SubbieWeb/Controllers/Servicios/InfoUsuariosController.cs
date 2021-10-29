using Microsoft.AspNetCore.Cors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Utilitarios;
using LogicaDeNegocios;

namespace SubbieWeb.Controllers.Servicios
{
    [DisableCors]
    [RoutePrefix("api/InfoUsuarios")]
    public class InfoUsuariosController : ApiController
    {

        [Route("info")]
        [HttpGet]
        public IHttpActionResult infoUsuarios()
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
            List<UInfoUsuarios> listaUsers = new LUInfoUsuarios().infoUsuarios();
            return Ok(listaUsers);

        }
        [Route("addInfo")]
        [HttpPost]
        public IHttpActionResult addInfo(UInfoUsuarios info)
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
            bool valor = new LUInfoUsuarios().addInformacion(info);
            // LUUsuarios().obtenerusarios()
            return Ok(valor);

        }



    }
}
