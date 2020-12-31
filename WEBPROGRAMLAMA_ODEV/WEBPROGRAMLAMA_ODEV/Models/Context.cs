using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBPROGRAMLAMA_ODEV.Models
{
    public class Context:DbContext
    {
        public Context()
        {
        }

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        /*Tanımladığımız tüm sınıflar*/
        //public DbSet<Filmler> FilmDB{ get; set; }

        public DbSet<Diziler> DiziTablo { get; set; }
        public DbSet<DiziTur> DiziTurTablo { get; set; }
        public DbSet<DiziTurDiziler> DiziTurDizilerTablo { get; set; }



        /*VERİTABANINA YANSITMA YAPACAĞIMIZ SINIF
         * veritabınındaki tablolar*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB; database=Dizile2DB; integrated security=true;");
            /*SQL OBJECT EXPLORER SQL SERVERİN ADINI ALDIK VE BURAYA YAPIŞTIRDIK AMA ÇİFT \ İSTİYOR DİKKAT ET*/
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DiziTurDiziler>()
                .HasKey(dd => new { dd.DiziID, dd.TurID });
            modelBuilder.Entity<DiziTurDiziler>()
                .HasOne(bc => bc.Dizi_iliski)
                .WithMany(b => b.DiziTur_Col)
                .HasForeignKey(bc => bc.DiziID);
            modelBuilder.Entity<DiziTurDiziler>()
                .HasOne(dd => dd.DiziTur_iliski)
                .WithMany(c => c.DiziTur_Col)
                .HasForeignKey(bc => bc.TurID);
        }



    }
}
