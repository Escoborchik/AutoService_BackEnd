using Autoservice_Back.Interfaces;
using AutoService_BackEnd.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Services;
using System.Linq.Expressions;

namespace AutoService_BackEnd.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AutentificationController : Controller
    {
        [HttpPost]
        public IActionResult Autentificate([FromBody] DataUser dataUser, [FromServices] IClients reposclient,
            [FromServices] IOrders reposorder)
        {
            var answer = new AnswerAutentic();
            var allclients = reposclient.GetClients().ToList();
            foreach (var client in allclients)
            {
                if (client.Phone.Equals(dataUser.Phone) && client.Password.Equals(dataUser.Password))
                {
                    answer.Client_id = client.Id;
                    answer.Name = client.Name;
                    answer.SurName = client.Surname;
                    answer.SecondName = client.SecondName;
                    answer.ToNotify = reposorder.GetHistoryOrders(client.Id).Where(order => NotifyController.Works.Contains(order.Work))
                        .Any(order => DateTime.Now - order.Start > TimeSpan.FromMinutes(1));
                    break;
                }
                else if (client.Phone.Equals(dataUser.Phone))
                {
                    answer.Client_id = -2;
                }
                else
                {
                    answer.Client_id = -1;
                }
            }

            if (answer.Client_id == -1)
            {
                return new StatusCodeResult(404);
            }
            else if(answer.Client_id == -2)
            {
                return new StatusCodeResult(401);
            }
            else
            {
                return Ok(answer);
            }

        }
    }

}
