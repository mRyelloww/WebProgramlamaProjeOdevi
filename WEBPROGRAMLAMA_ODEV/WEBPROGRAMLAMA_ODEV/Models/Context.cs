using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBPROGRAMLAMA_ODEV.Models
{
    public class Context:DbContext
    {
        /*VERİTABANINA YANSITMA YAPACAĞIMIZ SINIF
         * veritabınındaki tablolar*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB; database=DizileDB; integrated security=true;");
            /*SQL OBJECT EXPLORER SQL SERVERİN ADINI ALDIK VE BURAYA YAPIŞTIRDIK AMA ÇİFT \ İSTİYOR DİKKAT ET*/
        }

        /*Tanımladığımız tüm sınıflar*/
        //public DbSet<Filmler> FilmDB{ get; set; }
        public DbSet<Diziler> DiziDB{ get; set; }
        public DbSet<DiziTur> DiziTurDB { get; set; }
    }
}
