//Este codigo fue hecho en .net 6
using System.Net.Http;

namespace PruebaOnurix
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GroupList("AQUI_SU_KEY", "AQUI_SU_ID");
        }

        public static void GroupList(string key ,string client)
        {
            using var httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://www.onurix.com/"),
            };
            HttpResponseMessage request = httpClient.GetAsync($"api/v1/group/list?key={key}&client={client}").Result;
            string responseString = request.Content.ReadAsStringAsync().Result;
            Console.WriteLine(responseString);
        }
    }
}