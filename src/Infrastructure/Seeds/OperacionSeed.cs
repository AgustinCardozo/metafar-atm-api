using Domain.Entities;

namespace Infrastructure.Seeds
{
    public static class OperacionSeed
    {
        public static List<Operacion> GetOperaciones()
        {
            return new List<Operacion>
            {
                new Operacion
                {
                    Id = new Guid("1355a80b-21da-45cb-89bf-aa7f5861ecad"),
                    SaldoActual = 1000000,
                    UltimaExtraccion = DateTime.Parse("2025/04/08 11:13:23"),
                    NumeroDeCuenta = 48342025
                },
                new Operacion
                {
                    Id= new Guid("78b1f9b5-293f-40f9-9810-dfa2b876a98b"),
                    SaldoActual = 700000,
                    UltimaExtraccion = DateTime.Parse("2025/04/08 11:13:23"),
                    NumeroDeCuenta = 48342025
                }
            };
        }
    }
}
