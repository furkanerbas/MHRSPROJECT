using AutoMapper;
using MHRS303DataAccessLayer;
using MHRS303EntityLayer.IdentityModels;
using MHRS303EntityLayer.Mappings;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MHRS303UI
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
            //Asp.Net Core connection string ba�lant�s�n� yapabilmesi i�in servislere dbcontext i eklememiz gerekmektedir.
            services.AddDbContext<MyContext>(options => {
                options.UseSqlServer(Configuration.GetConnectionString("LocalConnection"));
            });

            services.AddControllersWithViews();
            services.AddRazorPages();
            services.AddMvc();
            services.AddSession(options => {
                options.IdleTimeout = TimeSpan.FromSeconds(60); //oturum s�resi
            });
            services.AddIdentity<AppUser, AppRole>(options => {
                options.User.RequireUniqueEmail = true;
                options.Password.RequiredLength = 4;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
                options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@";
            }).AddDefaultTokenProviders().AddEntityFrameworkStores<MyContext>();

            //Mapleme
            services.AddAutoMapper(typeof(Maps));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles(); // wwwroot klas�r�ne eri�ebilmek i�in

            app.UseRouting(); // route mekanizma

            app.UseSession(); // Sessionu kullanmak i�in

            app.UseAuthorization(); // [Authorize] attribute i�in

            app.UseAuthentication(); // Login ve Logout i�lemleri i�in

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
