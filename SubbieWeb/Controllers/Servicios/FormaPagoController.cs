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
    [RoutePrefix("api/obtenerFormaPago")]

    public class FormaPagoController : ApiController
    {
        [Route("formaPago")]  
        [HttpGet]
        public IHttpActionResult obtenerFormaPago()
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
            List<UMetodoPago> formaPago = new LUMetodoPago().obtenerFormaPago();
            return Ok(formaPago);
        }
    }
}
