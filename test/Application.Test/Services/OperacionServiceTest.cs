using Application.Interfaces.Repositories;
using Application.Interfaces.Services;
using Domain.Entities;
using Infrastructure.Services;
using Moq;

namespace Infrastructure.Test.Services
{
    public class OperacionServiceTest
    {
        private readonly Mock<IOperacionRepository> _operacionRepository;
        private readonly Mock<ICuentaService> _cuentaService;
        private readonly OperacionService _operacionService;

        public OperacionServiceTest()
        {
            _operacionRepository = new Mock<IOperacionRepository>();
            _cuentaService = new Mock<ICuentaService>();
            _operacionService = new OperacionService(_operacionRepository.Object, _cuentaService.Object);
        }

        [Fact]
        public void AddOperacionSuccess()
        {
            _operacionRepository.Setup(x => x.Add(It.IsAny<Operacion>()));
            _operacionService.Add(new Operacion());
            _operacionRepository.Verify(x => x.Add(It.IsAny<Operacion>()), Times.Once);
        }

        [Fact]
        public void GetTop10Success()
        {
            _cuentaService.Setup(x => x.GetByTarjeta(It.IsAny<string>())).Returns(new Cuenta() { Operaciones = new List<Operacion>(), Usuario = new()});
            _operacionRepository.Setup(x => x.GetAll()).Returns(new List<Operacion>());
            var result = _operacionService.GetTop10("1234");
            Assert.NotNull(result);
        }

        [Fact]
        public void GetTop10Fail()
        {
            _cuentaService.Setup(x => x.GetByTarjeta(It.IsAny<string>())).Returns((Cuenta)null);
            var result = _operacionService.GetTop10("1234");
            Assert.Null(result);
        }
    }
}
