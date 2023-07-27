//Este codigo fue hecho en .net 6
using System.Net.Http;
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
                { "phone", "AQUI_EL_NUMERO_DE_CELULAR"},
                { "message", "AQUI_EL_MENSAJE_A_ENVIAR"},
                { "voice", "AQUI_TIPO_DE_VOZ" },
                { "retries", "AQUI_NUMERO_DE_INTENTOS"},
                { "leave-voicemail","AQUI_CONFIRMACION_BUZON_DE_VOZ"},
                //{ "audio-code","AQUI_ID_AUDIO"},
                { "groups","AQUI_ID_GRUPO"}

            };
            SendCall(parameters);

        }

        public static void SendCall(Dictionary<string,string> parameters)
        {
            using var httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://www.onurix.com"),
            };
            HttpResponseMessage request = httpClient.PostAsync("api/v1/call/send", new FormUrlEncodedContent(parameters)).Result;
            string responseString = request.Content.ReadAsStringAsync().Result;
            Console.WriteLine(responseString);
        }
    }
}