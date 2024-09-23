using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    public class UsuarioConfiguration
    {
        public UsuarioConfiguration(EntityTypeBuilder<Usuario> entityBuilder)
        {
            entityBuilder.ToTable("Usuario");
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.NombreDeUsuario).IsRequired();

            entityBuilder
                .HasMany(x => x.Cuentas)
                .WithOne(x => x.Usuario)
                .HasForeignKey(x => x.UsuarioId);

            entityBuilder.HasData(
                new Usuario()
                {
                    Id = new Guid("B3B6F399-4993-42DE-8772-9AE8A732504D"),
                    NombreDeUsuario = "Pepe Argento"
                },
                new Usuario()
                {
                    Id = new Guid("4C7C5B69-D92E-44C4-8524-ABE0A229779A"),
                    NombreDeUsuario = "Marcelo Gallardo"
                },
                new Usuario()
                {
                    Id = new Guid("774B7FA6-50FD-4ABC-80F7-B2000B349C23"),
                    NombreDeUsuario = "Dardo Fuseneco"
                }
                );
        }
    }
}
