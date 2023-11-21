using System.Text.Json.Serialization;

namespace AutoService_BackEnd.DTO
{
    public class DataUser
    {
        [JsonPropertyName("Phone")]
        public string Phone { get; set; }

        [JsonPropertyName("Password")]
        public string Password { get; set; }

         
    }
}
