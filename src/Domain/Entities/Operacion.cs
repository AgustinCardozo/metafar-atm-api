using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Operacion
    {
        public int Id { get; set; }
        public double SaldoActual { get; set; }
        public DateTime? UltimaExtraccion { get; set; }
        [ForeignKey("NumeroDeCuenta")]
        public int NumeroDeCuenta { get; set; }
        public Cuenta Cuenta { get; set; }
    }
}
