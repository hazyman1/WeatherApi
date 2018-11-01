using System;
using Newtonsoft.net

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What Zip?");
            int answer = int.Parse(Console.ReadLine();
            Console.Clear();

            WebClient webClient = new WebClient();
            string apiKey = "" //FileStyleUriParser.ReadAllText("Path to file");
            string fullApi = $""

            string apiResponse = webClient.DownloadString(fullApi);
            JObject jo = JObject.Parse(apiResponse);
            double temp = double.Parse(jo.GetValue("main")["temp"].ToString());

            double fTemp = temp * 9 / 5 - 459.67;
            fTemp = Math.Round(fTemp, 1);

            Console.WriteLine($"The Temperature is {fTemp} f.");
            Console.ReadLine();
        }
    }
}
