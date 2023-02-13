using BSbankcore.Authentication;
using BSbankcore.Model;
using BSbankcore.Repository.Injects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BSbankcore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ServiceFilter(typeof(ApiKeyAuthFilter))]
    public class UsersController : ControllerBase
    {
        private readonly IUsersRepository _usersRepository;
        public UsersController(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }
        [Route("add-users"), HttpPost]
        public async Task<IActionResult>addUser(Users users)
        {
            var result = await _usersRepository.createUser(users);
            if (result.id == 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Something Went Wrong");
            }
            return Ok("Successfully add user");
        }
    }
}
