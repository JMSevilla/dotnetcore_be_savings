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
    public class ClientController : ControllerBase
    {
        private readonly IClientRepository _clientRepository;
        private readonly IUsersRepository _usersRepository;
        public ClientController(IClientRepository clientRepository, IUsersRepository usersRepository)
        {
            _clientRepository = clientRepository ??
                throw new ArgumentNullException(nameof(clientRepository));
            _usersRepository = usersRepository ??
                throw new ArgumentNullException(nameof(usersRepository)); ;
        }
        [HttpPost]
        [Route("open-account")]
        public async Task<IActionResult>Post(Client client)
        {
            var result = await _clientRepository.openAccount(client);
            if(result.id == 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Something Went Wrong");
            }
            return Ok("Successfully Open an account");
        }
    }
}
