using Domain.Entities;

namespace Infrastructure.Seeds
{
    public static class UsuarioSeed
    {
        public static List<Usuario> GetUsuarios()
        {
            return new List<Usuario>()
            {
                new Usuario()
                {
                    Id = new Guid("2ccef8f6-fe86-4e8d-a24b-6bd14f278e99"),
                    NombreDeUsuario = "Benito Camela"
                }
            };
        }
    }
}
