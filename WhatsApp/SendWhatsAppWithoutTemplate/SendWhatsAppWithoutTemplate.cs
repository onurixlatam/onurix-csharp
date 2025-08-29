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
            string key = "AQUI_SU_SECRET_KEY";
            string client = "AQUI_SU_CLIENT_ID";
            string jsonBody = @"{
                ""from_phone_meta_id"": ""AQUI_EL_META_ID_DEL_TELEFONO"",
                ""phone"": ""AQUI_EL_TELEFONO_DESTINO"",
                ""message"": {
                    ""type"" : ""text"",
                    ""value"": ""AQUI_EL_MENSAJE""
                }
            }";

            using var httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://www.onurix.com/"),
            };
            
            HttpResponseMessage request = httpClient.PostAsync($"api/v1/whatsapp/send_without_template?client={client}&key={key}", new StringContent(jsonBody, Encoding.UTF8, "application/json")).Result;
            string responseString = request.Content.ReadAsStringAsync().Result;
            Console.WriteLine(responseString);
        }
    }
}