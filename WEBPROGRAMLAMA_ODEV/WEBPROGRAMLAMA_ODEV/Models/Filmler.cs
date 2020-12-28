using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WEBPROGRAMLAMA_ODEV.Models
{
    public class Filmler
    {
        [Key]
        public int FilmID { get; set; }/*Private Key*/
        public string FilmAd { get; set; }
        public int FilmOy { get; set; }
        public string FilmOzet { get; set; }
    }
}
