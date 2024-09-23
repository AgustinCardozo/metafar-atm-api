using Domain.Entities;
using Infrastructure.Extensions;

namespace Infrastructure.Persistence.Configurations
{
    public static class DataConfiguration
    {
        public static async Task SetupDataAsync(AtmContext context)
        {
            if(context.Usuarios.Any())
            {
                return;
            }

            List<Usuario> usuarios = UsuarioExtension.GetUsuarios();
            
            // Ensure that no duplicate tracking occurs
            foreach (var usuario in usuarios)
            {
                if (!context.Usuarios.Local.Any(u => u.Id == usuario.Id))
                {
                    context.Usuarios.Attach(usuario);
                }
            }

            await context.Usuarios.AddRangeAsync(usuarios);
            await context.SaveChangesAsync();
        }
    }
}
