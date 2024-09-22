namespace Domain.Entities
{
    public class Operacion
    {
        public Guid Id { get; set; }
        public double SaldoActual { get; set; }
        public DateTime? UltimaExtraccion { get; set; }
    }
}
