using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [ForeignKey("UsuarioId")]
        public Guid UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public List<Operacion> Operaciones { get; set; }
    }
}
