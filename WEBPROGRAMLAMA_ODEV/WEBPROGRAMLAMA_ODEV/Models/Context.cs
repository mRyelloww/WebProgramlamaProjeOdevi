/**
* @ G191210351 Eren Can Sarı ve B191210351 İlker Küçücük
* @description Web Programlama Proje Ödevi
* @date 03.01.2021
*/
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEBPROGRAMLAMA_ODEV.Models
{
    public class Context:DbContext
    {
        /*BOŞ METOTLARI SİLME*/
        public Context()
        {
        }

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        /*Modellerin veritabanında tabloya dönüşmesini sağlayacak DbSet verileri*/
        public DbSet<Diziler> DiziTablo { get; set; }
        public DbSet<Admin> AdminTablo { get; set; }
        public DbSet<Uyeler> UyelerTablo { get; set; }

        /*VERİTABANINA YANSITMA YAPACAĞIMIZ SINIF
        /* veritabınındaki tablolar*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) /* Kullanılacak veri tabanına ait isim, server bilgisi burada giriliyor.*/
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB; database=DizileDB; integrated security=true;");
            /*SQL OBJECT EXPLORER SQL SERVERİN ADINI ALDIK VE BURAYA YAPIŞTIRDIK AMA ÇİFT \ İSTİYOR DİKKAT ET*/
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
