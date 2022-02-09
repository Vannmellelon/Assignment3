﻿// <auto-generated />
using System;
using Assignment3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Assignment3.Migrations
{
    [DbContext(typeof(MovieCharacterDbContext))]
    partial class MovieCharacterDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Assignment3.Models.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Alias")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("Picture")
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Character");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Alias = "Onion ogre",
                            Gender = "M",
                            Name = "Shrek",
                            Picture = "https://upload.wikimedia.org/wikipedia/en/4/4d/Shrek_%28character%29.png"
                        },
                        new
                        {
                            Id = 2,
                            Alias = "Princess Fiona",
                            Gender = "F",
                            Name = "Fiona",
                            Picture = "https://upload.wikimedia.org/wikipedia/en/b/b9/Princess_Fiona.png"
                        },
                        new
                        {
                            Id = 3,
                            Alias = "Donkey!",
                            Gender = "D",
                            Name = "Donkey",
                            Picture = "https://upload.wikimedia.org/wikipedia/en/6/6c/Donkey_%28Shrek%29.png"
                        },
                        new
                        {
                            Id = 4,
                            Gender = "F",
                            Name = "Haname Jinchoge"
                        },
                        new
                        {
                            Id = 5,
                            Gender = "M",
                            Name = "Gas"
                        },
                        new
                        {
                            Id = 6,
                            Alias = "Verdens verste menneske",
                            Gender = "F",
                            Name = "Julie"
                        },
                        new
                        {
                            Id = 7,
                            Gender = "M",
                            Name = "Anders"
                        },
                        new
                        {
                            Id = 8,
                            Gender = "M",
                            Name = "Phillip"
                        });
                });

            modelBuilder.Entity("Assignment3.Models.Franchise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("Id");

                    b.ToTable("Franchise");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Shrek movies good :)",
                            Name = "Shrek"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Movie trilogy by director Joachim Trier.",
                            Name = "Trier movies"
                        });
                });

            modelBuilder.Entity("Assignment3.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<int?>("FranchiseId")
                        .HasColumnType("int");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Picture")
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReleaseYr")
                        .HasMaxLength(4)
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Trailer")
                        .HasMaxLength(2147483647)
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FranchiseId");

                    b.ToTable("Movie");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Director = "Andrew Adamson, Vicky Jenson",
                            FranchiseId = 1,
                            Genre = "Animation,Adventure,Comedy,Family,Fantasy,Romance",
                            ReleaseYr = 2001,
                            Title = "Shrek"
                        },
                        new
                        {
                            Id = 2,
                            Director = "Andrew Adamson, Kelly Asbury, Conrad Vernon",
                            FranchiseId = 1,
                            Genre = "Animation,Adventure,Comedy,Family,Fantasy,Romance",
                            ReleaseYr = 2004,
                            Title = "Shrek 2"
                        },
                        new
                        {
                            Id = 3,
                            Director = "Chris Miller, Raman Hui",
                            FranchiseId = 1,
                            Genre = "Animation,Adventure,Comedy,Family,Fantasy,Romance",
                            ReleaseYr = 2007,
                            Title = "Shrek the Third"
                        },
                        new
                        {
                            Id = 4,
                            Director = "Satoshi Miki",
                            Genre = "Comedy",
                            ReleaseYr = 2009,
                            Title = "Instant Swamp",
                            Trailer = "https://youtu.be/NPEscG_jLVY"
                        },
                        new
                        {
                            Id = 5,
                            Director = "Joachim Trier",
                            FranchiseId = 2,
                            Genre = "Comedy,Drama,Romance",
                            Picture = "https://www.nfkino.no/sites/nfkino.no/files/styles/movie_poster/public/media-images/2021-09/PosterKinoklubbBokma%CC%8Al.jpg?itok=hBhcFy9R",
                            ReleaseYr = 2022,
                            Title = "Verdens verste menneske"
                        },
                        new
                        {
                            Id = 6,
                            Director = "Joachim Trier",
                            FranchiseId = 2,
                            Genre = "Drama",
                            ReleaseYr = 2011,
                            Title = "Oslo, 31. august"
                        },
                        new
                        {
                            Id = 7,
                            Director = "Joachim Trier",
                            FranchiseId = 2,
                            Genre = "Drama",
                            ReleaseYr = 2006,
                            Title = "Reprise"
                        });
                });

            modelBuilder.Entity("Assignment3.Models.MovieCharacter", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("CharacterId")
                        .HasColumnType("int");

                    b.HasKey("MovieId", "CharacterId");

                    b.HasIndex("CharacterId");

                    b.ToTable("MovieCharacter");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            CharacterId = 1
                        },
                        new
                        {
                            MovieId = 2,
                            CharacterId = 1
                        },
                        new
                        {
                            MovieId = 3,
                            CharacterId = 1
                        },
                        new
                        {
                            MovieId = 1,
                            CharacterId = 2
                        },
                        new
                        {
                            MovieId = 2,
                            CharacterId = 2
                        },
                        new
                        {
                            MovieId = 3,
                            CharacterId = 2
                        },
                        new
                        {
                            MovieId = 1,
                            CharacterId = 3
                        },
                        new
                        {
                            MovieId = 2,
                            CharacterId = 3
                        },
                        new
                        {
                            MovieId = 3,
                            CharacterId = 3
                        },
                        new
                        {
                            MovieId = 4,
                            CharacterId = 4
                        },
                        new
                        {
                            MovieId = 4,
                            CharacterId = 5
                        },
                        new
                        {
                            MovieId = 5,
                            CharacterId = 6
                        },
                        new
                        {
                            MovieId = 6,
                            CharacterId = 7
                        },
                        new
                        {
                            MovieId = 7,
                            CharacterId = 8
                        });
                });

            modelBuilder.Entity("Assignment3.Models.Movie", b =>
                {
                    b.HasOne("Assignment3.Models.Franchise", "Franchise")
                        .WithMany("Movies")
                        .HasForeignKey("FranchiseId");

                    b.Navigation("Franchise");
                });

            modelBuilder.Entity("Assignment3.Models.MovieCharacter", b =>
                {
                    b.HasOne("Assignment3.Models.Character", "Character")
                        .WithMany("MovieCharacter")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Assignment3.Models.Movie", "Movie")
                        .WithMany("MovieCharacter")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Character");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("Assignment3.Models.Character", b =>
                {
                    b.Navigation("MovieCharacter");
                });

            modelBuilder.Entity("Assignment3.Models.Franchise", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("Assignment3.Models.Movie", b =>
                {
                    b.Navigation("MovieCharacter");
                });
#pragma warning restore 612, 618
        }
    }
}
