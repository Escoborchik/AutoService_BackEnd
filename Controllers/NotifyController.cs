using Autoservice_Back.DTO;
using Autoservice_Back.Interfaces;
using Autoservice_Back.Models;
using AutoService_BackEnd.DTO;
using Microsoft.AspNetCore.Mvc;

namespace AutoService_BackEnd.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class NotifyController : Controller
    {
        public static List<string> Works = new()
        {
            "Замена моторного масло",
            "Замена воздушного фильтра",
            "Замена Свечи зажигания",
            "Замена ремня ГРМ",
            "Регулировка клапанов",
            "Замена рабочая жидкость в трансмиссии",
            "Замена салонного фильтра",
            "Осмотр ходовой части"
        };


        [HttpGet]
        public IActionResult GetOldOrders([FromServices] IOrders reposorder,
            [FromQuery] int id)
        {
            var list = reposorder.GetHistoryOrders(id).Where(order => DateTime.Now - order.Start > TimeSpan.FromMinutes(1));
            var notifies = new List<NotifyAnswer>();
            foreach (var item in list)
            {
                
                if (Works.Contains(item.Work)) 
                {
                    var notify = new NotifyAnswer() { DateTime = item.Start, Work = item.Work};
                    notifies.Add(notify);
                }
                
            }
            return Ok(notifies);
        }
    }
}