using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBPROGRAMLAMA_ODEV.Models
{
    public class Context : DbContext
    {
        /*Model Sınıflarını VT ye tablo olarak aktarmamızı sağlayacak Sınıf*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB; database=DizileDB; integrated security=true;");
            /*SQL OBJECT EXPLORER SQL SERVERİN ADINI ALDIK VE BURAYA YAPIŞTIRDIK AMA ÇİFT \ İSTİYOR DİKKAT ET*/
        }

        public DbSet<Filmler> FilmData{ get; set; }/*VT ye aktarılacak Filmler tablosu*/
        public DbSet<Diziler> DiziData{ get; set; }/*VT ye aktarılacak Diziler tablosu*/
    }
}
