using Domain.Entities;

namespace Application.Models.Responses
{
    public class OperacionResponse
    {
        public int NumeroDeCuenta { get; set; }
        public string NumeroDeTarjeta { get; set; }
        public string NombreDeUsuario { get; set; }
        public List<Operacion> Operaciones { get; set; } = [];
        public class Operacion
        {
            public double SaldoActual { get; set; }
            public DateTime? UltimaExtraccion { get; set; }
        }
    }
}
