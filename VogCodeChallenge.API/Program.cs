using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using VogCodeChallenge.App;
using VogCodeChallenge.App.Seeds;

namespace VogCodeChallenge.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var context = services.GetRequiredService<ApplicationDbContext>();

                var inMemoryDb = Convert.ToBoolean(Environment.GetEnvironmentVariable("InMemoryDb"));
                if (inMemoryDb)
                {
                    // seed the in-memory db
                    DataSeed.Initialize(services);
                } else {
                    context.Database.Migrate();
                    // TODO - add seeding for custom db
                }
            }

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
