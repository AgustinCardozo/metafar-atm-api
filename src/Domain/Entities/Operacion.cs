namespace Domain.Entities
{
    public class Operacion
    {
        public int Id { get; set; }
        public double SaldoActual { get; set; }
        public DateTime? UltimaExtraccion { get; set; }
    }
}
