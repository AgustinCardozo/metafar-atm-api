using Domain.Entities;
using Infrastructure.Extensions;

namespace Infrastructure.Persistence.Configurations
{
    public static class DataConfiguration
    {
        public static async Task SetupDataAsync(AtmContext context)
        {
            if (!context.Usuarios.Any())
            {
                List<Usuario> usuarios = UsuarioExtension.GetUsuarios();
                await context.Usuarios.AddRangeAsync(usuarios);
                await context.SaveChangesAsync();
            }

            if (!context.Cuentas.Any())
            {
                List<Cuenta> cuentas = CuentaExtension.GetCuentas();
                await context.Cuentas.AddRangeAsync(cuentas);
                //await context.SaveChangesAsync();
            }

            if (!context.Operaciones.Any())
            {
                List<Operacion> operaciones = OperacionExtension.GetOperaciones();
                await context.Operaciones.AddRangeAsync(operaciones);
                await context.SaveChangesAsync();
            }
        }

        private static bool SonContextosValidos(AtmContext context)
        {
            return context.Usuarios.Any() && context.Cuentas.Any() && context.Operaciones.Any();
        }
    }
}
