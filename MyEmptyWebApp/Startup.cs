using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace MyEmptyWebApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});

            //Middleware tht catches exception and displays a generic error msg, 
            //If second middleware throws an error/exception first middleware handles the error 
            //Else if the second middleware succeeds we go to home, about routes
            //And if none of the routes get displayed we see the Hello msg
            //context - HttpContext, Next - Request Delegate
            /*app.Use(async (context, next) =>
            {
                //Error Handling Middleware - inline middleware
                try
                {
                    await next();
                }
                catch (Exception e)
                {
                    await context.Response.WriteAsync("Oops something went wrong...");
                }
            });*/

            app.UseMiddleware<CustomErrorHandlingMiddleware>();

            app.Use((context, next) =>
            {
                // Random number - if chance is odd null exception is thrown which is - it calls next middleware, 
                // if even then middleware throws Invalid operator exception
                Random randomizer = new Random();
                int chance = randomizer.Next(10);
                if (chance % 2 == 0)
                {
                    throw new Exception("Invalid operator");
                }
                return next(); // If the current middleware causes exception, request is passed to next middleware
            });
            // Specific - Home route
            app.Map("/home", appBuilder =>
            {
                appBuilder.Run(async context =>
                {
                    await context.Response.WriteAsync("Home Page");
                });
            });

            app.Map("/about", appBuilder =>
            {
                appBuilder.Run(async context =>
                {
                    await context.Response.WriteAsync("About Page");
                });
            });

            // If our route doesnt'match two routes about
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello ASP.NET Core 2.0");
            });
        }
    }
}
