using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBPROGRAMLAMA_ODEV.Models
{
    public class DiziTurDiziler
    {
        public int DiziID { get; set; }
        public Diziler Dizi_iliski { get; set; }
        public int TurID { get; set; }
        public DiziTur DiziTur_iliski { get; set; }
    }
}
