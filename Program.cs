using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using System.IO;

namespace mvc_test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string fileName = "Data/db.json";
            string jsonString = File.ReadAllText(fileName);
            GVL.layout= JsonSerializer.Deserialize<Layout>(jsonString)!;
            Console.WriteLine(GVL.layout.Locomotives[0].Description);

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
