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
                { "id", "AQUI_ID_CONTACTO" },
                { "name","OPCIONAL_AQUI_EL_NOMBRE_DE_CONTACTO" },
                { "lastname","OPCIONAL_AQUI_EL_APELLIDO_DE_CONTACTO" },
                { "phone", "OPCIONAL_AQUI_TELEFONO_DE_CONTACTO" },
                { "email", "OPCIONAL_AQUI_EMAIL_DE_CONTACTO" },
            };

            ContactUpdate(map);
        }

        public static void ContactUpdate(Dictionary<String, String> parameters)
        {
            using var httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://www.onurix.com/"),
            };
            HttpResponseMessage request = httpClient.PostAsync($"api/v1/contacts/update", new FormUrlEncodedContent(parameters)).Result;
            string responseString = request.Content.ReadAsStringAsync().Result;
            Console.WriteLine(responseString);
        }
    }
}