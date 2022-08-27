using YourProjectName.Domain.Adapters.Dtos;

namespace YourProjectName.Domain.Business
{
    public interface IUserBusiness
    {
        public IEnumerable<UserDto> GetList();
        public UserDto Get(int id);
        public Task<bool> Add(UserDto user);
        public bool Update(UserDto user);
        public bool Delete(int id);
    }
}
