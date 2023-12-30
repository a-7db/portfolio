using portfolio.API.data;
using portfolio;
using System.Text.Json;
using portfolio.API;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Portfolio? data = GetHome<Portfolio>();

            Portfolio? portfolio = new Portfolio();
            Console.WriteLine(portfolio?.home?.name);
        }

        public static T? GetHome<T>()
        {
            var path = "API/home.json";

            var content = File.ReadAllText(path);
            //Console.WriteLine(content);
            T? home = JsonSerializer.Deserialize<T>(content);

            return home;
        }
    }
}
