using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyFirstWebApp.Services;
using Microsoft.AspNetCore.Http;
using System.Text;

namespace MyFirstWebApp
{
    public class Startup
    {
        // 1. Constructor
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // 4. Basic Configuration
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // 2. Configure Services - Register your services, Apply db context and third party services
        public void ConfigureServices(IServiceCollection services)
        {
            // Register FooService
            services.AddTransient<FooServices>();
            
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        // 3. Config Method - Middleware Pipeline is configured
        // Every single request goes through here 
        // First thing it checks whether we're in development mode or null, so as to display error or null - Development, Prodution & Staging
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, FooServices fooService)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.Run(async(context) =>
            {
                var names = fooService.GetNames();
                StringBuilder builder = new StringBuilder();
                foreach(var name in names)
                {
                    if(Configuration.GetValue<bool>("CapitalizeWord"))
                    {
                        builder.Append(name.ToUpper() + " ");
                    }
                    else
                    {
                        builder.Append(name + " ");
                    }
                    
                }
                await context.Response.WriteAsync(builder.ToString());
                //throw new Exception();
            });
            /**app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });*/
        }
    }
}
