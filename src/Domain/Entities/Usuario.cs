namespace Domain.Entities
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string NombreDeUsuario { get; set; }
        public List<Cuenta> Cuentas { get; set; }
    }
}
