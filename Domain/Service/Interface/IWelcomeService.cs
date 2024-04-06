using Domain.Model;

namespace Domain.Service.Interface
{
    public interface IWelcomeService
    {
        /// <summary>
        /// Get a random welcome message
        /// </summary>
        /// <returns></returns>
        Result? GetRandomWelcomeMessage();
    }
}
