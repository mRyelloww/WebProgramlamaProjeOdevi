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
    public class Diziler
    {
        [Key]
        public int DiziID { get; set; }
        public string DiziAd { get; set; }
        public int DiziBegeni { get; set; }
        public string DiziStudyo { get; set; }
        public string DiziTarih { get; set; }
        public int DiziSezonSayi { get; set; }
        public string DiziIMDB { get; set; }
        public string DiziBilgi { get; set; }
        public string DiziLink { get; set; }
        public string DiziDosyaAdi { get; set; }
        public string DiziTurler { get; set; }

    }
}
