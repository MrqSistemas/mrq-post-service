using YourProjectName.Domain.Adapters.Dtos;

namespace YourProjectName.Application.Applications
{
    public interface IUserApplication
    {
        public IEnumerable<UserDto> GetList();
        public UserDto Get(int id);
        public Task<bool> Add(UserDto user);
        public bool Update(UserDto user);
        public bool Delete(int id);
    }
}
