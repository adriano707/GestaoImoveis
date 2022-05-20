using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Data
{
    public class GestaoImoveisContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Imovel> Imoveis { get; set; }

        public GestaoImoveisContext(DbContextOptions<GestaoImoveisContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
