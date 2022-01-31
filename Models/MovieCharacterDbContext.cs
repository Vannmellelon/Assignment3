using Microsoft.EntityFrameworkCore;

namespace Assignment3.Models
{
    public class MovieCharacterDbContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Franchise> Franchises { get; set; }
        public DbSet<MovieCharacter> JoinMovieCharacter { get; set; }


        // Composite Key for the MovieCharacter joining table
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieCharacter>().HasKey(pq => new { pq.MovieId, pq.CharacterId });
        }
        // Setup Db (?)
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=ND-5CG92747KF\\SQLEXPRESS;" +
                "Initial Catalog=MovieCharactersDb;" +
                "Trusted_Connection=True;");
        }
    }
}
