using YourProjectName.Domain.Adapters.Dtos;
using YourProjectName.Domain.Business;

namespace YourProjectName.Application.Applications
{
    public class UserApplication : IUserApplication
    {
        private readonly IUserBusiness _userBusiness;

        public UserApplication(IUserBusiness userBusiness)
        {
            _userBusiness = userBusiness;
        }

        public IEnumerable<UserDto> GetList()
        {
            return _userBusiness.GetList();
        }

        public UserDto Get(int id)
        {
            return _userBusiness.Get(id);
        }

        public Task<bool> Add(UserDto user)
        {
            return _userBusiness.Add(user);
        }

        public bool Update(UserDto user)
        {
            return _userBusiness.Update(user);
        }

        public bool Delete(int id)
        {
            return _userBusiness.Delete(id);
        }
    }
}
