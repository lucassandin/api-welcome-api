using Domain.Model;
using Domain.Service.Interface;
using Domain.Util;
using Microsoft.Extensions.Logging;

namespace Domain.Service
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

        public Result? GetRandomWelcomeMessage()
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

            return new Result
            {
                Message = message
            };
        }
    }
}
