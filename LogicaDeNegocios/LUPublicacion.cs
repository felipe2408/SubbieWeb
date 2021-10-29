using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Utilitarios;
namespace LogicaDeNegocios
{
     public class LUPublicacion
    {
        public bool publicar(UPublicaciones publicacion)
        {
            bool correcto = new DaoPublicaciones().publicar(publicacion);
            return correcto;
        }
        public List<UPublicaciones> publicaciones()
        {
            List<UPublicaciones> listaP = new DaoPublicaciones().publicaciones();
            
            return listaP;
        }
    }
}
