//Este codigo fue hecho en .net 6
using System.Net.Http;

namespace PruebaOnurix
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ContactDelete("AQUI_SU_CLIENT", "AQUI_SU_KEY", "AQUI_ID_CONTACTO");
        }

        public static void ContactDelete(String client,String key,String contactId)
        {
            using var httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://www.onurix.com/"),
            };
            HttpResponseMessage request = httpClient.DeleteAsync($"api/v1/contacts/delete?key={key}&client={client}&id={contactId}").Result;
            string responseString = request.Content.ReadAsStringAsync().Result;
            Console.WriteLine(responseString);
        }
    }
}