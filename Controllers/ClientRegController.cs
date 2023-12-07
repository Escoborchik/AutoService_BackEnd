using Autoservice_Back.Interfaces;
using Autoservice_Back.Models;
using AutoService_BackEnd.Controllers;
using AutoService_BackEnd.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Autoservice_Back.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientRegController : Controller
    {
        [HttpPost]
        public IActionResult Post([FromBody] Client client, [FromServices] IClients repos)
        {
            var allclients = repos.GetClients().ToList();
            foreach (var item in allclients)
            {
                 if(item.Phone.Equals(client.Phone))
                 {
                    return new StatusCodeResult(404);                    
                 }
            }
            repos.AddClient(client);
            return Ok();
        }

    }
}
