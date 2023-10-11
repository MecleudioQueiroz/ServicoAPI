using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ServicoAPI.Models
{
    public partial class Contexto : DbContext
    {
        public Contexto():base("name=Contexto")
        {

        }

        public virtual DbSet<Categorias> Categorias { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<DadosRomaneio> DadosRomaneio { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
