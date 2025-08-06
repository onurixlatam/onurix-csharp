//Este codigo fue hecho en .net 6
using System.Net.Http;

namespace PruebaOnurix
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<String, String> map = new()
            {
                { "client", "AQUI_SU_CLIENT" },
                { "key", "AQUI_SU_KEY" },
                { "id", "AQUI_ID_GRUPO" },
                { "name","AQUI_EL_NOMBRE_DE_GRUPO" },
            };

            GroupUpdate(map);
        }

        public static void GroupUpdate(Dictionary<String,String> parameters)
        {
            using var httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://www.onurix.com/"),
            };
            HttpResponseMessage request = httpClient.PostAsync($"api/v1/group/update",new FormUrlEncodedContent(parameters)).Result;
            string responseString = request.Content.ReadAsStringAsync().Result;
            Console.WriteLine(responseString);
        }
    }
}