using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Cuenta
    {
        [Key]
        public int NumeroDeCuenta { get; set; }
        [CreditCard]
        public string NumeroDeTarjeta { get; set; }
        public int Pin { get; set; }
        public int CantidadDeIntentos { get; set; }
        public bool Bloqueado { get; set; } = false;
        public List<Operacion> Operaciones { get; set; }
    }
}
