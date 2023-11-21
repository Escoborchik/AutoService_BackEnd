using Autoservice_Back.Interfaces;
using AutoService_BackEnd.DTO;
using Microsoft.AspNetCore.Mvc;

namespace AutoService_BackEnd.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AutentificationController : Controller
    {
        [HttpPost]
        public IActionResult Autentificate([FromBody] DataUser dataUser, [FromServices] IClients reposclient)
        {
            var allclients = reposclient.GetClients();
            int client_id = 0;
            foreach (var client in allclients)
            {
                if (client.Phone.Equals(dataUser.Phone) && client.Password.Equals(dataUser.Password))
                {
                    client_id = client.Id;
                }
                else
                {
                    client_id = -1;
                }
            }
            if (client_id == -1)
            {
                return new StatusCodeResult(401);
            }
            else
            {
                return Ok(client_id);
            }
            
        }
    }
}
