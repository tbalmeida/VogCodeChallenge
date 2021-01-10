using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using VogCodeChallenge.App;
using VogCodeChallenge.App.Repositories;
using VogCodeChallenge.App.Repositories.Interfaces;

namespace VogCodeChallenge.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var inMemoryDb = Configuration.GetValue<bool>("InMemoryDb");
            if (inMemoryDb)
            {
                services.AddDbContext<ApplicationDbContext>(options =>
                   options.UseInMemoryDatabase(databaseName: "VogInMemoryDB"));
            } else {
                services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")
                    //,
                    //b =>
                    //{
                    //    b.MigrationsAssembly("MKTFY.App");
                    //}
                    )
                );
            }

            services.AddControllers();

            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
