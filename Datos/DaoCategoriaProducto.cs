using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitarios;
namespace Datos
{
    public class DaoCategoriaProducto
    {
        public List<UProductoCategoria> obtenerCategoria()
        {
            List<UProductoCategoria> uDb = new List<UProductoCategoria>();
            using (var db = new DBMapeo())
            {
                uDb = db.obtenerCategoria.ToList();
            }

            return uDb;
        }

    }
}
