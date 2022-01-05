using Autofac;
using Autofac.Extensions.DependencyInjection;
using DataAccess;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System.Linq;
using VV_Market_Pull.ServiceConfigurations;

namespace VV_Market_Pull
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment hostContext)
        {
            Configuration = configuration;
            HostContext = hostContext;
        }

        public IConfiguration Configuration { get; }
        public IWebHostEnvironment HostContext { get; }
        public ILifetimeScope AutofacContainer { get; private set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddDbContext<MarketDataDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("marketDataDb")), ServiceLifetime.Transient);
            services.AddDbContext<VulcanMarketDataDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("marketDataDb")), ServiceLifetime.Transient);

            services.AddControllers();
        }

        public void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule(new DataAccessContainerModule());
            builder.RegisterModule(new MarketDataContainerModule());
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, VulcanMarketDataDbContext vulcanDataContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            AutofacContainer = app.ApplicationServices.GetAutofacRoot();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            //if (dataContext.Database.GetPendingMigrations().Any())
            //{
            //    dataContext.Database.Migrate();
            //}

            if (vulcanDataContext.Database.GetPendingMigrations().Any())
            {
                vulcanDataContext.Database.Migrate();
            }

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
