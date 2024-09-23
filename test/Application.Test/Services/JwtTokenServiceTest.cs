using Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Moq;

namespace Infrastructure.Test.Services
{
    public class JwtTokenServiceTest
    {
        [Fact]
        public void AuthenticateSuccess()
        {
            var inMemorySettings = new Dictionary<string, string>
            {
                { "Jwt:Key", "Whosoever holds this hammer, if they be worthy, shall possess the power of Thor"}
            };

            IConfiguration configuration = new ConfigurationBuilder()
                .AddInMemoryCollection(inMemorySettings)
                .Build();

            var authService = new JwtTokenService(configuration);
            var numeroDeTarjeta = "1234567890123456";

            var token = authService.Authenticate(numeroDeTarjeta);

            Assert.NotNull(token);
            Assert.IsType<string>(token);
        }
    }
}
