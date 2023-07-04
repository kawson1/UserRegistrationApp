using Microsoft.AspNetCore.Mvc;
using UserBackend.Interfaces;
using UserBackend.Models;
using UserBackend.Services;

namespace UserBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _usersService;
        public UsersController(IUsersService usersService) 
        { 
            _usersService = usersService;
        }

        [HttpGet]
        public List<User> GetUsers()
        {
            var users = _usersService.GetUsers();
            return users;
        }
    }
}
