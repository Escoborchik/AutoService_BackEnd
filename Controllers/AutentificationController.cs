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
            //var answer = new AnswerAutentic();
            int client_id = 0;
            var allclients = reposclient.GetClients();            
            foreach (var client in allclients)
            {
                if (client.Phone.Equals(dataUser.Phone) && client.Password.Equals(dataUser.Password))
                {
                    //answer.Client_id = client.Id;
                    //answer.Name = client.Name;
                    //answer.SurName = client.Surname;
                    //answer.SecondName = client.SecondName;
                    client_id = client.Id;
                    break;
                }
                else
                {
                    //answer.Client_id = -1;
                }
            }
            if (/*answer.Client_id == -1*/  client_id == -1)
            {
                return new StatusCodeResult(401);
            }
            else
            {
                return Ok(/*answer*/client_id);
            }
            
        }
    }
   
}
