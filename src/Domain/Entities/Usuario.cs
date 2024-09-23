using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Usuario
    {
        [Key]
        public Guid Id { get; set; }
        public string NombreDeUsuario { get; set; }
        public List<Cuenta> Cuentas { get; set; }
    }
}
