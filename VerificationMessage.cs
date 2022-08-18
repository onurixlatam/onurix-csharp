//Este codigo fue hecho en .net 6
using Newtonsoft.Json;

namespace PruebaOnurix
{
    public class Program
    {
        public static void Main(string[] args)
        {
            VerificationMessage("AQUI_SU_CLIENT", "AQUI_SU_KEY", "AQUI_SU_MENSAJE_ID");
        }

        public static void VerificationMessage(string client, string key,string idMensaje)
        {
            using var httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://www.onurix.com"),
            };
            HttpResponseMessage request = httpClient.GetAsync($"api/v1/messages-state?client={client}&key={key}&id{idMensaje}").Result;
            string responseString = request.Content.ReadAsStringAsync().Result;
        }
    }
}