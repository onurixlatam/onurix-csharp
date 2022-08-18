//Este codigo fue hecho en .net 6
namespace PruebaOnurix
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GetBalance("AQUI_SU_CLIENT", "AQUI_SU_KEY");
        }

        public static void GetBalance(string client, string key)
        {
            using var httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://www.onurix.com"),
            };
            HttpResponseMessage request = httpClient.GetAsync($"api/v1/balance?client={client}&key={key}").Result;
            string responseString = request.Content.ReadAsStringAsync().Result;
            if(!String.IsNullOrEmpty(responseString))
            {
                BalanceResponse balance = JsonConvert.DeserializeObject<BalanceResponse>(responseString);
            }
        }
    }
}