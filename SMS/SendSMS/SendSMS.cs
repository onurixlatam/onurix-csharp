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
                { "sms","AQUI_EL_SMS_A_ENVIAR"},
                // Opcional. 1 (por defecto): mensaje transaccional. 0: mensaje comercial (publicidad, promociones);
                // los numeros inscritos en el Registro de Numeros Excluidos (RNE) que no aceptan SMS se rechazan con el error 1010.
                { "is-transactional", "1"},
            };
            SendSMS(parameters);
        }

        public static void SendSMS(Dictionary<string,string> parameters)
        {
            using var httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://www.onurix.com"),
            };
            HttpResponseMessage request = httpClient.PostAsync("/api/v1/sms/send", new FormUrlEncodedContent(parameters)).Result;
            string responseString = request.Content.ReadAsStringAsync().Result;
            Console.WriteLine(responseString);
        }
    }
}