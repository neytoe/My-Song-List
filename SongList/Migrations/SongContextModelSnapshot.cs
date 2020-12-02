﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SongList.Models;

namespace SongList.Migrations
{
    [DbContext(typeof(SongContext))]
    partial class SongContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SongList.Models.Genre", b =>
                {
                    b.Property<string>("GenreId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            GenreId = "M",
                            Name = "Metal"
                        },
                        new
                        {
                            GenreId = "N",
                            Name = "Nord"
                        },
                        new
                        {
                            GenreId = "H",
                            Name = "HipHop"
                        },
                        new
                        {
                            GenreId = "R",
                            Name = "Rock"
                        });
                });

            modelBuilder.Entity("SongList.Models.Song", b =>
                {
                    b.Property<int>("SongID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GenreId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Rating")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("year")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("SongID");

                    b.HasIndex("GenreId");

                    b.ToTable("Songs");

                    b.HasData(
                        new
                        {
                            SongID = 1,
                            GenreId = "M",
                            Name = "Love is Blind",
                            Rating = 5,
                            year = 1980
                        },
                        new
                        {
                            SongID = 2,
                            GenreId = "H",
                            Name = "Love is Bitter",
                            Rating = 4,
                            year = 1981
                        },
                        new
                        {
                            SongID = 3,
                            GenreId = "N",
                            Name = "Love is Sour",
                            Rating = 3,
                            year = 1983
                        });
                });

            modelBuilder.Entity("SongList.Models.Song", b =>
                {
                    b.HasOne("SongList.Models.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
