//Este codigo fue hecho en .net 6
using System.Net.Http;

namespace PruebaOnurix
{
    public class Program
    {
        public static void Main(string[] args)
        {

            ContactGroupList("AQUI_SU_CLIENT", "AQUI_SU_KEY", "AQUI_ID_GRUPO", "AQUI_NUMERO_PAGINA");
        }

        public static void ContactGroupList(string client,string key,string id, string page = "1")
        {
            using var httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://www.onurix.com/"),
            };
            HttpResponseMessage request = httpClient.GetAsync($"api/v1/group/{id}/contacts/list?key={key}&client={client}&page{page}").Result;
            string responseString = request.Content.ReadAsStringAsync().Result;
            Console.WriteLine(responseString);
        }
    }
}