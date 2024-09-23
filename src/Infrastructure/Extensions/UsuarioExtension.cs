using Domain.Entities;

namespace Infrastructure.Extensions
{
    public static class UsuarioExtension
    {
        public static List<Usuario> GetUsuarios()
        {
            return new List<Usuario>()
            {
                new()
                {
                    Id = 1,
                    NombreDeUsuario = "Pepe Argento"
                },
                new()
                {
                    Id = 2,
                    NombreDeUsuario = "Marcelo Gallardo"
                },
                new()
                {
                    Id = 3,
                    NombreDeUsuario = "Dardo Fuseneco"
                }
            };
        }
    }
}
