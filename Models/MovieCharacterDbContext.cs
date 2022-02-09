using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

namespace Assignment3.Models
{
    public class MovieCharacterDbContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Franchise> Franchises { get; set; }
        public DbSet<MovieCharacter> JoinMovieCharacter { get; set; }

        // 
        public MovieCharacterDbContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Composite Key for the MovieCharacter joining table
            modelBuilder.Entity<MovieCharacter>().HasKey(pq => new { pq.MovieId, pq.CharacterId });

            // Seeding
            // some Shrek movies
            modelBuilder.Entity<Franchise>().HasData(new Franchise { Id = 1, Name = "Shrek", Description = "Shrek movies good :)" });
            modelBuilder.Entity<Movie>().HasData(new Movie { Id = 1, Title = "Shrek", Genre = "Animation,Adventure,Comedy,Family,Fantasy,Romance", Director = "Andrew Adamson, Vicky Jenson", ReleaseYr = 2001, FranchiseId = 1 });
            modelBuilder.Entity<Movie>().HasData(new Movie { Id = 2, Title = "Shrek 2", Genre = "Animation,Adventure,Comedy,Family,Fantasy,Romance", Director = "Andrew Adamson, Kelly Asbury, Conrad Vernon", ReleaseYr = 2004, FranchiseId = 1 });
            modelBuilder.Entity<Movie>().HasData(new Movie { Id = 3, Title = "Shrek the Third", Genre = "Animation,Adventure,Comedy,Family,Fantasy,Romance", Director = "Chris Miller, Raman Hui", ReleaseYr = 2007, FranchiseId = 1 });
            modelBuilder.Entity<Character>().HasData(new Character { Id = 1, Name = "Shrek", Alias = "Onion ogre", Gender = 'M', Picture = "https://upload.wikimedia.org/wikipedia/en/4/4d/Shrek_%28character%29.png" });
            modelBuilder.Entity<Character>().HasData(new Character { Id = 2, Name = "Fiona", Alias = "Princess Fiona", Gender = 'F', Picture = "https://upload.wikimedia.org/wikipedia/en/b/b9/Princess_Fiona.png" });
            modelBuilder.Entity<Character>().HasData(new Character { Id = 3, Name = "Donkey", Alias = "Donkey!", Gender = 'D', Picture = "https://upload.wikimedia.org/wikipedia/en/6/6c/Donkey_%28Shrek%29.png" });

            // Instant Swamp <3
            modelBuilder.Entity<Movie>().HasData(new Movie { Id = 4, Title = "Instant Swamp", Genre = "Comedy", Director = "Satoshi Miki", ReleaseYr = 2009, Trailer = "https://youtu.be/NPEscG_jLVY" });
            modelBuilder.Entity<Character>().HasData(new Character { Id = 4, Name = "Haname Jinchoge", Gender = 'F' });
            modelBuilder.Entity<Character>().HasData(new Character { Id = 5, Name = "Gas", Gender = 'M' });

            // Trier movies
            modelBuilder.Entity<Franchise>().HasData(new Franchise { Id = 2, Name = "Trier movies", Description = "Movie trilogy by director Joachim Trier." });
            modelBuilder.Entity<Movie>().HasData(new Movie { Id = 5, Title = "Verdens verste menneske", Genre = "Comedy,Drama,Romance", Director = "Joachim Trier", Picture = "https://www.nfkino.no/sites/nfkino.no/files/styles/movie_poster/public/media-images/2021-09/PosterKinoklubbBokma%CC%8Al.jpg?itok=hBhcFy9R", ReleaseYr = 2022, FranchiseId = 2 });
            modelBuilder.Entity<Movie>().HasData(new Movie { Id = 6, Title = "Oslo, 31. august", Genre = "Drama", Director = "Joachim Trier", ReleaseYr = 2011, FranchiseId = 2 });
            modelBuilder.Entity<Movie>().HasData(new Movie { Id = 7, Title = "Reprise", Genre = "Drama", Director = "Joachim Trier", ReleaseYr = 2006, FranchiseId = 2 });
            modelBuilder.Entity<Character>().HasData(new Character { Id = 6, Name = "Julie", Alias = "Verdens verste menneske", Gender = 'F'});
            modelBuilder.Entity<Character>().HasData(new Character { Id = 7, Name = "Anders", Gender = 'M' });
            modelBuilder.Entity<Character>().HasData(new Character { Id = 8, Name = "Phillip", Gender = 'M' });

            // m2m relationship, MovieCharacters
            modelBuilder.Entity<MovieCharacter>().HasData(new MovieCharacter { MovieId = 1, CharacterId = 1});
            modelBuilder.Entity<MovieCharacter>().HasData(new MovieCharacter { MovieId = 2, CharacterId = 1 });
            modelBuilder.Entity<MovieCharacter>().HasData(new MovieCharacter { MovieId = 3, CharacterId = 1 });
            modelBuilder.Entity<MovieCharacter>().HasData(new MovieCharacter { MovieId = 1, CharacterId = 2 });
            modelBuilder.Entity<MovieCharacter>().HasData(new MovieCharacter { MovieId = 2, CharacterId = 2 });
            modelBuilder.Entity<MovieCharacter>().HasData(new MovieCharacter { MovieId = 3, CharacterId = 2 });
            modelBuilder.Entity<MovieCharacter>().HasData(new MovieCharacter { MovieId = 1, CharacterId = 3 });
            modelBuilder.Entity<MovieCharacter>().HasData(new MovieCharacter { MovieId = 2, CharacterId = 3 });
            modelBuilder.Entity<MovieCharacter>().HasData(new MovieCharacter { MovieId = 3, CharacterId = 3 });

            modelBuilder.Entity<MovieCharacter>().HasData(new MovieCharacter { MovieId = 4, CharacterId = 4 });
            modelBuilder.Entity<MovieCharacter>().HasData(new MovieCharacter { MovieId = 4, CharacterId = 5 });

            modelBuilder.Entity<MovieCharacter>().HasData(new MovieCharacter { MovieId = 5, CharacterId = 6 });
            modelBuilder.Entity<MovieCharacter>().HasData(new MovieCharacter { MovieId = 6, CharacterId = 7 });
            modelBuilder.Entity<MovieCharacter>().HasData(new MovieCharacter { MovieId = 7, CharacterId = 8 });


        }
    }
}
