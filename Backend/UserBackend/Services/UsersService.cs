using UserBackend.Interfaces;
using UserBackend.Models;

namespace UserBackend.Services
{
    public class UsersService : IUsersService
    {
        private readonly UserContext _userContext;

        public UsersService(UserContext userContext)
        {
            _userContext = userContext;
        }

        public User GetUser(int id) => _userContext.Users.Find(id);

        public User GetUser(string email)
        {
            return _userContext.Users.FirstOrDefault(usr => usr.Email == email);
        }

        public List<User> GetUsers()
        {
            if (_userContext == null) 
                return new List<User>();
            return _userContext.Users.ToList();
        }
    }
}
