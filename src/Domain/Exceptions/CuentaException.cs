namespace Domain.Exceptions
{
    public class CuentaException : Exception
    {
        public CuentaException() : base() { }
        public CuentaException(string message) : base(message) { }
        public CuentaException(string message, Exception innerException) : base(message, innerException) { }
    }
}
