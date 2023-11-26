using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Autoservice_Back.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }     
        public string Vin { get; set; }
        public string StateNumber { get; set; }        
        public int MileAge { get; set; }      

        [JsonIgnore]
        public List<Order> Orders { get; set;}

        public Car()
        {
            Orders = new List<Order>();
        }

    }
}
