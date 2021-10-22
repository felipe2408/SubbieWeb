using LogicaDeNegocios;
using Microsoft.AspNetCore.Cors;
using System;
using System.Collections.Generic;
using System.Web.Http;
using Utilitarios;

namespace SubbieWeb.Controllers.Servicios
{
    [DisableCors]
    [RoutePrefix("api/usuarios")]
    public class UsuariosController : ApiController
    {
        [Route("listausuarios")]
        [HttpGet]
        public IHttpActionResult listarusuarios()
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
            List<UUsuarios> listaUsers = new LUUsuarios().obtenerusarios();
            return Ok(listaUsers);
        }
        [Route("registrarusuario")]
        [HttpPost]
        public IHttpActionResult registrarusuario(UUsuarios user)
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
            bool valor = new LUUsuarios().registrarUsuario(user);
            return Ok(valor);
        }
        [Route("iniciarsesion")]
        [HttpGet]
        public IHttpActionResult iniciarsesion(string correo, string password)
        {
            bool confirmar = true;
            if (!ModelState.IsValid)
            {
                confirmar = false;
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
            UUsuarios user = new LUUsuarios().iniciarS(correo, password);
            sesionOK(confirmar);
            return Ok(user);
        }
        public bool sesionOK(bool estado)
        {
            return estado;
        }

        [Route("eliminarusuario")]
        
        [HttpDelete]
        public IHttpActionResult eliminarusuario(int id)
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
            new LUUsuarios().eliminarusuario(id);
            return Ok(id);
        }
        [Route("modificarusuario")]
        [HttpPut]
        public IHttpActionResult modificarusuario(UUsuarios user)
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
            UUsuarios userM = new LUUsuarios().modificar(user);
            return Ok(userM);
        }

        public static implicit operator List<object>(UsuariosController v)
        {
            throw new NotImplementedException();
        }
    }
}