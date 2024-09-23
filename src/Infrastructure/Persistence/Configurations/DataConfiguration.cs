using Domain.Entities;
using Infrastructure.Extensions;

namespace Infrastructure.Persistence.Configurations
{
    public static class DataConfiguration
    {
        public static async Task SetupDataAsync(AtmContext context)
        {
            if(SonContextosValidos(context))
            {
                return;
            }

            List<Usuario> usuarios = UsuarioExtension.GetUsuarios();
            await context.Usuarios.AddRangeAsync(usuarios);

            List<Cuenta> cuentas = CuentaExtension.GetCuentas();
            await context.Cuentas.AddRangeAsync(cuentas);

            List<Operacion> operaciones = OperacionExtension.GetOperaciones();
            await context.Operaciones.AddRangeAsync(operaciones);

            await context.SaveChangesAsync();
        }

        private static bool SonContextosValidos(AtmContext context)
        {
            return context.Usuarios.Any() || context.Cuentas.Any() || context.Operaciones.Any();
        }
    }
}
