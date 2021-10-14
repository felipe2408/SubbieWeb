using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Utilitarios;
namespace LogicaDeNegocios
{
    public class LUCategoriaProducto
    {
        public List<UProductoCategoria> obtenerCategoria()
        {
            List<UProductoCategoria> categoria = new DaoCategoriaProducto().obtenerCategoria();
            return categoria;
        }

    }
}
