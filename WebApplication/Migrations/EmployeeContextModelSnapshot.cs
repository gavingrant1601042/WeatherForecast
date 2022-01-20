﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication.Models;

namespace WebApplication.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    partial class EmployeeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("WebApplication.Models.Clouds", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<long>("All")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.ToTable("Clouds");
                });

            modelBuilder.Entity("WebApplication.Models.Coord", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<double>("Lat")
                        .HasColumnType("float");

                    b.Property<double>("Lon")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.ToTable("Coord");
                });

            modelBuilder.Entity("WebApplication.Models.Employee", b =>
                {
                    b.Property<string>("EmailId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("telephone")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("address_location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("role")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmailId", "telephone");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("WebApplication.Models.Main", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<long>("Humidity")
                        .HasColumnType("bigint");

                    b.Property<double>("Percepita")
                        .HasColumnType("float");

                    b.Property<long>("Pressure")
                        .HasColumnType("bigint");

                    b.Property<double>("TempMax")
                        .HasColumnType("float");

                    b.Property<double>("TempMin")
                        .HasColumnType("float");

                    b.Property<double>("Temperature")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.ToTable("Main");
                });

            modelBuilder.Entity("WebApplication.Models.Sys", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Message")
                        .HasColumnType("float");

                    b.Property<long>("Sunrise")
                        .HasColumnType("bigint");

                    b.Property<long>("Sunset")
                        .HasColumnType("bigint");

                    b.Property<long>("Type")
                        .HasColumnType("bigint");

                    b.Property<long>("weatherinformation")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.ToTable("Sys");
                });

            modelBuilder.Entity("WebApplication.Models.WeatherData", b =>
                {
                    b.Property<string>("Base")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CloudsID")
                        .HasColumnType("int");

                    b.Property<long>("Cod")
                        .HasColumnType("bigint");

                    b.Property<int?>("CoordID")
                        .HasColumnType("int");

                    b.Property<long>("Dt")
                        .HasColumnType("bigint");

                    b.Property<int?>("MainID")
                        .HasColumnType("int");

                    b.Property<int?>("SysID")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Visibility")
                        .HasColumnType("bigint");

                    b.Property<long>("WeatherDetails")
                        .HasColumnType("bigint");

                    b.Property<int?>("WindID")
                        .HasColumnType("int");

                    b.HasIndex("CloudsID");

                    b.HasIndex("CoordID");

                    b.HasIndex("MainID");

                    b.HasIndex("SysID");

                    b.HasIndex("WindID");

                    b.ToTable("Weather");
                });

            modelBuilder.Entity("WebApplication.Models.Wind", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<long>("Deg")
                        .HasColumnType("bigint");

                    b.Property<double>("Speed")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.ToTable("Wind");
                });

            modelBuilder.Entity("WebApplication.Models.WeatherData", b =>
                {
                    b.HasOne("WebApplication.Models.Clouds", "Clouds")
                        .WithMany()
                        .HasForeignKey("CloudsID");

                    b.HasOne("WebApplication.Models.Coord", "Coord")
                        .WithMany()
                        .HasForeignKey("CoordID");

                    b.HasOne("WebApplication.Models.Main", "Main")
                        .WithMany()
                        .HasForeignKey("MainID");

                    b.HasOne("WebApplication.Models.Sys", "Sys")
                        .WithMany()
                        .HasForeignKey("SysID");

                    b.HasOne("WebApplication.Models.Wind", "Wind")
                        .WithMany()
                        .HasForeignKey("WindID");

                    b.Navigation("Clouds");

                    b.Navigation("Coord");

                    b.Navigation("Main");

                    b.Navigation("Sys");

                    b.Navigation("Wind");
                });
#pragma warning restore 612, 618
        }
    }
}
