using System.Runtime.CompilerServices;

namespace Application.Models.Errors
{
    public static class ErrorMessage
    {
        public const string SALDO_INSUFIENTE = "Saldo insuficiente";
        public const string PIN_INVALIDO = "Pin inválido. Vuelva a intentarlo";
        public const string FALLA_MIGRACION = "Fallo en la migracion de datos";

        public static string GetErrorMessage(string message)
        {
            return message;
        }
    }
}
