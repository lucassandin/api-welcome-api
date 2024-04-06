using Domain.Model;
using Domain.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace RandomWelcome.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WelcomeController : ControllerBase
    {
        private readonly IWelcomeService _welcomeService;

        public WelcomeController(IWelcomeService welcomeService)
        {
            _welcomeService = welcomeService 
                ?? throw new ArgumentNullException(nameof(welcomeService));
        }

        [HttpGet("/Random")]
        [ProducesResponseType<Welcome>(StatusCodes.Status200OK)]
        [ProducesResponseType<Error>(StatusCodes.Status400BadRequest)]
        public ActionResult<Welcome> GetRandomWelcome()
        {
            var message = 
                _welcomeService.GetRandomWelcomeMessage();

            if (message == null)
            {
                return new BadRequestObjectResult(
                    new Error { Message = "" });
            }

            return message;
        }
    }
}
