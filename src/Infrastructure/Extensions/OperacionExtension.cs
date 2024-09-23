using Domain.Entities;

namespace Infrastructure.Extensions
{
    public static class OperacionExtension
    {
        public static List<Operacion> GetOperaciones()
        {
            return new List<Operacion>()
            {
                new()
                {
                    Id = 1,
                    SaldoActual = 800000,
                    UltimaExtraccion = DateTime.Now
                },
                new()
                {
                    Id = 2,
                    SaldoActual = 500000,
                    UltimaExtraccion = DateTime.Now.AddDays(-1)
                },
                new ()
                {
                    Id = 3,
                    SaldoActual = 700000,
                    UltimaExtraccion = DateTime.Now.AddHours(-1)
                },
                new ()
                {
                    Id = 4,
                    SaldoActual = 400000,
                    UltimaExtraccion = DateTime.Now.AddHours(-1)
                },
                new()
                {
                    Id = 5,
                    SaldoActual = 320000,
                    UltimaExtraccion = DateTime.Now
                },
                new()
                {
                    Id = 6,
                    SaldoActual = 234500,
                    UltimaExtraccion = DateTime.Now.AddHours(-4)
                },
                new()
                {
                    Id = 7,
                    SaldoActual = 570000,
                    UltimaExtraccion = DateTime.Now
                },
                new()
                {
                    Id = 8,
                    SaldoActual = 800023,
                    UltimaExtraccion = DateTime.Now.AddMinutes(-5)
                },
                new()
                {
                    Id = 9,
                    SaldoActual = 600230,
                    UltimaExtraccion = DateTime.Now
                },
                new()
                {
                    Id = 10,
                    SaldoActual = 156500,
                    UltimaExtraccion = DateTime.Now.AddHours(-7)
                },
                new()
                {
                    Id = 11,
                    SaldoActual = 23000,
                    UltimaExtraccion = DateTime.Now
                },
                new()
                {
                    Id = 12,
                    SaldoActual = 400,
                    UltimaExtraccion = DateTime.Now.AddDays(-7)
                },
                new()
                {
                    Id = 13,
                    SaldoActual = 267500,
                    UltimaExtraccion = DateTime.Now
                },
                new()
                {
                    Id = 14,
                    SaldoActual = 1234300,
                    UltimaExtraccion = DateTime.Now.AddDays(1)
                }
            };
        }
    }
}
