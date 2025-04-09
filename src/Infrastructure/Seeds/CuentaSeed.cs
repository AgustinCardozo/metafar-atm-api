using Domain.Entities;

namespace Infrastructure.Seeds
{
    public static class CuentaSeed
    {
        public static List<Cuenta> GetCuentas()
        {
            return new List<Cuenta>
            {
                new Cuenta()
                {
                    NumeroDeCuenta = 20250404,
                    NumeroDeTarjeta = "4444333300007777",
                    Pin = "2025",
                    UsuarioId = Guid.Parse("B3B6F399-4993-42DE-8772-9AE8A732504D")
                },
                new Cuenta()
                {
                    NumeroDeCuenta = 11235813,
                    NumeroDeTarjeta = "4444333311117777",
                    Pin = "0628",
                    UsuarioId = Guid.Parse("774B7FA6-50FD-4ABC-80F7-B2000B349C23")
                },
                new Cuenta()
                {
                    NumeroDeCuenta = 48342025,
                    NumeroDeTarjeta = "4454272409039986",
                    Pin = "1051",
                    UsuarioId = Guid.Parse("2ccef8f6-fe86-4e8d-a24b-6bd14f278e99")
                }
            };
        }
    }
}
