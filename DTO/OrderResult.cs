using System.Text.Json.Serialization;

namespace AutoService_BackEnd.DTO
{
    public class OrderResult
    {
        [JsonPropertyName("Client_Id")]
        public int CLient_Id { get; set; }

        [JsonPropertyName("Id")]
        public int Id { get; set; }

        [JsonPropertyName("Result")]
        public string Result { get; set; }
    }
}
