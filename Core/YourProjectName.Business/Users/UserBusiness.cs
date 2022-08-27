using YourProjectName.Domain.Adapters;
using YourProjectName.Domain.Adapters.Dtos;
using YourProjectName.Domain.Business;

namespace YourProjectName.Business.Users
{
    public class UserBusiness : IUserBusiness
    {
        private readonly IUserAdapter _userAdapter;

        public UserBusiness(IUserAdapter userAdapter)
        {
            _userAdapter = userAdapter;
        }

        public IEnumerable<UserDto> GetList()
        {
            return _userAdapter.GetList();
        }

        public UserDto Get(int id)
        {
            return _userAdapter.Get(id);
        }

        public async Task<bool> Add(UserDto user)
        {
            return await _userAdapter.Add(user);
        }

        public bool Update(UserDto user)
        {
            return _userAdapter.Update(user);
        }

        public bool Delete(int id)
        {
            return _userAdapter.Delete(id);
        }
    }
}
