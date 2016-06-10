using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace NancyVsVapor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseKestrel()
                .UseStartup<Startup>()
                .UseUrls("http://+:8200")
                .Build();

            host.Run();
        }
    }
}
