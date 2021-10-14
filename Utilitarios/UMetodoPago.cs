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
    [Table("metodopago",Schema ="productos")]
    public class UMetodoPago
    {
        private int pk_idpago;
        private string formapago;

        [Key]
        [Column("pk_idpago")]
        public int Pk_idpago { get => pk_idpago; set => pk_idpago = value; }
        [Column("formapago")]
        public string Formapago { get => formapago; set => formapago = value; }
    }
}
