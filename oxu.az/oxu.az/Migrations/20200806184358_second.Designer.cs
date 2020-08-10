﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using oxu.az.Contexts;

namespace oxu.az.Migrations
{
    [DbContext(typeof(NewsContext))]
    [Migration("20200806184358_second")]
    partial class second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("oxu.az.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Siyasət"
                        },
                        new
                        {
                            Id = 2,
                            Name = "İqtisadiyyat"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Cəmiyyət"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Şou-Biznes"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Müharibə"
                        },
                        new
                        {
                            Id = 6,
                            Name = "İdman"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Kriminal"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Mədəniyyət"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Dünya"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Avto-Moto"
                        },
                        new
                        {
                            Id = 11,
                            Name = "İKT"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Turizm"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Maraqlı"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Müsahibə"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Baku TV"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Cinema Plus"
                        });
                });

            modelBuilder.Entity("oxu.az.Models.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("Like")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("Unlike")
                        .HasColumnType("int");

                    b.Property<int>("View")
                        .HasColumnType("int");

                    b.Property<bool>("isMain")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("News");
                });

            modelBuilder.Entity("oxu.az.Models.News", b =>
                {
                    b.HasOne("oxu.az.Models.Category", "Category")
                        .WithMany("News")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
