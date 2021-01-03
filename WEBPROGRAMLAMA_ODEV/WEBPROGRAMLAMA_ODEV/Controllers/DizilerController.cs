/**
* @ G191210351 Eren Can Sarı ve B191210351 İlker Küçücük
* @description Web Programlama Proje Ödevi
* @date 03.01.2021
*/
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WEBPROGRAMLAMA_ODEV.Models;

namespace WEBPROGRAMLAMA_ODEV.Controllers
{
    
    public class DizilerController : Controller
    {
        readonly Context contexteErisim = new Context();   

        public IActionResult DizilerSayfasi()   /* Tablodaki verileri listeleyen View'in Action'u*/
        {
            var DiziTablosu = contexteErisim.DiziTablo.ToList();
            return View(DiziTablosu);
        }

        public IActionResult DiziDetaySayfasi(int id)  /* Diziler sayfasından seçilen dizinin detaylarını gösteren sayfaya yönlendirir*/
        {
            var DiziTabloIstenenSatir = contexteErisim.DiziTablo.Find(id);

            return View(DiziTabloIstenenSatir);
        }
        public IActionResult BegeniArtti(int id)     /* DiziDetaySayfasindaki beğeni butonuna basıldığında beğeni bir artar ve veritabanına işlenir.*/
        {
            var DiziTabloIstenenSatir = contexteErisim.DiziTablo.Find(id);
            DiziTabloIstenenSatir.DiziBegeni++;
            contexteErisim.SaveChanges();

            return RedirectToAction("DiziDetaySayfasi", new { id });
        }
    }
}
