using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using DoAN_S4.Areas.Admin.Models.BussinesModel;
using DoAN_S4.Areas.Admin.Models.BussinesModel.IRepository;
using DoAN_S4.Areas.Admin.Models.BussinesModel.Reposity;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using MongoDB.Driver;

namespace DoAN_S4
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddScoped<DbConText>();
            services.AddScoped<IRepositoryCategory, RepositoryCategory>();
            services.AddScoped<IRepositoryProduct, RepositoryProduct>();
            services.AddScoped<IRepositorySize, RepositorySize>();
            services.AddScoped<IRepositotyColor, RepositoryColor>();
            services.AddScoped<IRepositoryAccount, RepositoryAccount>();

            /////ddat

            services.AddAuthentication("BkapSecuritySchema").AddCookie("BkapSecuritySchema", ops =>
            {
                ops.Cookie = new Microsoft.AspNetCore.Http.CookieBuilder
                {
                    HttpOnly = true,
                    Name = "Bkap.Security.Cookie",
                    Path = "/",
                    SameSite = Microsoft.AspNetCore.Http.SameSiteMode.Lax,
                    SecurePolicy = Microsoft.AspNetCore.Http.CookieSecurePolicy.SameAsRequest
                };
                ops.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Admin/Login/Index");
                ops.ReturnUrlParameter = "RequestPath";
                ops.SlidingExpiration = true;
            });
            services.Configure<CookiePolicyOptions>(options =>
            {
                //options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            //services.AddMvc().AddNToastNotifyNoty(new NotyOptions
            //{
            //    ProgressBar = true,
            //    Timeout = 1000,
            //    Theme = "metroui",
            //    Layout = "topRight",
            //});

            services.Configure<CookiePolicyOptions>(options =>
            {
                options.MinimumSameSitePolicy = Microsoft.AspNetCore.Http.SameSiteMode.None;
            });
            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.IdleTimeout = new TimeSpan(0, 30, 0);
                options.Cookie.Name = "Bkap.Session";
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });
            /////ddat

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseCookiePolicy();
            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                  name: "admin",
                  template: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}
