using Autoservice_Back.Models;
using System.Text.Json.Serialization;

namespace Autoservice_Back.DTO
{
    public class OrderWithCar
    {
        [JsonPropertyName("Client_id")]
        public int CLient_Id { get; set; }

        [JsonPropertyName("Vin")]
        public string Vin { get; set; }

        [JsonPropertyName("StateNumber")]
        public string StateNumber { get; set; }

        [JsonPropertyName("MileAge")]
        public int MileAge { get; set; }

        [JsonPropertyName("ManufactureYear")]
        public int ManufactureYear { get; set; }

        [JsonPropertyName("Description")]
        public string Description { get; set; }

    }
}
