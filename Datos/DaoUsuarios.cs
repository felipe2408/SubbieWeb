using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitarios;
using System.Data.Entity;
namespace Datos
{
    public class DaoUsuarios
    {
        public List<UUsuarios> obtenerusarios()
        {
            List<UUsuarios> uDb = new List<UUsuarios>();
            using (var db = new DBMapeo())
            {
                uDb = db.usuarios.ToList();
            }
            return uDb;
        }
        public bool registrar(UUsuarios usuarioR)
        {
            bool valor;
            using (var db = new DBMapeo())
            {
                UUsuarios userC = db.usuarios.Where(x => x.Correo.Equals(usuarioR.Correo)).FirstOrDefault();

                if (userC == null)
                {
                    db.usuarios.Add(usuarioR);
                    db.SaveChanges();
                    valor = true;
                }
                else
                {
                    valor = false;
                }
                return valor;
            }
        }

        public UUsuarios iniciarS(string correo, string password)
        {
           
            UUsuarios user = new UUsuarios();
            using (var db = new DBMapeo())
            {
                user = db.usuarios.Where(x => x.Correo.Equals(correo) && x.Password.Equals(password)).FirstOrDefault();
                if (user == null)
                {
                    return null;
                }

            }

            return user;
        }
        public bool Comprobacion(bool estado) {
            return estado;
        }

        public void eliminarusuario(int id)
        {
            UUsuarios user = new UUsuarios();
            using (var db = new DBMapeo())
            {
                user = db.usuarios.Where(x=> x.Id.Equals(id)).FirstOrDefault();
                var entry = db.Entry(user);
                entry.State = EntityState.Deleted;
                db.SaveChanges();
            }
        }
        public UUsuarios modificarusuario(UUsuarios userM)
        {
            UUsuarios user = new UUsuarios();
            using (var db = new DBMapeo())
            {
                user = db.usuarios.Where(x => x.Correo.Equals(userM.Correo) && x.Id != userM.Id).FirstOrDefault();
                if (user == null)
                {
                    var entry = db.Entry(userM);
                    entry.State = EntityState.Modified;
                    db.SaveChanges();
                    return userM;
                }
                return null;
            }
        }
    }
}
