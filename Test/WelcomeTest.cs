using Domain.Util;
using Domain.WelcomeContext.Interface;
using Domain.WelcomeContext.Model;
using Domain.WelcomeContext.Service;
using Microsoft.Extensions.Logging;
using Moq;

namespace Test
{
    public class WelcomeTest
    {
        private readonly IWelcomeService _welcomeService;
        private readonly ILogger<WelcomeService> _logger;

        public WelcomeTest()
        {
            _logger = new Mock<ILogger<WelcomeService>>().Object;

            _welcomeService = new WelcomeService(_logger);
        }

        [Fact]
        [Trait("Categoria", nameof(IWelcomeService))]
        [Trait(nameof(IWelcomeService.GetRandomWelcomeMessage), "Sucesso")]
        [Trait("Descrição", "Obtém os dados de boas vindas aleatória")]
        public void Get_Random_Welcome_Message_Sucesso()
        {
            var result = 
                Phrase.GetRandomWelcomeMessage();

            Assert.IsType<string>(result);
            Assert.NotEmpty(result);
        }

        [Fact]
        [Trait("Categoria", nameof(IWelcomeService))]
        [Trait(nameof(IWelcomeService.GetRandomWelcomeMessage), "Sucesso")]
        [Trait("Descrição", "Obtém os dados de boas vindas aleatória")]
        public void Get_Random_Welcome_Message_Service_Sucesso()
        {
            var result = 
                _welcomeService.GetRandomWelcomeMessage();

            Assert.IsType<Welcome>(result);
            Assert.NotNull(result);
        }
    }
}