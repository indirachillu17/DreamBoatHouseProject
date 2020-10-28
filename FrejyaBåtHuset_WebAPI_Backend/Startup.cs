using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using FrejyaBåtHuset_WebAPI_Backend.Data;
using Swashbuckle;

namespace FrejyaBåtHuset_WebAPI_Backend
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

            services.AddControllers();
            services.AddOpenApiDocument();
            services.AddDbContext<FrejyaBåtHuset_WebAPI_BackendContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("FrejyaBåtHuset_WebAPI_BackendContext")));
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "Values Api", Version = "v1" });
            });
            services.AddSwaggerDocument();
        }
        //created service then used its object & called function.


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

            }
            //using is used to define the scope.ApplicationServices gives access to application service container.
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<FrejyaBåtHuset_WebAPI_BackendContext>();
                InitiazeData.SeedData(context);
            }


            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            
            app.UseSwaggerUi3();
            app.UseSwagger(c => { c.RouteTemplate = "/swagger/{documentName}/swagger.json"; });
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "TestService");
                
            });

            //app.UseStaticFiles();
            //app.UseOpenApi();
            //app.UseSwaggerUI();
            //app.UseSwaggerUI(c =>
            //{
            //    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            //});
            //app.UseOpenApi();
            //app.UseSwaggerUi3();


        }
    }
}

