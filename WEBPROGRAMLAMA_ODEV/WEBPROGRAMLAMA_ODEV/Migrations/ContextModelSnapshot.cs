﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WEBPROGRAMLAMA_ODEV.Models;

namespace WEBPROGRAMLAMA_ODEV.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("WEBPROGRAMLAMA_ODEV.Models.Diziler", b =>
                {
                    b.Property<int>("DiziID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DiziAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DiziOy")
                        .HasColumnType("int");

                    b.Property<string>("DiziOzet")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DiziID");

                    b.ToTable("DiziData");
                });

            modelBuilder.Entity("WEBPROGRAMLAMA_ODEV.Models.Filmler", b =>
                {
                    b.Property<int>("FilmID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("FilmAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FilmOy")
                        .HasColumnType("int");

                    b.Property<string>("FilmOzet")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FilmID");

                    b.ToTable("FilmData");
                });
#pragma warning restore 612, 618
        }
    }
}