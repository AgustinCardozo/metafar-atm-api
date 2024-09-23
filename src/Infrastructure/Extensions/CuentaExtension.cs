using Domain.Entities;

namespace Infrastructure.Extensions
{
    public static class CuentaExtension
    {
        public static Cuenta GetCuenta()
        {
            return new()
            {
                NumeroDeCuenta = 23042010,
                NumeroDeTarjeta = "4444222200008888",
                Pin = 1234,
                Operaciones = OperacionExtension.GetOperaciones()
            };
        }

        public static List<Cuenta> GetCuentas()
        {
            return new List<Cuenta>()
            {
                GetCuenta(),
                new()
                {
                    NumeroDeCuenta = 09122018,
                    NumeroDeTarjeta = "4444222200009999",
                    Pin = 5678,
                    Operaciones = OperacionExtension.GetOperaciones().Take(4).ToList()
                }
            };
        }
    }
}
