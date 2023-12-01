using Autoservice_Back.DTO;
using Autoservice_Back.Interfaces;
using Autoservice_Back.Models;
using AutoService_BackEnd.DTO;
using Microsoft.AspNetCore.Mvc;

namespace Autoservice_Back.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : Controller
    {
        [HttpPost]
        public IActionResult Post([FromBody] OrderWithCar order, [FromServices] IClients reposClient,
            [FromServices] ICars reposCars , [FromServices] IOrders reposOrders)
        {
            var client = reposClient.GetClient(order.CLient_Id) ;
            var car = new Car()
            {
                Vin = order.Vin,
                StateNumber = order.StateNumber,
                MileAge = order.MileAge,                
            };
            reposCars.AddCar(car);
            var innerorder = new Order()
            {
                Description = order.Description,
                Work = order.Work,
                Client = client,
                Car = car,
            };            
            reposOrders.AddOrder(innerorder);
            return Ok();

        }

        [HttpGet("History")]
        public IActionResult GetOrderHistory([FromServices] IOrders reposorder,
            [FromQuery] int id )
        {
            var list = reposorder.GetHistoryOrders(id);            
            return Ok(GetAnswers(list));
        }

        [HttpGet("Active")]
        public IActionResult GetActiveOrder([FromServices] IOrders reposorder,
            [FromQuery] int id)
        {
            var list = reposorder.GetActiveOrders(id);
            return Ok(GetAnswers(list));             
        }

        private static IEnumerable<AnswerGetOrder> GetAnswers(IEnumerable<Order> list)
        {
            var answerlist = new List<AnswerGetOrder>();
            foreach (var order in list)
            {
                var answer = new AnswerGetOrder()
                {
                    Description = order.Description,
                    IsActive = order.IsActive,
                    Start = order.Start,
                    End = order.End,
                    Result = order.Result,                                                                
                    MileAge = order.Car.MileAge,
                    StateNumber = order.Car.StateNumber,
                    Vin = order.Car.Vin,
                    Work = order.Work
                    
                };
                answerlist.Add(answer);
            }

            return answerlist;
        }
    }
}
