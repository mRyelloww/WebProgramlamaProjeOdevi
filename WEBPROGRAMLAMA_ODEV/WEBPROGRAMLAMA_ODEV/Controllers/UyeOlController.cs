using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WEBPROGRAMLAMA_ODEV.Models;

namespace WEBPROGRAMLAMA_ODEV.Controllers
{
    public class UyeOlController : Controller
    {

        public IActionResult UyeOlSayfasi(Uyeler uyeVeri)
        {
            Context contexteErisim = new Context();

            var uyeler = contexteErisim.UyelerTablo.ToList();

            bool kullaniciAdiVarMi = false; // View kısmında kullanıcı adının database'de olup olmadığı bilgisini aktarma ve viewde alert vermeye yarayan bool.

            var bilgiler = contexteErisim.UyelerTablo.FirstOrDefault(x => x.KullaniciAdi == uyeVeri.KullaniciAdi); // Girilen kullanıcı adı Databasede var ise Bilgilere atanıyor.


            if (bilgiler != null) // Girilen Kullanıcı Adı yukarıda databasede bulunduysa database'ye eklenmez ve geri döndürülür.
            {
                kullaniciAdiVarMi = true;
                return View(kullaniciAdiVarMi);
            }
            else  // Girilen Kullanıcı Adı yukarıda databasede bulunamadıysa databaseye eklenir
            {
                if (uyeVeri.KullaniciAdi != null || uyeVeri.Parola != null) // Burada kullanıcı adı veya parola boş bir değer girildiğinde data baseye atanamasın diye bir sorgudan daha geçiriliyor.
                {
                    contexteErisim.UyelerTablo.Add(uyeVeri);
                    contexteErisim.SaveChanges();
                    kullaniciAdiVarMi = false;
                    return View(kullaniciAdiVarMi);
                }
                else
                {
                    return View();
                }
            }
        }

    }
}
