using Application.Interfaces.Repositories;
using Domain.Entities;
using Infrastructure.Services;
using Moq;

namespace Infrastructure.Test.Services
{
    public class CuentaServiceTest
    {
        private readonly Mock<ICuentaRepository> _cuentaRepository;
        private readonly Mock<IOperacionRepository> _operacionRepository;
        private readonly Mock<IUsuarioRepository> _usuarioRepository;
        private readonly CuentaService _cuentaService;

        public CuentaServiceTest()
        {
            _cuentaRepository = new Mock<ICuentaRepository>();
            _operacionRepository = new Mock<IOperacionRepository>();
            _usuarioRepository = new Mock<IUsuarioRepository>();
            _cuentaService = new CuentaService(_cuentaRepository.Object, _operacionRepository.Object, _usuarioRepository.Object);
        }

        [Fact]
        public void AddCuentaSucces()
        {
            _cuentaRepository.Setup(x => x.Add(It.IsAny<Cuenta>()));
            _cuentaService.Add(new Cuenta());
            _cuentaRepository.Verify(x => x.Add(It.IsAny<Cuenta>()), Times.Once);
        }

        [Theory]
        [InlineData(1235, 0)]
        [InlineData(1234, 5)]
        public void ValidateSuccess(int pin, int cantidadDeIntentos)
        {
            var cuenta = new Cuenta { Pin = pin, CantidadDeIntentos = cantidadDeIntentos, Bloqueado = false };
            var result = _cuentaService.Validate(1234, cuenta);
            Assert.False(result);
        }

        [Fact]
        public void GetByTarjetaSuccess()
        {
            _cuentaRepository.Setup(x => x.GetByTarjeta(It.IsAny<string>())).Returns(new Cuenta() { Usuario = new() { NombreDeUsuario = "test" } });
            _operacionRepository.Setup(x => x.GetAll()).Returns(new List<Operacion>());
            _usuarioRepository.Setup(x => x.GetById(It.IsAny<int>())).Returns(new Usuario());
            var result = _cuentaService.GetByTarjeta("1234");
            Assert.NotNull(result);
        }

        [Fact]
        public void GetByTarjetaFail()
        {
            _cuentaRepository.Setup(x => x.GetByTarjeta(It.IsAny<string>())).Returns((Cuenta)null);
            var result = _cuentaService.GetByTarjeta("1234");
            Assert.Null(result);
        }
    }
}
