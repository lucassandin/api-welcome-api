using Domain.WelcomeContext.Model;

namespace Domain.WelcomeContext.Interface
{
    public interface IWelcomeService
    {
        /// <summary>
        /// Get a random welcome message
        /// </summary>
        /// <returns></returns>
        Welcome? GetRandomWelcomeMessage();
    }
}
