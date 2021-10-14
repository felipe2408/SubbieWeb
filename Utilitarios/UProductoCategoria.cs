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
    [Table("pcategoria",Schema ="productos")]
    public class UProductoCategoria
    {
        private int pk_idcatproducto;
        private string categoria;

        [Key]
        [Column("pk_idcatproducto")]
        public int Pk_idcatproducto { get => pk_idcatproducto; set => pk_idcatproducto = value; }
        [Column("categoria")]
        public string Categoria { get => categoria; set => categoria = value; }
    }
}
