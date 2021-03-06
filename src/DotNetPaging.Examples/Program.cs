using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using DotNetPaging.Examples.Models;

namespace DotNetPaging.Examples
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    DataSet.CreateDataSet();
                });

        
    }
}
