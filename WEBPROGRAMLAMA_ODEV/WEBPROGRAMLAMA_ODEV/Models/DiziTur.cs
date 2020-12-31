using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WEBPROGRAMLAMA_ODEV.Models
{
    public class DiziTur
    {
        [Key]
        public int TurID { get; set; }
        public string Tur { get; set; }
        public ICollection<DiziTurDiziler> DiziTur_Col{ get; set; }
    }
}
