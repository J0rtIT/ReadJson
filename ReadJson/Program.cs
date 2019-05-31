using System;
using System.IO;
using Newtonsoft.Json;


namespace ReadJson
{
    class Program
    {
        static void Main(string[] args)
        {
            var json = File.ReadAllText(@"C:\Users\jorte\source\repos\ReadJson\ReadJson\Config.json");
            var rootObject = JsonConvert.DeserializeObject<Configuration>(json);



            Console.WriteLine(json);
            Console.ReadKey();
        }
    }
}
