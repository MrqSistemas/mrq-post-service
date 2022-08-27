using AutoMapper;
using YourProjectName.Domain.Adapters.Dtos;
using YourProjectName.Domain.Entities.Users;

namespace YourProjectName.Repository.Users.Mappers
{
    public class UserMapper : Profile
    {
        public UserMapper()
        {
            CreateMap<User, UserDto>()
                .ReverseMap();
        }
    }
}
