using AutoMapper;
using ChatApplication.Data.Entities;
using ChatApplication.Domain.Dtos;

namespace ChatApplication.Domain.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<Chat, ChatDto>();
            CreateMap<Message, MessageDto>();
        }
    }
}
