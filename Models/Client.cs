using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Autoservice_Back.Models
{
    public class Client
    {
        [Key]
        [JsonIgnore]
        public int Id { get; set; }        
        public string Name { get; set; }
        public string Surname { get; set; }
        public string SecondName { get; set; }
        public string Password { get; set; }
        public string Telegram { get; set; }
        public string Phone { get; set; }

        [JsonIgnore]
        public List<Order> Orders { get; set; } = new List<Order>();

        

    }
}
