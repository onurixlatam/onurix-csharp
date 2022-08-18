//Este codigo fue hecho en .net 6

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
                { "country-code","CO"}

            };
            SendSMS(parameters);

        }

        public static void SendSMS(Dictionary<string,string> parameters)
        {
            using var httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://www.onurix.com"),
            };
            HttpResponseMessage request = httpClient.PostAsync("/api/v1/send-sms", new FormUrlEncodedContent(parameters)).Result;
            string responseString = request.Content.ReadAsStringAsync().Result;
        }
    }
}