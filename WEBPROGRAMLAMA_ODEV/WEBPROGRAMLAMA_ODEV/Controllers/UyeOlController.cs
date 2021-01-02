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


            bool kullaniciAdiVarMi = false;

            var bilgiler = contexteErisim.UyelerTablo.FirstOrDefault(x => x.KullaniciAdi == uyeVeri.KullaniciAdi);


            if (bilgiler != null)/*bilgiler uyuşursa çalışacak.*/
            {
                kullaniciAdiVarMi = true;
                return View(kullaniciAdiVarMi);


            }
            else
            {
                contexteErisim.UyelerTablo.Add(uyeVeri);
                contexteErisim.SaveChanges();
                kullaniciAdiVarMi = false;
                return View(kullaniciAdiVarMi);
            }
        }

    }
}
