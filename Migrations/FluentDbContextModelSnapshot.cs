﻿// <auto-generated />
using System;
using EntityFrameworkCoreApp.FluentConvensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntityFrameworkCoreApp.Migrations
{
    [DbContext(typeof(FluentDbContext))]
    partial class FluentDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EntityFrameworkCoreApp.FluentConvensions.Kategori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kategoriler");
                });

            modelBuilder.Entity("EntityFrameworkCoreApp.FluentConvensions.KategoriUrun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Kategori_Id")
                        .HasColumnType("int");

                    b.Property<int>("Urun_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Kategori_Id");

                    b.HasIndex("Urun_Id");

                    b.ToTable("KategoriUrunleri");
                });

            modelBuilder.Entity("EntityFrameworkCoreApp.FluentConvensions.Kullanici", b =>
                {
                    b.Property<int>("Kullanici_Id")
                        .HasColumnType("int");

                    b.Property<string>("Adi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Kullanici_Id");

                    b.ToTable("Kullanicilar");
                });

            modelBuilder.Entity("EntityFrameworkCoreApp.FluentConvensions.Musteri", b =>
                {
                    b.Property<int>("Musteri_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Musteri_Id"));

                    b.Property<string>("Adi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyadı")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Musteri_Id");

                    b.ToTable("Musteriler");
                });

            modelBuilder.Entity("EntityFrameworkCoreApp.FluentConvensions.Siparis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("datetime2");

                    b.Property<double>("ToplamTutar")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Siparisler");
                });

            modelBuilder.Entity("EntityFrameworkCoreApp.FluentConvensions.SiparisDetay", b =>
                {
                    b.Property<int>("Siparis_Id")
                        .HasColumnType("int");

                    b.Property<int>("Urun_Id")
                        .HasColumnType("int");

                    b.Property<int>("Adet")
                        .HasColumnType("int");

                    b.Property<int>("Tutar")
                        .HasColumnType("int");

                    b.HasKey("Siparis_Id", "Urun_Id");

                    b.HasIndex("Urun_Id");

                    b.ToTable("SiparisDetaylari");
                });

            modelBuilder.Entity("EntityFrameworkCoreApp.FluentConvensions.Urun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Fiyat")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Urunler");
                });

            modelBuilder.Entity("EntityFrameworkCoreApp.FluentConvensions.KategoriUrun", b =>
                {
                    b.HasOne("EntityFrameworkCoreApp.FluentConvensions.Kategori", "Kategori")
                        .WithMany("KategoriUrunleri")
                        .HasForeignKey("Kategori_Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("EntityFrameworkCoreApp.FluentConvensions.Urun", "Urun")
                        .WithMany("UrunKategorileri")
                        .HasForeignKey("Urun_Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Kategori");

                    b.Navigation("Urun");
                });

            modelBuilder.Entity("EntityFrameworkCoreApp.FluentConvensions.Kullanici", b =>
                {
                    b.HasOne("EntityFrameworkCoreApp.FluentConvensions.Musteri", "Musteri")
                        .WithOne("Kullanici")
                        .HasForeignKey("EntityFrameworkCoreApp.FluentConvensions.Kullanici", "Kullanici_Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Musteri");
                });

            modelBuilder.Entity("EntityFrameworkCoreApp.FluentConvensions.SiparisDetay", b =>
                {
                    b.HasOne("EntityFrameworkCoreApp.FluentConvensions.Siparis", "Siparis")
                        .WithMany("SiparisDetaylari")
                        .HasForeignKey("Siparis_Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("EntityFrameworkCoreApp.FluentConvensions.Urun", "Urun")
                        .WithMany("SiparisDetaylari")
                        .HasForeignKey("Urun_Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Siparis");

                    b.Navigation("Urun");
                });

            modelBuilder.Entity("EntityFrameworkCoreApp.FluentConvensions.Kategori", b =>
                {
                    b.Navigation("KategoriUrunleri");
                });

            modelBuilder.Entity("EntityFrameworkCoreApp.FluentConvensions.Musteri", b =>
                {
                    b.Navigation("Kullanici");
                });

            modelBuilder.Entity("EntityFrameworkCoreApp.FluentConvensions.Siparis", b =>
                {
                    b.Navigation("SiparisDetaylari");
                });

            modelBuilder.Entity("EntityFrameworkCoreApp.FluentConvensions.Urun", b =>
                {
                    b.Navigation("SiparisDetaylari");

                    b.Navigation("UrunKategorileri");
                });
#pragma warning restore 612, 618
        }
    }
}
