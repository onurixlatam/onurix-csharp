//Este codigo fue hecho en .net 6
using System.Text;
using System.Net.Http;

namespace PruebaOnurix
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WhatsAppSendWithoutTemplate();
        }

        public static void WhatsAppSendWithoutTemplate()
        {
            string key = "416743ddb4694a3ec6bd0dd6642e53a6f610da956583ac374709e";
            string client = "1";
            string jsonBody = @"{
                ""from_phone_meta_id"": ""120769527678113"",
                ""phone"": ""3203711034"",
                ""message"": {
                    ""type"" : ""text"",
                    ""value"": ""Esto es un mensaje sin plantilla desde csharp""
                }
            }";

            using var httpClient = new HttpClient()
            {
                BaseAddress = new Uri("http://127.0.0.1:8001/"),
            };
            
            HttpResponseMessage request = httpClient.PostAsync($"api/v1/whatsapp/send_without_template?client={client}&key={key}", new StringContent(jsonBody, Encoding.UTF8, "application/json")).Result;
            string responseString = request.Content.ReadAsStringAsync().Result;
            Console.WriteLine(responseString);
        }
    }
}