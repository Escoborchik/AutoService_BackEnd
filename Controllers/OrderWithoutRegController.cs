
using Autoservice_Back.Interfaces;
using Autoservice_Back.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Autoservice_Back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderWithoutRegController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post([FromBody] OrderWithoutReg orderNoReg, [FromServices] IOrdersWithoutReg repos)
        {
             repos.AddOrderWithoutReg(orderNoReg);
             return Ok();
        }
    }
}
