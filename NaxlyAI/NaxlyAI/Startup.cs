using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
//using NaxlyAI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaxlyAI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddSingleton<IStudentRepository, MockStudentRepository>();
            services.AddMvc(options =>
            {
                options.EnableEndpointRouting = false;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILogger<Startup> logger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //Default file adlari: index.html, index.htm, default.html, default.htm

            app.UseRouting();

            /*DefaultFilesOptions defaultFilesOptions = new DefaultFilesOptions();
            defaultFilesOptions.DefaultFileNames.Clear();
            defaultFilesOptions.DefaultFileNames.Add("second.html");

            //DefaultFiles StaticFiles-den evvel gelmelidir.
            app.UseDefaultFiles(defaultFilesOptions);*/
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();


            //FileServerOptions fileServerOptions = new FileServerOptions();
            //fileServerOptions.DefaultFilesOptions.DefaultFileNames.Clear();
            //fileServerOptions.DefaultFilesOptions.DefaultFileNames.Add("second.html");

            //Bu middleware yuxaridaki ikisini ve ustelik useDirectoryBrowser-i de evez edir
            
            //app.UseFileServer(fileServerOptions);
            

           /* app.Use(async (context, next) =>
            {
                logger.LogInformation("MW1: Incoming request");
                await next();
                logger.LogInformation("MW1: Outgoing response");
            });

            app.Use(async (context, next) =>
            {
                logger.LogInformation("MW2: Incoming request");
                await next();
                logger.LogInformation("MW2: Outgoing response");
            });
*/
            app.Run(async context =>
            {
                //logger.LogInformation("MW3: Incoming request");
                await context.Response.WriteAsync("MW3");
                //logger.LogInformation("MW3: Outgoing response");
            });

            /*app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    logger.LogInformation("MW3: Incoming request");
                    await context.Response.WriteAsync("MW3");
                    logger.LogInformation("MW3: Outgoing response");
                });
            });*/
        }
    }
}
