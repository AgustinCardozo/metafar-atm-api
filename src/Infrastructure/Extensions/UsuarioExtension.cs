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
                    Id = new Guid("943a6dfc-99ab-49ee-9f44-48c8e6da71a2"),
                    NombreDeUsuario = "Pepe Argento"
                },
                new()
                {
                    Id = new Guid("cac3bf1b-63df-4d07-ade5-a45bf0d09ea9"),
                    NombreDeUsuario = "Marcelo Gallardo"
                },
                new()
                {
                    Id = new Guid("c7a9abed-adbd-4d90-91a9-4cdf1be65b07"),
                    NombreDeUsuario = "Dardo Fuseneco"
                }
            };
        }
    }
}
