using Microsoft.AspNetCore.Mvc;

namespace Zookeeper.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class WelcomeController : ControllerBase
    {
        [HttpGet(Name = "GetWelcome")]
        public string Get()
        {
            return "Welcome to the Zoo!";
        }
    }
}
