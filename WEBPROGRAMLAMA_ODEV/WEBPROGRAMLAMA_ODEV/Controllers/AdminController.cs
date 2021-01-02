using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WEBPROGRAMLAMA_ODEV.Models;

namespace WEBPROGRAMLAMA_ODEV.Controllers
{
    public class AdminController : Controller
    {
        Context contexteErisim = new Context();
        public async Task<IActionResult> AdminPanel(Admin a)
        {
            var iliskiliDiziTablosu = contexteErisim.DiziTurDizilerTablo
                .Include(d => d.DiziTur_iliski)
                .Include(d => d.Dizi_iliski).ToList();
            var diziler = contexteErisim.DiziTablo.ToList();

            var bilgiler = contexteErisim.AdminTablo.FirstOrDefault(x => x.KullaniciAdi == a.KullaniciAdi &&
              x.Sifre == a.Sifre);
            /*a parametresi ile bu ActionResult a gelen değeri BU DEĞER TEXTBOXTAN GELECEK
             * tablodaki değerle karşılaştırıyoruz
             */
            if (bilgiler != null)/*bilgiler uyuşursa çalışacak.*/
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,a.KullaniciAdi)/*KULLANICI ADINI ATADIK*/
                };
                var useridentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return View("ListelePanel", diziler);/*personeldeki ındex e göndereceğiz*/
            }
            /* bilgiler uyuşmazsa zaten if e girmeyecek ve direkt aynı sayfayı döndürecek*/
            return View();
        }

        public IActionResult ListelePanel()
        {
            var degerler = contexteErisim.DiziTablo.ToList();
            return View(degerler);/*ındexe veri gönderme kısmı*/
        }
        [HttpGet]
        public IActionResult DiziEkle()//sayfaya get isteği olduğunda çalışacak
        {
            return View();
        }
        [HttpPost]
        public IActionResult DiziEkle(Diziler d)//sayfaya post isteği olduğunda çalışacak
        {
            contexteErisim.DiziTablo.Add(d);    /*buradaki d YEniBirim.cshtml de textboxa atanan değer*/
            contexteErisim.SaveChanges();
            return RedirectToAction("DiziEkle");/*Index'e geri gönderecek bizi*/

        }
        public IActionResult DiziSil(int id)/*ID ye göre silme yapılacak*/
        {
            var dep = contexteErisim.DiziTablo.Find(id);/*metoda gelen silinecek Birim id sini bulur*/
            contexteErisim.DiziTablo.Remove(dep);/*id nin tuttuğu Find'ın bulduğu tüm satırı siler.*/
            contexteErisim.SaveChanges();/*aslında bu ındexteki değişikliği saveliyor bu olmasa VT den veri silinir ama Indexe yansımazdı*/
            return RedirectToAction("ListelePanel");
        }
        public IActionResult VeriGetir(int id)
        {/*Güncelleme için ID ye göre seçilen Birimın bilgilerini BirimGetir View'e gönderir.*/
            var diziVeri = contexteErisim.DiziTablo.Find(id);
            return View("VeriGetir", diziVeri);/*Birim ID ve adını viewlere, textboxlara göndermemizi sağlar
                                                  Depart yazmasaydık textboxta sadece BirimID gözüküyor.TÜm bilgileri içeren nesneyi attık ki diğer bilgileri de görelim.*/
        }

        public IActionResult DiziGuncelle(Diziler d)
        {
            var dz = contexteErisim.DiziTablo.Find(d.DiziID);/*gönderilen ID ye göre satır bulunup Dep e aktarılır.*/
            dz.DiziAd = d.DiziAd;/*tabloda olan veriyi parametreden gelen değerle değiştireceğiz*/
            contexteErisim.SaveChanges();
            return RedirectToAction("ListelePanel");
        }
       /* public IActionResult BirimDetay(int id)
        {
            var degerler = contexteErisim.Personels.Where(x => x.BirimID == id).ToList();
            return View(degerler);
        }*/
    }
}
