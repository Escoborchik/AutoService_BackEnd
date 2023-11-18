using Autoservice_Back.Interfaces;
using Autoservice_Back.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Autoservice_Back.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientRegController : Controller
    {
        [HttpPost]
        public IActionResult Post([FromBody] Client client, [FromServices] IClients repos)
        {
            repos.AddClient(client);
            return Ok();
        }

    }
}
