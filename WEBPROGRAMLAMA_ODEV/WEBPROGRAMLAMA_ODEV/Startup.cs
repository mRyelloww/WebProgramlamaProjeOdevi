using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WEBPROGRAMLAMA_ODEV.Models;

namespace WEBPROGRAMLAMA_ODEV
{
    public class Startup
    {
       
        public Startup(IConfiguration configuration)            /*Startup sýnýfý constructor'u. Baþlangýçta konfigürasyonu saðlar*/
        {
            Context contexteErisim = new Context();
            Admin eren = new Admin();
            eren.KullaniciAdi = "G191210351@ogr.sakarya.edu.tr";
            eren.Sifre = "123";


            Admin ilker = new Admin();
            ilker.KullaniciAdi = "B191210351@ogr.sakarya.edu.tr";
            ilker.Sifre = "123";

            var bilgiler1 = contexteErisim.AdminTablo.FirstOrDefault(x => x.KullaniciAdi == ilker.KullaniciAdi);
            var bilgiler2 = contexteErisim.AdminTablo.FirstOrDefault(x => x.KullaniciAdi == eren.KullaniciAdi);
            if (bilgiler1 == null && bilgiler2 == null)
            {
                contexteErisim.AdminTablo.Add(ilker);
                contexteErisim.AdminTablo.Add(eren);
                contexteErisim.SaveChanges();

            }


            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        
        public void ConfigureServices(IServiceCollection services) 
        {
            services.AddControllersWithViews();
            var connection = @"server =.; database = DizileDB; trusted_connection = true; ";
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme) // Yetkilendirme servisi için Cookie atanýyor.
                .AddCookie(x => {
                    x.LoginPath = "/Admin/AdminPanelGirisSayfasi/"; // Herhangi bir þekilde admin paneline veya admin paneldeki bir iþleme login atmadan URL den giriþ yapýlmaya kalkýþýldýðýnda direkt olarak Admin Panel Giriþ Sayfasýna yönlendirir.
                });
            services.AddDbContext<Context>(options => options.UseSqlServer(connection));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseAuthentication();    // Authentication da kullanýlacak servis projeye ekleniyor.
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

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
