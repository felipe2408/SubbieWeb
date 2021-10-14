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
                    db.publicar.Add(publicacionU);
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
    }
}
