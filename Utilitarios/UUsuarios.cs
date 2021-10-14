using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitarios
{
    [Serializable]
    [Table("usuarios", Schema = "usuario")]
    public class UUsuarios
    {
    
        private int id;
        private string correo;
        private string password;

        [Key]
        [Column("id")]
        public int Id { get => id; set => id = value; }
        [Column("correo")]
        public string Correo { get => correo; set => correo = value; }
        [Column("password")]
        public string Password { get => password; set => password = value; }
    }
}
