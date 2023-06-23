using AutoMapper;
using FiveS.Entities.Dtos;
using FiveS.Entities.Entities;

namespace FiveS.WebApi.Utilities.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDto>().ReverseMap(); ;

        }
    }
}
