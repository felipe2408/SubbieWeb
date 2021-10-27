using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitarios;
using Datos;
namespace LogicaDeNegocios
{
    public class LUInfoUsuarios
    {
        public List<UInfoUsuarios> infoUsuarios()
        {
            List<UInfoUsuarios> listusers = new DaoInfoUsuarios().informacion();
            return listusers;
        }

        public bool addInformacion(UInfoUsuarios info)
        {
            bool valor = new DaoInfoUsuarios().addInfo(info);
            return valor;
        }
    }
}
