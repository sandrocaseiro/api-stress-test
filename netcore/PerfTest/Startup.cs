using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Debug;
using PerfTest.Data;
using PerfTest.Data.Repositories;
using PerfTest.Services;

namespace PerfTest
{
    public class Startup
    {
        public static readonly LoggerFactory MyLoggerFactory = new LoggerFactory(new[] { new DebugLoggerProvider() });

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddDbContextPool<MockDbContext>(o =>
            {
                o.UseOracle(Configuration.GetValue<string>("ConnectionString"));
                o.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
#if DEBUG
                o.UseLoggerFactory(MyLoggerFactory);
#endif
            });

            //services.AddSingleton(s => new OracleConnectionFactory(Configuration.GetValue<string>("ConnectionString"))); 
            services.AddScoped<MockDataRepository>();
            services.AddScoped<MockDataRepositoryDapper>();
            services.AddScoped<MockDataService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
