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
                    IdUsuario = 1
                },
                new()
                {
                    NumeroDeCuenta = 09122018,
                    NumeroDeTarjeta = "4444222200009999",
                    Pin = 5678,
                    IdUsuario = 2
                },
                new()
                {
                    NumeroDeCuenta = 18122022,
                    NumeroDeTarjeta = "4444333300009999",
                    Pin = 9012,
                    IdUsuario = 3
                }
            ];
        }
    }
}
