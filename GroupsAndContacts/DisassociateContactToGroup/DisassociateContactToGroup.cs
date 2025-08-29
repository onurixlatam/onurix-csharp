//Este codigo fue hecho en .net 6
using System.Net.Http;

namespace PruebaOnurix
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DesassociateContactToGroup("AQUI_SU_CLIENT", "AQUI_SU_KEY", "AQUI_ID_GRUPO","AQUI_ID_CONTACTO");
        }

        public static void DesassociateContactToGroup(String client,String key,String groupId,String contactId)
        {
            using var httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://www.onurix.com/"),
            };
            HttpResponseMessage request = httpClient.DeleteAsync($"api/v1/contacts/group/remove?key={key}&client={client}&group-id={groupId}&id={contactId}").Result;
            string responseString = request.Content.ReadAsStringAsync().Result;
            Console.WriteLine(responseString);
        }
    }
}