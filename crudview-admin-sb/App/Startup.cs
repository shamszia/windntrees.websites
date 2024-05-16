using Application.Core.Data;
using Application.Core.Models;
using Application.Core.Models.Configuration;
using Application.Core.Services;
using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Globalization;
using Microsoft.AspNetCore.Mvc.NewtonsoftJson;

namespace Application.Core
{
    public class Startup
    {
        #region APP
        private static IApplicationBuilder _app = null;
        public static IApplicationBuilder APP
        {
            get
            {
                return _app;
            }
        }
        #endregion

        #region ENV
        private static IWebHostEnvironment _env = null;
        public static IWebHostEnvironment ENV
        {
            get
            {
                return _env;
            }
        }
        #endregion

        #region Services
        private static IServiceCollection _services = null;
        public static IServiceCollection Services
        {
            get
            {
                return _services;
            }
        }
        #endregion

        #region Configuration
        private static IConfiguration _configuration = null;
        public static IConfiguration Configuration
        {
            get
            {
                return _configuration;
            }
        }
        #endregion

        #region Antiforgery
        private static IAntiforgery _antiforgery = null;
        public static IAntiforgery Antiforgery
        {
            get
            {
                return _antiforgery;
            }
        }
        #endregion

        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            _configuration = configuration;
            _env = env;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            _services = services;

            _services.Configure<ApplicationSettings>(Configuration.GetSection("ApplicationSettings"));

            _services.AddAntiforgery(options =>
            {
                options.Cookie.Name = options.FormFieldName;
                options.HeaderName = options.FormFieldName;
            });

            _services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("ApplicationConnection")));

            _services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            // Add application services.
            _services.AddTransient<IEmailSender, EmailSender>();

            _services.AddTransient<Seed>();

            // Add localization support
            _services.AddLocalization();

            _services.AddMvc().AddRazorRuntimeCompilation();

            _services.AddControllers().AddNewtonsoftJson();
            _services.AddControllersWithViews().AddNewtonsoftJson();
            _services.AddRazorPages().AddNewtonsoftJson();

            var _builderMVC = _services.AddMvc(options => options.EnableEndpointRouting = false)
                .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
                .AddDataAnnotationsLocalization()
                .SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0)
                .AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.PropertyNamingPolicy = null;
                    options.JsonSerializerOptions.DictionaryKeyPolicy = null;
                });

            _builderMVC.AddNewtonsoftJson();

            // Required for use with session object 
            // to extract values using extender methods
            _services.AddDistributedMemoryCache();
            _services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IAntiforgery antiforgery, IOptions<ApplicationSettings> options, Seed seed)
        {
            _app = app;
            _antiforgery = antiforgery;

            if (options.Value.SetupAdminAccount)
            {
                seed.Fill();
            }

            string[] supportedLocales = options.Value.SupportedLocales;
            List<CultureInfo> supportedCultures = new List<CultureInfo>();

            foreach (string locale in supportedLocales)
            {
                supportedCultures.Add(new CultureInfo(locale));
            }

            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture(options.Value.DefaultLocale),
                
                // Formatting numbers, dates, etc.
                SupportedCultures = supportedCultures,
                // UI strings that we have localized.
                SupportedUICultures = supportedCultures
            });

            if (ENV.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseSession();
            
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapDefaultControllerRoute();
            //});

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "areaRoute",
                    template: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
