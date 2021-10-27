using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitarios;
namespace Datos
{
    public class DaoInfoUsuarios
    {
        public List<UInfoUsuarios> informacion()
        {
            List<UInfoUsuarios> uDb = new List<UInfoUsuarios>();
            using(var db = new DBMapeo())
            {
                uDb = db.infoUsuarios.ToList();

            }

            return uDb;
        }

        public bool  addInfo(UInfoUsuarios info)
        {
            bool comprobacion = false;
            using (var db = new DBMapeo())
            {
                if(info != null)
                {
                    db.infoUsuarios.Add(info);
                    db.SaveChanges();
                    comprobacion = true;
                }


            }

            return comprobacion;
        }

    }

}
