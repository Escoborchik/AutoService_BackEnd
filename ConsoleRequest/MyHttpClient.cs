using System;


namespace AutoService_BackEnd.ConsoleRequest
{
    public class MyHttpClient<T>
    {
        static readonly HttpClient httpClient = new();
        static async Task Send(T order)
        {                       
            using var response = await httpClient.PostAsJsonAsync("https://localhost:7094/api/users/", order);          
            var statusanswer = response.StatusCode;
            Console.WriteLine(response.StatusCode);         
        }


    }
}
// TODO: DTO модель для передачи на веб-консоль