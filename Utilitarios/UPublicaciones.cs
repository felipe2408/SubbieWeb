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
    [Table("publicaciones",Schema =("productos"))]
    public class UPublicaciones
    {
        private int pk_idpublicacion;
        private int fk_idusuario;
        private int fk_idcatproducto;
        private int fk_idpago;
        private string descripcion;
        private double precio;
        private string fecha;
        private string nombreimg;
        private string archivoimg;

        [Key]
        [Column("pk_idpublicacion")]
        public int Pk_idpublicacion { get => pk_idpublicacion; set => pk_idpublicacion = value; }
        [Column("fk_idusuario")]
        public int Fk_idusuario { get => fk_idusuario; set => fk_idusuario = value; }
        [Column("fk_idcatproducto")]
        public int Fk_idcatproducto { get => fk_idcatproducto; set => fk_idcatproducto = value; }
        [Column("fk_idpago")]
        public int Fk_idpago { get => fk_idpago; set => fk_idpago = value; }
        [Column("descripcion")]
        public string Descripcion { get => descripcion; set => descripcion = value; }
        [Column("precio")]
        public double Precio { get => precio; set => precio = value; }
        [Column("fecha")]
        public string Fecha { get => fecha; set => fecha = value; }
        [Column("nombreimg")]
        public string Nombreimg { get => nombreimg; set => nombreimg = value; }
        [Column("archivoimg")]
        public string Archivoimg { get => archivoimg; set => archivoimg = value; }
    }
}
