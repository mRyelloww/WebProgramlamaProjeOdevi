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
        public int Parola { get; set; }
    }
}
