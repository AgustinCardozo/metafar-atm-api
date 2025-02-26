namespace Common.Services.Interfaces
{
    public interface IJwtTokenService
    {
        string Authenticate(string numeroDeTarjeta);
    }
}
