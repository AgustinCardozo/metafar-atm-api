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
                    Id = new Guid(),
                    NombreDeUsuario = "Pepe Argento",
                    Cuentas = new()
                    {
                        CuentaExtension.GetCuenta()
                    }
                },
                new()
                {
                    Id = new Guid(),
                    NombreDeUsuario = "Marcelo Gallardo",
                    Cuentas = CuentaExtension.GetCuentas()
                },
                new()
                {
                    Id = new Guid(),
                    NombreDeUsuario = "Dardo Fuseneco"
                }
            };
        }
    }
}
