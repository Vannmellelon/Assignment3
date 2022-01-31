namespace Assignment3.Models
{
    public class MovieCharacter
    {
        // Joining class for Movie and Character
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public int CharacterId { get; set; }
        public Character Character { get; set; }

    }
}
