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
                { "name-url", "AQUI_NOMBE_DE_URL"},
                { "since","Fecha inicial YYYY-MM-DD"},
                { "until","Fecha final YYYY-MM-DD"}

            };
            GetStatistics(parameters);

        }

        public static void GetStatistics(Dictionary<string,string> parameters)
        {
            using var httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://www.onurix.com"),
            };
            HttpResponseMessage request = httpClient.PostAsync("/api/v1/url/short-statistic", new FormUrlEncodedContent(parameters)).Result;
            string responseString = request.Content.ReadAsStringAsync().Result;
            Console.WriteLine(responseString);
        }
    }
}