using ICD.Base.Data;
using ICD.Framework.Web;
using ICD.Infrastructure.Exception;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using ICD.Framework.Extensions;
using ICD.Framework.Diagnosis;

namespace ICD.Base.Api
{
    public class Startup : TotalSystemWebStartup
    {
        //private IServiceCollection myServices;
        public Startup(IConfiguration configuration) : base(configuration)
        {
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public override IServiceProvider ConfigureServices(IServiceCollection services)
        {
            base.RegisterSwagger(services, "v1", "Base");

            services.AddObjectiveAppSettings("Base", "BAS");

            services.ConfigureComponentsDiagnosis(
               q => q.RequireDatabase()
               .RequireMessageBroker());

            var config = base.ConfigureServices(services);

            var configOption = config.GetAppSettings();

            var connection = configOption.ConnectionString.BaseDbContext;
            services.AddDbContext<BaseDbContext>(options =>
            {
                options.UseSqlServer(connection, b => b.MigrationsAssembly("ICD.Base.Api"));
            });

            return config;
        }

        public override void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "BaseAPI V1"); });
            app.UseCors();
            app.UseExceptionHandlerMiddleware();
            base.Configure(app, env);
            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}