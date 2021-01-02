﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WEBPROGRAMLAMA_ODEV.Models;

namespace WEBPROGRAMLAMA_ODEV.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20210101233351_eren")]
    partial class eren
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("WEBPROGRAMLAMA_ODEV.Models.Admin", b =>
                {
                    b.Property<int>("AdminID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("KullaniciAdi")
                        .HasColumnType("Varchar(20)");

                    b.Property<string>("Sifre")
                        .HasColumnType("Varchar(10)");

                    b.HasKey("AdminID");

                    b.ToTable("AdminTablo");
                });

            modelBuilder.Entity("WEBPROGRAMLAMA_ODEV.Models.DiziTur", b =>
                {
                    b.Property<int>("TurID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Tur")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TurID");

                    b.ToTable("DiziTurTablo");
                });

            modelBuilder.Entity("WEBPROGRAMLAMA_ODEV.Models.DiziTurDiziler", b =>
                {
                    b.Property<int>("DiziID")
                        .HasColumnType("int");

                    b.Property<int>("TurID")
                        .HasColumnType("int");

                    b.HasKey("DiziID", "TurID");

                    b.HasIndex("TurID");

                    b.ToTable("DiziTurDizilerTablo");
                });

            modelBuilder.Entity("WEBPROGRAMLAMA_ODEV.Models.Diziler", b =>
                {
                    b.Property<int>("DiziID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DiziAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DiziBegeni")
                        .HasColumnType("int");

                    b.Property<string>("DiziBilgi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiziDosyaAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiziIMDB")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiziLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DiziSezonSayi")
                        .HasColumnType("int");

                    b.Property<string>("DiziStudyo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiziTarih")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DiziID");

                    b.ToTable("DiziTablo");
                });

            modelBuilder.Entity("WEBPROGRAMLAMA_ODEV.Models.Uyeler", b =>
                {
                    b.Property<int>("UyeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("KullaniciAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Parola")
                        .HasColumnType("int");

                    b.HasKey("UyeID");

                    b.ToTable("UyelerTablo");
                });

            modelBuilder.Entity("WEBPROGRAMLAMA_ODEV.Models.DiziTurDiziler", b =>
                {
                    b.HasOne("WEBPROGRAMLAMA_ODEV.Models.Diziler", "Dizi_iliski")
                        .WithMany("DiziTur_Col")
                        .HasForeignKey("DiziID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WEBPROGRAMLAMA_ODEV.Models.DiziTur", "DiziTur_iliski")
                        .WithMany("DiziTur_Col")
                        .HasForeignKey("TurID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dizi_iliski");

                    b.Navigation("DiziTur_iliski");
                });

            modelBuilder.Entity("WEBPROGRAMLAMA_ODEV.Models.DiziTur", b =>
                {
                    b.Navigation("DiziTur_Col");
                });

            modelBuilder.Entity("WEBPROGRAMLAMA_ODEV.Models.Diziler", b =>
                {
                    b.Navigation("DiziTur_Col");
                });
#pragma warning restore 612, 618
        }
    }
}
