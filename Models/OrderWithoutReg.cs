 using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Text.Json.Serialization;

namespace Autoservice_Back.Models
{
    public class OrderWithoutReg
    {
        [Key]
        [JsonIgnore]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Telegram { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }
        public string Vin { get; set; }
        public string StateNumber { get; set; } 

    }
}
