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
                { "name", "AQUI_NOMBRE_DE_URL"},
                { "url-long","AQUI_URL_LARGA"}
            };
            UrlShortener(parameters);

        }

        public static void UrlShortener(Dictionary<string,string> parameters)
        {
            using var httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://www.onurix.com"),
            };
            HttpResponseMessage request = httpClient.PostAsync("/api/v1/url/short", new FormUrlEncodedContent(parameters)).Result;
            string responseString = request.Content.ReadAsStringAsync().Result;
        }
    }
}