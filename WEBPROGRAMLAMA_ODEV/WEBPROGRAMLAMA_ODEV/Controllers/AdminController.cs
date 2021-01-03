/**
* @ G191210351 Eren Can Sarı ve B191210351 İlker Küçücük
* @description Web Programlama Proje Ödevi
* @date 03.01.2021
*/
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
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
        readonly Context contexteErisim = new Context();

        public async Task<IActionResult> AdminPanelGirisSayfasi(Admin adminVeri)
        {
            /*adminVeri parametresi ile bu ActionResult a gelen değeri BU DEĞER TEXTBOXTAN GELECEK
            * tablodaki değerle karşılaştırıyoruz
            */

            List<bool> _kontroller = new List<bool>();/*birden fazla bool değişken tutar*/
            bool _tipDogruMu = true;
            bool _kullaniciAdDogruMu = true;

            /*@ogr.sakarya.edu.tr formatına uygunluk ve
             * format uygunsa girilen kullanıcı adının veritabanında varlığı kontrol edilir*/
            _kontroller.Add(_tipDogruMu);
            _kontroller.Add(_kullaniciAdDogruMu);

            var diziler = contexteErisim.DiziTablo.ToList();

            if (adminVeri.KullaniciAdi != null && !adminVeri.KullaniciAdi.Contains("@ogr.sakarya.edu.tr"))/*textbox boş gönderilmediyse ve kullanıcı adının formatı doğru değilse çalışır*/
            {
                _kontroller[0] = false;
                return View(_kontroller);
            }
            else
            {
                _kontroller[0] = true;
                var bilgiler = contexteErisim.AdminTablo.FirstOrDefault(x => x.KullaniciAdi == adminVeri.KullaniciAdi &&/*veritabanından linq ile veri çekilir.*/
             x.Sifre == adminVeri.Sifre);

                if (bilgiler != null)   /*bilgiler uyuşursa çalışacak.*/
                {
                    _kontroller[1] = true;

                    /*AUTHENTİCATİON VE COOKİE İŞLEMLERİ BAŞLANGIÇ*/
                    var claims = new List<Claim>
                    {
                    new Claim(ClaimTypes.Name,adminVeri.KullaniciAdi)   /*KULLANICI ADINI ATADIK*/
                    };
                    var kullaniciKimligi = new ClaimsIdentity(claims, "Login");
                    ClaimsPrincipal principal = new ClaimsPrincipal(kullaniciKimligi);
                    await HttpContext.SignInAsync(principal);
                    /************************************************/
                    return RedirectToAction("AdminPanel", "Admin", diziler);
                }
                if (bilgiler == null && adminVeri.KullaniciAdi != null)/*textboxtaki veri VT deki ile uyuşmadıysa ve girilen veri boş değilse çalışır*/
                {
                    _kontroller[1] = false;
                    return View(_kontroller);
                }
                else
                {
                    return View(_kontroller);
                }
            }
        }

        [Authorize]
        public async Task<IActionResult> Cikis()        /* Çıkış tuşuna basıldığında çıkış yapar ve ana sayfaya dönüş sağlar*/
        {
            await HttpContext.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }
        [Authorize]
        public IActionResult AdminPanel()             /*dizilere ait verileri listeleyen View'i getirir.*/
        {
            var degerler = contexteErisim.DiziTablo.ToList();
            return View(degerler);/*ındexe veri gönderme kısmı*/
        }
        [HttpGet]
        [Authorize]
        public IActionResult DiziEkle()//sayfaya get isteği olduğunda çalışacak
        {
            return View();
        }
        [HttpPost]
        [Authorize]
        public IActionResult DiziEkle(Diziler d)//sayfaya post isteği olduğunda çalışacak
        {
            contexteErisim.DiziTablo.Add(d);    /*buradaki d YEniBirim.cshtml de textboxa atanan değer*/
            contexteErisim.SaveChanges();
            return RedirectToAction("DiziEkle");/*Index'e geri gönderecek bizi*/
        }

        [Authorize]
        public IActionResult DiziSil(int id)/*ID ye göre silme yapılacak*/
        {
            var dep = contexteErisim.DiziTablo.Find(id);/*metoda gelen silinecek Birim id sini bulur*/
            contexteErisim.DiziTablo.Remove(dep);/*id nin tuttuğu Find'ın bulduğu tüm satırı siler.*/
            contexteErisim.SaveChanges();/*aslında bu ındexteki değişikliği saveliyor bu olmasa VT den veri silinir ama Indexe yansımazdı*/
            return RedirectToAction("AdminPanel");
        }

        [Authorize]
        public IActionResult VeriGetir(int id)
        {/*Güncelleme için ID ye göre seçilen Birimın bilgilerini BirimGetir View'e gönderir.*/
            var diziVeri = contexteErisim.DiziTablo.Find(id);
            return View("VeriGetir", diziVeri);/*Birim ID ve adını viewlere, textboxlara göndermemizi sağlar
                                                  Depart yazmasaydık textboxta sadece BirimID gözüküyor.TÜm bilgileri içeren nesneyi attık ki diğer bilgileri de görelim.*/
        }

        [Authorize]
        public IActionResult DiziGuncelle(Diziler d)
        {
            /*tabloda olan veriyi parametreden gelen değerle değiştireceğiz*/
            var dz = contexteErisim.DiziTablo.Find(d.DiziID);           /*gönderilen ID ye göre satır bulunup Dep e aktarılır.*/
            dz.DiziAd = d.DiziAd;                                       
            dz.DiziID = d.DiziID;
            dz.DiziTurler = d.DiziTurler;
            dz.DiziStudyo = d.DiziStudyo;
            dz.DiziSezonSayi = d.DiziSezonSayi;
            dz.DiziTarih = d.DiziTarih;
            dz.DiziIMDB = d.DiziIMDB;
            dz.DiziDosyaAdi = d.DiziDosyaAdi;
            dz.DiziBilgi = d.DiziBilgi;
            dz.DiziLink = d.DiziLink;

            contexteErisim.SaveChanges();/*veritabanın verilerini günceller*/
            return RedirectToAction("AdminPanel");
        }
    }
}
