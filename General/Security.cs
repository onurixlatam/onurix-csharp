//Este codigo fue hecho en .net 6
using System.Net.Http;
namespace PruebaOnurix
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> parameters = new()
            {
                { "client", "AQUI_SU_CLIENT"},
                { "key", "AQUI_SU_KEY"},
                { "phone", "AQUI_EL_NUMERO_DE_CELULAR"},
                { "name", "AQUI_NOMBRE_CONTACTO"}
                { "channel", "AQUI_CANAL_A_BLOQUEAR"}
            };
            BlockPhone(parameters);

        }

        public static void BlockPhone(Dictionary<string,string> parameters)
        {
            using var httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://www.onurix.com"),
            };
            HttpResponseMessage request = httpClient.PostAsync("api/v1/block-phone", new FormUrlEncodedContent(parameters)).Result;
            string responseString = request.Content.ReadAsStringAsync().Result;
            Console.WriteLine(responseString);
        }
    }
}