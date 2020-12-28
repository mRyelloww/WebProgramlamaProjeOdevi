using Microsoft.AspNetCore.Mvc;
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
        public int DiziID { get; set; }/*Private Key*/
        public string DiziAd { get; set; }
        public int DiziOy { get; set; }
        public string DiziOzet { get; set; }

    }
}
