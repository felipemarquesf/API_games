﻿// <auto-generated />
using System;
using Games.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Games.Migrations
{
    [DbContext(typeof(GamesContext))]
    [Migration("20250224212403_campoSituacao")]
    partial class campoSituacao
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("Games.Models.GamesModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("EstiloDoJogo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeDaEmpresa")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeDoJogo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Situacao")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Game");
                });
#pragma warning restore 612, 618
        }
    }
}
