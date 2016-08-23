using System;
using System.Data.Entity; //para referenciar a class DbContext
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.LojaVirtual.Dominio.Entidades;

namespace Web.LojaVirtual.Dominio.Repositorio
{
    public class EfDbContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) //Para não fazer a pluralização
        {
            modelBuilder.Conventions.Remove < PluralizingTableNameConvention>();
            modelBuilder.Entity<Produto>().ToTable("Produtos");
        }

        
    }
}
