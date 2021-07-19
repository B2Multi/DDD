using Dominio.Modelos;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Infra.Contexto
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }

        public DbSet<Banco> Banco { get; set; }
        public DbSet<Agencia> Agencia { get; set; }
        public DbSet<Conta> Conta { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BancoContext).Assembly);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);

        }
    }
}
