namespace Application.ViewModels.Errors
{
    public static class ErrorMessage
    {
        public const string FALLA_MIGRACION = "Fallo en la migracion de datos.";
        public const string SALDO_INSUFIENTE = "Saldo insuficiente.";

        public static class Validations
        {
            public const string CUENTA_INACTIVA = "La cuenta se encuentra inactiva.";
            public const string CUENTA_BLOQUEADA = "La cuenta se encuentra bloqueada.";
            public const string PIN_INVALIDO = "Pin inválido. Vuelva a intentarlo.";
        }

        public static string GetErrorMessage(string message)
        {
            return message;
        }
    }
}
