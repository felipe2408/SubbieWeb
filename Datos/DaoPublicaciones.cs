using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitarios;
namespace Datos
{
    public class DaoPublicaciones
    {
        public bool publicar(UPublicaciones publicacionU)
        {
            bool correcto;
            using (var db = new DBMapeo())
            {
                if(publicacionU != null)
                {
                    db.publicaciones.Add(publicacionU);
                    db.SaveChanges();
                    correcto = true;
                }
                else
                {
                    correcto = false;
                }
            }
            return correcto;
        }
        public List<UPublicaciones> publicaciones()
        {
            List<UPublicaciones> uDb = new List<UPublicaciones>();
            using (var db = new DBMapeo())
            {
                uDb = db.publicaciones.ToList();
            }
            return uDb;
        }



    }
}
