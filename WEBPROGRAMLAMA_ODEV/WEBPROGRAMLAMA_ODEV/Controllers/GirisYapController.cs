/**
* @ G191210351 Eren Can Sarı ve B191210351 İlker Küçücük
* @description Web Programlama Proje Ödevi
* @date 03.01.2021
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WEBPROGRAMLAMA_ODEV.Models;

namespace WEBPROGRAMLAMA_ODEV.Controllers
{
    public class GirisYapController : Controller
    {
        readonly Context contexteErisim = new Context();

        public IActionResult GirisYapSayfasi(Uyeler uyeVeri) /* Üyelerin giriş yapabileceği sayfada kimlik denetimini gerçekleştirir*/
        {
            bool _verilerUyustuMu = false;
            
            var bilgiler = contexteErisim.UyelerTablo.FirstOrDefault(x => x.KullaniciAdi == uyeVeri.KullaniciAdi &&/* Kullanıcıdan girilen Üye Kullanıcı Adı ve Şifresi veritabanında aranır*/
                  x.Parola == uyeVeri.Parola);
            if(bilgiler==null&&uyeVeri.KullaniciAdi==null)/* İlk tıklama*/
            {
                _verilerUyustuMu = true;
            }
            else if(bilgiler==null&& uyeVeri.KullaniciAdi != null)/*VERİ GİRİLDİ AMA UYUŞMADI*/
            {
                _verilerUyustuMu = false;
            }
            else if(bilgiler != null)/* Veri uyuşmadı ama başlangıçta alert çıkmasın diye true verildi*/
            {
                _verilerUyustuMu = true;
            }
            ViewBag.kontrol = (uyeVeri.KullaniciAdi == null);/* İlk tıkta alert verilmesin diye 2. kontrol atandı. Veri nullsa ve textboxa veri girişi yapılmadıysa */
            return View(_verilerUyustuMu);
        }
    }
}
