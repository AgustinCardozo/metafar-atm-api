using Domain.Entities;
using Infrastructure.EntityConfigurations;
using Infrastructure.Seeds;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class AtmContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cuenta> Cuentas { get; set; }
        public DbSet<Operacion> Operaciones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            EntityConfiguration(modelBuilder);
            SeedEntities(modelBuilder);
        }

        private static void EntityConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CuentaConfiguration());
            modelBuilder.ApplyConfiguration(new  OperacionConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
        }

        private static void SeedEntities(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cuenta>().HasData(CuentaSeed.GetCuentas());
            modelBuilder.Entity<Usuario>().HasData(UsuarioSeed.GetUsuarios());
            modelBuilder.Entity<Operacion>().HasData(OperacionSeed.GetOperaciones());
        }
    }
}
