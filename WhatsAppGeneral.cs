//Este codigo fue hecho en .net 6
using Newtonsoft.Json;

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
                { "template", "AQUI_EL_NOMBRE_DE_LA_PLANTILLA"},
                { "content", "AQUI_EL_JSON_CON_LOS_VALORES_PARA_LA_PLANTILLA"}
                //{ "content", "{\"phone\": \"573501234567\",\"body\": [\"Grupo Prueba\",\"Prueba\"]}"}
                
            };
            WhatsAppGeneral(parameters);

        }

        public static void WhatsAppGeneral(Dictionary<string, string> parameters)
        {
            using var httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://www.onurix.com"),
            };
            HttpResponseMessage request = httpClient.PostAsync("api/v1/whatsapp/send", new FormUrlEncodedContent(parameters)).Result;
            string responseString = request.Content.ReadAsStringAsync().Result;
        }
    }
}