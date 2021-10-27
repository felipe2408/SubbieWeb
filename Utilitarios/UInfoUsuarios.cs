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
    [Table("infousuarios",Schema = "usuario")]
    public class UInfoUsuarios
    {
        private int fk_idusuario;
        private string nombres;
        private string apellidos;
        private string telefono;
        private string ciudad;
        private string direccion;
        private string tipoIdentificacion;
        private string identificacion;
        
        [Key]
        [Column("fk_idusuario")]
        public int Fk_idusuario { get => fk_idusuario; set => fk_idusuario = value; }

        [Column("nombres")]
        public string Nombres { get => nombres; set => nombres = value; }

        [Column("apellidos")]
        public string Apellidos { get => apellidos; set => apellidos = value; }

        [Column("telefono")]
        public string Telefono { get => telefono; set => telefono = value; }

        [Column("ciudad")]
        public string Ciudad { get => ciudad; set => ciudad = value; }

        [Column("direccion")]
        public string Direccion { get => direccion; set => direccion = value; }

        [Column("tipoIdentificacion")]
        public string TipoIdentificacion { get => tipoIdentificacion; set => tipoIdentificacion = value; }

        [Column("identificacion")]
        public string Identificacion { get => identificacion; set => identificacion = value; }
    }
}
