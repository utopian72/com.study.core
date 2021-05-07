using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using com.study.core.model;
using Microsoft.EntityFrameworkCore;
using System.IO;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using com.study.core.web.filter;

namespace com.study.core.web
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
            services.AddControllers().AddNewtonsoftJson();
            services.AddControllersWithViews();

            //context를 등록한다.
            services.AddDbContext<com.study.core.model.mobileSurveyContext>(options => options.UseSqlServer(Configuration.GetConnectionString("LMSContext")));
            services.AddMvc(option => option.EnableEndpointRouting = false).AddNewtonsoftJson();
            services.AddHttpContextAccessor();
            services.AddDistributedMemoryCache();
            services.AddMvc().AddSessionStateTempDataProvider();
            services.AddSession();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Latest);
            services.AddApplicationInsightsTelemetry();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            //you must add package Serilog.Extensions.Logging.File 
            string path = Directory.GetCurrentDirectory();
            loggerFactory.AddFile($"{path}\\logs\\log.txt");

            //if (env.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage();
            //}
            //else
            //{
            //    app.UseExceptionHandler("/Home/Error");
            //    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            //    app.UseHsts();
            //}

            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseMvcWithDefaultRoute();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                    name: "api",
                    pattern: "api/{controller=Home}/{action=Index}/{id?}");

            });



        }
    }
}
