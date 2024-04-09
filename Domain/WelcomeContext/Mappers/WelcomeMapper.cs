using AutoMapper;
using Domain.WelcomeContext.Dto;
using Domain.WelcomeContext.Model;

namespace Domain.WelcomeContext.Mappers
{
    public class WelcomeMapper : Profile
    {
        public WelcomeMapper()
        {
            CreateMap<Welcome, WelcomeDto>();
            CreateMap<Error, ErrorDto>();
        }
    }
}
