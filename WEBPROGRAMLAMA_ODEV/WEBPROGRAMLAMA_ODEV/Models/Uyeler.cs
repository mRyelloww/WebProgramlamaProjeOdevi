/**
* @ G191210351 Eren Can Sarı ve B191210351 İlker Küçücük
* @description Web Programlama Proje Ödevi
* @date 03.01.2021
*/
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WEBPROGRAMLAMA_ODEV.Models
{
    public class Uyeler
    {
        [Key]
        public int UyeID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Parola { get; set; }
    }
}
