using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using SonOfCod.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace SonOfCod
{
    public class Startup
    {
        public IConfigurationRoot Configuration { get; set; }

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json");
            Configuration = builder.Build();
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddEntityFramework()
                .AddDbContext<SOCContext>(options =>
                    options.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"]));
            services.AddIdentity<Admin, IdentityRole>()
                .AddEntityFrameworkStores<SOCContext>()
                .AddDefaultTokenProviders();
        }

        public void Configure(IApplicationBuilder app, SOCContext context)
        {

            var newContext = app.ApplicationServices.GetService<SOCContext>();

            app.UseStaticFiles();

            app.UseIdentity();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            app.Run(async (appContext) =>
            {
                await appContext.Response.WriteAsync("Hello World!");
            });

            DbContextExtensions.Seed(app);
        }

        //private static void AddTestData(SOCContext context)
        //{
        //    var funBlurb = new Models.Content
        //    {
        //        Title = "World's Best Seafood",
        //        Type = "funblurb",
        //        Text = "We expect ourselves to do business right, to lead by example and to help out when we are needed. It is our company philosophy that guides our everyday decisions. It is good to be responsible, not just because it is the right thing to do, but because it also sets the bar for our company’s commitment to ensure that the communities in which we work and live will continue to prosper.",
        //    };

        //    context.Content.Add(funBlurb);

        //    context.SaveChanges();
        //}
    }
}