using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityConfigurations
{
    public class CuentaConfiguration : IEntityTypeConfiguration<Cuenta>
    {
        public void Configure(EntityTypeBuilder<Cuenta> entityBuilder)
        {
            entityBuilder.ToTable("Cuentas");
            entityBuilder.HasKey(x => x.NumeroDeCuenta);
            entityBuilder.Property(x => x.NumeroDeTarjeta).HasMaxLength(16).IsRequired();
            entityBuilder.Property<string>(x => x.Pin).HasMaxLength(4).IsRequired();
            entityBuilder.Property(x => x.CantidadDeIntentos).IsRequired();
            entityBuilder.Property(x => x.Bloqueado).IsRequired();
            entityBuilder.Property<bool>(x => x.Activado).HasDefaultValue(true).IsRequired();

            entityBuilder
                .HasOne(x => x.Usuario)
                .WithMany(x => x.Cuentas)
                .HasForeignKey(x => x.UsuarioId);

            entityBuilder.HasData(
                new Cuenta()
                {
                    NumeroDeCuenta = 23042010,
                    NumeroDeTarjeta = "4444222200008888",
                    Pin = "1234",
                    UsuarioId = new Guid("B3B6F399-4993-42DE-8772-9AE8A732504D")
                },
                new Cuenta()
                {
                    NumeroDeCuenta = 09122018,
                    NumeroDeTarjeta = "4444222200009999",
                    Pin = "5678",
                    UsuarioId = new Guid("774B7FA6-50FD-4ABC-80F7-B2000B349C23")
                },
                new Cuenta()
                {
                    NumeroDeCuenta = 18122022,
                    NumeroDeTarjeta = "4444333300009999",
                    Pin = "9012",
                    UsuarioId = new Guid("4C7C5B69-D92E-44C4-8524-ABE0A229779A")
                });
        }
    }
}
