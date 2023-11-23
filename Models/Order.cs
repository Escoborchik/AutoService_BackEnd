using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Autoservice_Back.Models
{

    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime Start { get; set; } = DateTime.Now;
        public DateTime End { get; set; }
        public string Result { get; set; }
        public int ClientId { get; set; }

        [ForeignKey(nameof(ClientId))]
        public Client Client { get; set; }
        public int CarId { get; set; }

        [ForeignKey(nameof(CarId))]
        public Car Car { get; set; }
    }
}
