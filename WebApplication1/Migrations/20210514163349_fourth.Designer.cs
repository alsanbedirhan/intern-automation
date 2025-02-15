﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Models;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20210514163349_fourth")]
    partial class fourth
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication1.Models.Aday", b =>
                {
                    b.Property<int>("AdayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdayAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdayAdres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("AdayDogumTarihi")
                        .HasColumnType("Date");

                    b.Property<string>("AdayEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdaySoyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdayTelefon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdayId");

                    b.ToTable("Adays");
                });

            modelBuilder.Entity("WebApplication1.Models.Basvuru", b =>
                {
                    b.Property<int>("BasvuruID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AdayID")
                        .HasColumnType("int");

                    b.Property<string>("Durumu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IlanID")
                        .HasColumnType("int");

                    b.Property<int>("Puan")
                        .HasColumnType("int");

                    b.HasKey("BasvuruID");

                    b.ToTable("Basvurus");
                });

            modelBuilder.Entity("WebApplication1.Models.Deneyim", b =>
                {
                    b.Property<int>("DeneyimID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdayID")
                        .HasColumnType("int");

                    b.Property<DateTime>("BaslangicTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("BitisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirmaAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pozisyon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DeneyimID");

                    b.ToTable("Deneyims");
                });

            modelBuilder.Entity("WebApplication1.Models.Egitim", b =>
                {
                    b.Property<int>("EgitimID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdayID")
                        .HasColumnType("int");

                    b.Property<DateTime>("BaslangicTarihi")
                        .HasColumnType("Date");

                    b.Property<DateTime>("BitisTarihi")
                        .HasColumnType("Date");

                    b.Property<string>("BolumAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EgitimDurumu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OkulAdi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EgitimID");

                    b.ToTable("Egitims");
                });

            modelBuilder.Entity("WebApplication1.Models.Ilan", b =>
                {
                    b.Property<int>("IlanID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IlanAciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IlanAktifMi")
                        .HasColumnType("bit");

                    b.Property<DateTime>("IlanBaslangicTarihi")
                        .HasColumnType("Date");

                    b.Property<DateTime>("IlanBitisTarihi")
                        .HasColumnType("Date");

                    b.HasKey("IlanID");

                    b.ToTable("Ilans");
                });
#pragma warning restore 612, 618
        }
    }
}
