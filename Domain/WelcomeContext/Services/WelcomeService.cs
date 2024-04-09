using Domain.Util;
using Domain.WelcomeContext.Interface;
using Domain.WelcomeContext.Model;
using Microsoft.Extensions.Logging;

namespace Domain.WelcomeContext.Service
{
    public class WelcomeService : IWelcomeService
    {
        private readonly ILogger<WelcomeService> _logger;

        public WelcomeService(
            ILogger<WelcomeService> logger)
        {
            _logger = logger
                ?? throw new ArgumentNullException(nameof(logger));
        }

        public Welcome? GetRandomWelcomeMessage()
        {
            _logger.LogInformation(
                $"Obtendo boas vindas aleatória...");

            var message = Phrase.GetRandomWelcomeMessage();

            if (message == string.Empty)
            {
                _logger.LogError(
                    "Erro ao obter mensagem aleatória de boas vindas");

                return null;
            }

            _logger.LogInformation(
                "Mensagem de boas vindas: {Mensagem}", message);

            return new Welcome
            {
                Message = message
            };
        }
    }
}
