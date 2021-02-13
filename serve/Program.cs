using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Serve
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(_ => _
                    .UseStartup<Startup>())
                .Build()
                .Run();
        }

    }
}
