using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Operacion
    {
        [Key]
        public Guid Id { get; set; }
        public double SaldoActual { get; set; }
        public DateTime? UltimaExtraccion { get; set; }
        [ForeignKey("NumeroDeCuenta")]
        public int NumeroDeCuenta { get; set; }
        public Cuenta Cuenta { get; set; }
    }
}
