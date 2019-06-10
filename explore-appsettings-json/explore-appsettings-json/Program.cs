using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace explore_appsettings_json
{
    class Program
    {
        private static string connectionStrings;

        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                              .SetBasePath(Directory.GetCurrentDirectory())
                              .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();
            connectionStrings = configuration.GetConnectionString("Storage");
 
            Console.WriteLine(connectionStrings);
        }
    }
}
