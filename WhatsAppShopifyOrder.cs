//Este codigo fue hecho en .net 6
using System.Text;
using System.Net.Http;

namespace PruebaOnurix
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WhatsAppSend();
        }

        public static void WhatsAppSend()
        {
            string key = "AQUI_SU_KEY";
            string client = "AQUI_SU_CLIENT";
            string template = "AQUI_EL_NOMBRE_DE_LA_PLANTILLA";
            string parameters = "AQUI_EL_JSON_CON_LOS_VALORES_PARA_LA_PLANTILLA"
            using var httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://www.onurix.com/"),
            };
            HttpResponseMessage request = httpClient.PostAsync($"api/v1/whatsapp/shopify/order?client={client}&key={key}&template={template}", content: new StringContent(parameters, Encoding.UTF8, "application/json")).Result;
            string responseString = request.Content.ReadAsStringAsync().Result;
            Console.WriteLine(responseString);
        }
    }
}