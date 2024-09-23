namespace Domain.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NombreDeUsuario { get; set; }
        public List<Cuenta> Cuentas { get; set; }
    }
}
