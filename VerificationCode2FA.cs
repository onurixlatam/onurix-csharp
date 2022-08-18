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
                { "app-name", "AQUI_NOMBRE_APP"},
                { "code", "AQUI_CODIGO"},
                { "country-code", "CO"}

            };
            VerificationCode2FA(parameters);

        }

        public static void VerificationCode2FA(Dictionary<string,string> parameters)
        {
            using var httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://www.onurix.com"),
            };
            HttpResponseMessage request = httpClient.PostAsync("/api/v1/2fa/verification-code", new FormUrlEncodedContent(parameters)).Result;
            string responseString = request.Content.ReadAsStringAsync().Result;
            Console.WriteLine(responseString);
        }
    }
}