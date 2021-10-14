using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitarios;
using Datos;
namespace LogicaDeNegocios
{
    public class LUMetodoPago
    {

        public List<UMetodoPago> obtenerFormaPago()
        {
            List<UMetodoPago> listFormaP = new DaoMetodoPago().obtenerFormaPago();
            return listFormaP;
        }

    }
}
