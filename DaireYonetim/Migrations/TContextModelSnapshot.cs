﻿// <auto-generated />
using System;
using DaireYonetim.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DaireYonetim.Migrations
{
    [DbContext(typeof(TContext))]
    partial class TContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DaireYonetim.Entity.Aidat", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Ay")
                        .HasColumnType("int");

                    b.Property<int>("DaireID")
                        .HasColumnType("int");

                    b.Property<bool>("Odendimi")
                        .HasColumnType("bit");

                    b.Property<int>("Tutar")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Aidat");
                });

            modelBuilder.Entity("DaireYonetim.Entity.Daire", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BlokAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Bosmu")
                        .HasColumnType("bit");

                    b.Property<int>("BulunduguKat")
                        .HasColumnType("int");

                    b.Property<int>("DaireNo")
                        .HasColumnType("int");

                    b.Property<string>("SahibiYadaKiraci")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Daire");
                });

            modelBuilder.Entity("DaireYonetim.Entity.Fatura", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Ay")
                        .HasColumnType("int");

                    b.Property<int>("DaireID")
                        .HasColumnType("int");

                    b.Property<bool>("Odendimi")
                        .HasColumnType("bit");

                    b.Property<int>("Tutar")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Fatura");
                });

            modelBuilder.Entity("DaireYonetim.Entity.Kullanici", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdSoyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AracPlaka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DaireID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TCNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Kullanici");
                });

            modelBuilder.Entity("DaireYonetim.Entity.Mesaj", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KullanıcıID")
                        .HasColumnType("int");

                    b.Property<string>("Metin")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Okundumu")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Mesaj");
                });
#pragma warning restore 612, 618
        }
    }
}
