using UserBackend.Models;

namespace UserBackend.Interfaces
{
    public interface IUsersService
    {
        public List<User> GetUsers();
        public User GetUser(int id);
        public User GetUser(string email);
    }
}
