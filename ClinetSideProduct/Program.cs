using System.Net.Http.Json;
using static System.Net.WebRequestMethods;

namespace ClinetSideProduct;

internal class Program
{
    static void Main(string[] srgs)
    {
        string url = "https://localhost:44379/swagger/index.html";

        HttpClient client = new HttpClient();
        var res = client.GetAsync(url).Result;

        if (res.StatusCode == System.Net.HttpStatusCode.OK)
        {
            var result= res.Content.ReadFromJsonAsync<List<item>>().Result;
            foreach(var items in result)
            {
                Console.WriteLine(items.Name);
            }
        }
    }
}
