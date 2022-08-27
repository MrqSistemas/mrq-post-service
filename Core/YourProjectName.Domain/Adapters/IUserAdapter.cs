using YourProjectName.Domain.Adapters.Dtos;

namespace YourProjectName.Domain.Adapters
{
    public interface IUserAdapter
    {
        public IEnumerable<UserDto> GetList();
        public UserDto Get(int id);
        public Task <bool> Add(UserDto user);
        public bool Update(UserDto user);
        public bool Delete(int id);
    }
}
