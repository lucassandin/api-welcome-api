using AutoMapper;
using Domain.WelcomeContext.Dto;
using Domain.WelcomeContext.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.v1
{
    [ApiController]
    [Route("api/v1/welcome")]
    public class WelcomeController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IWelcomeService _welcomeService;

        public WelcomeController(
            IMapper mapper,
            IWelcomeService welcomeService)
        {
            _mapper = mapper
                ?? throw new ArgumentNullException(nameof(mapper));

            _welcomeService = welcomeService
                ?? throw new ArgumentNullException(nameof(welcomeService));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("random")]
        [ProducesResponseType<WelcomeDto>(StatusCodes.Status200OK)]
        [ProducesResponseType<ErrorDto>(StatusCodes.Status400BadRequest)]
        public ActionResult<WelcomeDto> GetRandomWelcome()
        {
            var message =
                _welcomeService.GetRandomWelcomeMessage();

            if (message == null)
            {
                return new BadRequestObjectResult(
                    new ErrorDto { Message = "" });
            }

            return _mapper.Map<WelcomeDto>(message);
        }
    }
}
