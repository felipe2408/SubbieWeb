using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitarios;
namespace Datos
{
    public class DBMapeo : DbContext
    {
        static DBMapeo()
        {
            Database.SetInitializer<DBMapeo>(null);
        }

        private readonly string schema;
        public DBMapeo()
            : base("name=Postgres")
        {

        }

        public DbSet<UUsuarios> usuarios { get; set; }
        
        public DbSet<UMetodoPago> obtenerFormaPago { get; set; }
        
        public DbSet<UProductoCategoria> obtenerCategoria { get; set; }

        public DbSet<UPublicaciones> publicar { get; set; }
        public DbSet<UInfoUsuarios> infoUsuarios { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(this.schema);
            base.OnModelCreating(modelBuilder);
        }

    }
}
