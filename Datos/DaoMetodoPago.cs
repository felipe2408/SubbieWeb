using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitarios;
namespace Datos
{
    public class DaoMetodoPago
    {
        public List<UMetodoPago> obtenerFormaPago()
        {
            List<UMetodoPago> uDb = new List<UMetodoPago>();
            using (var db = new DBMapeo())
            {
                uDb = db.obtenerFormaPago.ToList();
            }
            return uDb;
        }
    }
}
