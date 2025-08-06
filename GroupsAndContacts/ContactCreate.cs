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
                { "name","AQUI_EL_NOMBRE_DE_CONTACTO" },
                { "lastname","AQUI_EL_APELLIDO_DE_CONTACTO" },
                { "phone", "AQUI_TELEFONO_DE_CONTACTO" },
                { "email", "AQUI_EMAIL_DE_CONTACTO" },
            };

            ContactCreate(map);
        }

        public static void ContactCreate(Dictionary<String,String> parameters)
        {
            using var httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://www.onurix.com/"),
            };
            HttpResponseMessage request = httpClient.PostAsync($"api/v1/contacts/create",new FormUrlEncodedContent(parameters)).Result;
            string responseString = request.Content.ReadAsStringAsync().Result;
            Console.WriteLine(responseString);
        }
    }
}