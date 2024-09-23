using Domain.Entities;
using Infrastructure.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
    public class AtmContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cuenta> Cuentas { get; set;}
        public DbSet<Operacion> Operaciones { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            EntityConfiguration(modelBuilder);
        }

        private static void EntityConfiguration(ModelBuilder modelBuilder)
        {
            _ = new UsuarioConfiguration(modelBuilder.Entity<Usuario>());
            _ = new CuentaConfiguration(modelBuilder.Entity<Cuenta>());
            _ = new OperacionConfiguration(modelBuilder.Entity<Operacion>());
        }
    }
}
