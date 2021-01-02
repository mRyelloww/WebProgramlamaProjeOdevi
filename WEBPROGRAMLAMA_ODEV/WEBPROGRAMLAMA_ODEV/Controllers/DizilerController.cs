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
        Context contexteErisim = new Context();
        public static List<Context> DizilerListesi = new List<Context>();

        public IActionResult DizilerSayfasi()
        {
            var DiziTablosu = contexteErisim.DiziTablo.ToList();
            //ViewBag.id = 0;

            return View(DiziTablosu);
        }

        public IActionResult DiziDetaySayfasi(int id)
        {
            List<string> dizininVerileri = new List<string>();
            var DiziTabloIstenenSatir = contexteErisim.DiziTablo.Find(id);

            return View(DiziTabloIstenenSatir);
        }
        public IActionResult BegeniArtti(int id)
        {
            var DiziTabloIstenenSatir = contexteErisim.DiziTablo.Find(id);
            DiziTabloIstenenSatir.DiziBegeni++;
            contexteErisim.SaveChanges();

            return RedirectToAction("DiziDetaySayfasi", new { id = id });
        }
    }
}
