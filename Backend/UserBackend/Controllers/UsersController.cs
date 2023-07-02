using Microsoft.AspNetCore.Mvc;

namespace UserBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public string Index()
        {
            return "TEST";
        }
    }
}
