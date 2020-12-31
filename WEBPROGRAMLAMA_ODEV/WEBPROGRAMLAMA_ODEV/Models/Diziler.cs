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
        public int DiziOy { get; set; }
        public string DiziBilgi { get; set; }
        public string DiziLink { get; set; }
        public ICollection<DiziTurDiziler> DiziTur_Col { get; set; }

        //public DiziTur TurNesne{ get; set; }

    }
}
