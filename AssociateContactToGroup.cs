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
                { "group-id","AQUI_ID_DE_GRUPO" },
                { "id", "AQUI_ID_DE_CONTACTO" },
            };

            ContactGroupList(map);
        }

        public static void ContactGroupList(Dictionary<String,String> parameters)
        {
            using var httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://www.onurix.com/"),
            };
            HttpResponseMessage request = httpClient.PostAsync($"api/v1/contacts/group/add",new FormUrlEncodedContent(parameters)).Result;
            string responseString = request.Content.ReadAsStringAsync().Result;
            Console.WriteLine(responseString);
        }
    }
}