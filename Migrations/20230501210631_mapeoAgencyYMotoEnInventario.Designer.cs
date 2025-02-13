﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using guido_sanz_parcial1.Data;

#nullable disable

namespace guido_sanz_parcial1.Migrations
{
    [DbContext(typeof(MotoContext))]
    [Migration("20230501210631_mapeoAgencyYMotoEnInventario")]
    partial class mapeoAgencyYMotoEnInventario
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("guido_sanz_parcial1.Models.Agency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Agency");
                });

            modelBuilder.Entity("guido_sanz_parcial1.Models.Inventory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AgencyId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdAgency")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdMoto")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AgencyId");

                    b.HasIndex("IdAgency");

                    b.HasIndex("IdMoto");

                    b.ToTable("Inventory");
                });

            modelBuilder.Entity("guido_sanz_parcial1.Models.Moto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("CubicCentimeters")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<int>("Type")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Moto");
                });

            modelBuilder.Entity("guido_sanz_parcial1.Models.Inventory", b =>
                {
                    b.HasOne("guido_sanz_parcial1.Models.Agency", null)
                        .WithMany("InvertoryList")
                        .HasForeignKey("AgencyId");

                    b.HasOne("guido_sanz_parcial1.Models.Agency", "Agency")
                        .WithMany()
                        .HasForeignKey("IdAgency")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("guido_sanz_parcial1.Models.Moto", "Moto")
                        .WithMany()
                        .HasForeignKey("IdMoto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Agency");

                    b.Navigation("Moto");
                });

            modelBuilder.Entity("guido_sanz_parcial1.Models.Agency", b =>
                {
                    b.Navigation("InvertoryList");
                });
#pragma warning restore 612, 618
        }
    }
}
