using ImportExample;
using System;

namespace ImportConsole
{
    class Program
    {
        static void Main(string[] args)
        {

#if TEST
            string path = "e:\\Projects\\Others\\CityParser\\ImportConsole\\bin\\Debug\\netcoreapp2.1\\CitiesData.json";
#else
            Console.Write("Full path to the file:");
            string path = Console.ReadLine();
#endif

            Console.WriteLine("");
            Console.Write("Start processing..");

            CityParser cityParser = new CityParser(path);
            cityParser.Parse();

            Console.WriteLine(" and finished successfully");
            Console.WriteLine("Press any key pls");
            Console.ReadKey();
        }
    }
}
