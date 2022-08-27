using AutoMapper;
using YourProjectName.Domain.Adapters;
using YourProjectName.Domain.Adapters.Dtos;
using YourProjectName.Domain.Entities.Users;
using YourProjectName.Repository.Context;

namespace YourProjectName.Repository.Users
{
    public class UserRepositorySqlServer : IUserAdapter
    {
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;

        public UserRepositorySqlServer(AppDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }

        public IEnumerable<UserDto> GetList()
        {
            var users = _appDbContext.Users;

            var userDtos = _mapper.Map<List<UserDto>>(users);

            return userDtos;
        }

        public UserDto Get(int id)
        {
            var users = _appDbContext.Users;

            var getUser = users.Where(p => p.Id == id).FirstOrDefault();

            return _mapper.Map<UserDto>(getUser);
        }

        public async Task <bool> Add(UserDto user)
        {
            User addUser = _mapper.Map<User>(user);

            await _appDbContext.Set<User>().AddAsync(addUser);

            _appDbContext.SaveChanges();

            return true;
        }

        public bool Update(UserDto user)
        {
            User updateUser = _mapper.Map<User>(user);

            _appDbContext.Set<User>().Update(updateUser);

            _appDbContext.SaveChanges();

            return true;
        }

        public bool Delete(int id)
        {
            var user = _appDbContext.Users;

            User deleteUser = user.Where(p => p.Id == id).FirstOrDefault();

            _appDbContext.Remove(deleteUser);

            _appDbContext.SaveChanges();

            return true;
        }

    }
}
