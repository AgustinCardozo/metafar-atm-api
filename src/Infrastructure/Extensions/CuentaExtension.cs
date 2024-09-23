using Domain.Entities;

namespace Infrastructure.Extensions
{
    public static class CuentaExtension
    {
        public static List<Cuenta> GetCuentas()
        {
            return
            [
                new()
                {
                    NumeroDeCuenta = 23042010,
                    NumeroDeTarjeta = "4444222200008888",
                    Pin = 1234,
                    UsuarioId = new Guid("943a6dfc-99ab-49ee-9f44-48c8e6da71a2")
                },
                new()
                {
                    NumeroDeCuenta = 09122018,
                    NumeroDeTarjeta = "4444222200009999",
                    Pin = 5678,
                    UsuarioId = new Guid("cac3bf1b-63df-4d07-ade5-a45bf0d09ea9")
                },
                new()
                {
                    NumeroDeCuenta = 18122022,
                    NumeroDeTarjeta = "4444333300009999",
                    Pin = 9012,
                    UsuarioId = new Guid("c7a9abed-adbd-4d90-91a9-4cdf1be65b07")
                }
            ];
        }
    }
}
