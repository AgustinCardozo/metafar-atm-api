using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityConfigurations
{
    public class OperacionConfiguration : IEntityTypeConfiguration<Operacion>
    {
        public void Configure(EntityTypeBuilder<Operacion> entityBuilder)
        {
            entityBuilder.ToTable("Operaciones");
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.Property(x => x.NumeroDeCuenta).IsRequired();
            entityBuilder.Property(x => x.UltimaExtraccion);
            entityBuilder.Property(x => x.SaldoActual).IsRequired();

            entityBuilder
                .HasOne(x => x.Cuenta)
                .WithMany(x => x.Operaciones)
                .HasForeignKey(x => x.NumeroDeCuenta);

            entityBuilder
                .HasData(
                    new()
                    {
                        Id = new Guid("d769e439-432b-4f36-ab37-5801c0205128"),
                        SaldoActual = 800000, 
                        UltimaExtraccion = new DateTime(2025, 04, 07, 11, 35, 10),
                        NumeroDeCuenta = 23042010
                    },
                    new()
                    {
                        Id = new Guid("914ef540-7128-40a0-9ce4-e5f4389247c1"),
                        SaldoActual = 500000,
                        UltimaExtraccion = new DateTime(2025, 04, 06, 10, 35, 10),
                        NumeroDeCuenta = 23042010
                    },
                    new()
                    {
                        Id = new Guid("d34b4d33-4b1b-49b5-872a-1205024e3301"),
                        SaldoActual = 700000,
                        UltimaExtraccion = new DateTime(2025, 04, 07, 11, 40, 17),
                        NumeroDeCuenta = 23042010
                    },
                    new()
                    {
                        Id = new Guid("ebfbd1ba-eb2e-4b75-9e1e-9fd758d3101b"),
                        SaldoActual = 400000,
                        UltimaExtraccion = new DateTime(2025, 04, 07, 11, 33, 51),
                        NumeroDeCuenta = 23042010
                    },
                    new()
                    {
                        Id = new Guid("79a3d8ae-a47b-45e0-aeab-f8fbcfd8247a"),
                        SaldoActual = 320000,
                        UltimaExtraccion = new DateTime(2025, 04, 06, 14, 56, 10),
                        NumeroDeCuenta = 09122018
                    },
                    new()
                    {
                        Id = new Guid("7c12d056-424b-44b1-95fb-945b78654c0a"),
                        SaldoActual = 234500,
                        UltimaExtraccion = new DateTime(2025, 04, 07, 11, 38, 41),
                        NumeroDeCuenta = 09122018
                    },
                    new()
                    {
                        Id = new Guid("2c25a244-58e1-4af5-8549-218d933d4747"),
                        SaldoActual = 570000,
                        UltimaExtraccion = new DateTime(2025, 04, 07, 11, 36, 23),
                        NumeroDeCuenta = 09122018
                    },
                    new()
                    {
                        Id = new Guid("7a7c7eee-9bab-4e6c-a664-f040cc357cee"),
                        SaldoActual = 800023,
                        UltimaExtraccion = new DateTime(2025, 04, 06, 17, 35, 10),
                        NumeroDeCuenta = 09122018
                    },
                    new()
                    {
                        Id = new Guid("8aeb0237-5fbc-4e39-88e6-b1cd02d07bc7"),
                        SaldoActual = 600230,
                        UltimaExtraccion = new DateTime(2025, 04, 07, 11, 25, 10),
                        NumeroDeCuenta = 09122018
                    },
                    new()
                    {
                        Id = new Guid("7930faee-3412-44a1-9813-2e14f404af51"),
                        SaldoActual = 156500,
                        UltimaExtraccion = new DateTime(2025, 04, 06, 12, 55, 43),
                        NumeroDeCuenta = 09122018
                    },
                    new()
                    {
                        Id = new Guid("81733dac-cca8-4e9b-9737-121d45c65ac1"),
                        SaldoActual = 23000,
                        UltimaExtraccion = new DateTime(2025, 04, 03, 11, 37, 17),
                        NumeroDeCuenta = 09122018
                    },
                    new()
                    {
                        Id = new Guid("1897f83c-dba7-4a35-86ef-64ddaaecd4b3"),
                        SaldoActual = 400,
                        UltimaExtraccion = new DateTime(2025, 04, 02, 16, 36, 33),
                        NumeroDeCuenta = 09122018
                    },
                    new()
                    {
                        Id = new Guid("7cdc0e9c-2f31-4088-93fd-b99559116728"),
                        SaldoActual = 267500,
                        UltimaExtraccion = new DateTime(2025, 04, 04, 09, 43, 19),
                        NumeroDeCuenta = 09122018
                    },
                    new()
                    {
                        Id = new Guid("aa604404-dfc5-4158-91ae-598efe4d6323"),
                        SaldoActual = 1234300,
                        UltimaExtraccion = new DateTime(2025, 04, 05, 10, 03, 07),
                        NumeroDeCuenta = 09122018
                    },
                    new()
                    {
                        Id = new Guid("92812bff-0dcc-4396-9294-0bc91850946f"),
                        SaldoActual = 676540,
                        UltimaExtraccion = new DateTime(2025, 04, 07, 11, 55, 00),
                        NumeroDeCuenta = 09122018
                    },
                    new()
                    {
                        Id = new Guid("2a60cdcb-26ec-4ae4-867c-b249bed91a7a"),
                        SaldoActual = 120003,
                        UltimaExtraccion = new DateTime(2025, 03, 31, 14, 25, 43),
                        NumeroDeCuenta = 09122018
                    },
                    new()
                    {
                        Id = new Guid("44940e3b-8bc8-4aae-b88a-3032a596075d"),
                        SaldoActual = 50329,
                        UltimaExtraccion = new DateTime(2025, 04, 07, 11, 50, 59),
                        NumeroDeCuenta = 09122018
                    },
                    new()
                    {
                        Id = new Guid("867d78a3-dd1f-4170-a71b-945d54665411"),
                        SaldoActual = 102003,
                        UltimaExtraccion = new DateTime(2025, 04, 01, 18, 38, 12),
                        NumeroDeCuenta = 09122018
                    },
                    new()
                    {
                        Id = new Guid("77788191-ceba-4e8f-960a-62ad79d264fc"),
                        SaldoActual = 0,
                        UltimaExtraccion = new DateTime(2025, 04, 02, 09, 28, 57),
                        NumeroDeCuenta = 18122022
                    },
                    new()
                    {
                        Id = new Guid("cc130800-5f61-46c1-a031-49aaf5397089"),
                        SaldoActual = 5000000,
                        UltimaExtraccion = new DateTime(2025, 04, 06, 11, 23, 04),
                        NumeroDeCuenta = 18122022
                    }
                );
        }
    }
}
