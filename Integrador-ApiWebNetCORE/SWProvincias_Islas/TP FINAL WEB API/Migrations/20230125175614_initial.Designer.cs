﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TP_FINAL_WEB_API.Data;

namespace TP_FINAL_WEB_API.Migrations
{
    [DbContext(typeof(DBPaisFinalContext))]
    [Migration("20230125175614_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TP_FINAL_WEB_API.Models.Ciudad", b =>
                {
                    b.Property<int>("IdCiudad")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdProvincia")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int?>("provinciaIdProvincia")
                        .HasColumnType("int");

                    b.HasKey("IdCiudad");

                    b.HasIndex("provinciaIdProvincia");

                    b.ToTable("Ciudades");
                });

            modelBuilder.Entity("TP_FINAL_WEB_API.Models.Provincia", b =>
                {
                    b.Property<int>("IdProvincia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("IdProvincia");

                    b.ToTable("Provincia");
                });

            modelBuilder.Entity("TP_FINAL_WEB_API.Models.Ciudad", b =>
                {
                    b.HasOne("TP_FINAL_WEB_API.Models.Provincia", "provincia")
                        .WithMany("ciudades")
                        .HasForeignKey("provinciaIdProvincia");
                });
#pragma warning restore 612, 618
        }
    }
}
