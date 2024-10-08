//Este codigo fue hecho en .net 6
using System.Net.Http;

namespace PruebaOnurix
{
    public class Program
    {
        public static void Main(string[] args)
        {
          
            GroupDelete("AQUI_SU_CLIENT", "AQUI_SU_KEY", "AQUI_ID_GRUPO");
        }

        public static void GroupDelete(String client,String key,String id)
        {
            using var httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://www.onurix.com/"),
            };
            HttpResponseMessage request = httpClient.DeleteAsync($"api/v1/group/delete?key={key}&client={client}&id={id}").Result;
            string responseString = request.Content.ReadAsStringAsync().Result;
            Console.WriteLine(responseString);
        }
    }
}