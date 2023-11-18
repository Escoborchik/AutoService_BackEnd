using Autoservice_Back.DTO;
using Autoservice_Back.Interfaces;
using Autoservice_Back.Models;
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
                ManufactureYear = order.ManufactureYear,
            };
            reposCars.AddCar(car);
            var innerorder = new Order()
            {
                Description = order.Description,
                Client = client,
                Car = car,
            };            
            reposOrders.AddOrder(innerorder);
            return Ok();

        }

        [HttpGet]
        public IActionResult Get([FromServices] IOrders reposorder,
            [FromQuery] int id )
        {              
                        
            return Ok(reposorder.GetAllOrders(id));
        }
    }
}
