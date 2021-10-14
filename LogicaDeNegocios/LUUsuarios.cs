using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitarios;
using Datos;
namespace LogicaDeNegocios
{
    public class LUUsuarios
    {
        public List<UUsuarios> obtenerusarios()
        {
            List<UUsuarios> listusers = new DaoUsuarios().obtenerusarios();
            return listusers;
        }
        
        public bool registrarUsuario(UUsuarios user)
        {
            bool valor = new DaoUsuarios().registrar(user);
            return valor;
        }
        public UUsuarios iniciarS(string correo, string password)
        {
            UUsuarios user = new DaoUsuarios().iniciarS(correo, password);
            return user;
        }
        public void eliminarusuario(int id)
        {
            new DaoUsuarios().eliminarusuario(id);
        }

        public UUsuarios modificar(UUsuarios userM)
        {
            UUsuarios user = new DaoUsuarios().modificarusuario(userM);
            return user;
        }

    }
}
