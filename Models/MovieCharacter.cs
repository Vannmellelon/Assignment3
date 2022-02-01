using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment3.Models
{
    [Table("MovieCharacter")]
    public class MovieCharacter
    {
        // Joining class for Movie and Character
        [Required]
        public int MovieId { get; set; }

        public Movie Movie { get; set; }

        [Required]
        public int CharacterId { get; set; }

        public Character Character { get; set; }

    }
}
