using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment3.Models
{
    [Table("Movie")]
    public class Movie
    {
        // PK
        public int Id { get; set; }

        // Fields
        [Required, MaxLength(100)]
        public string Title { get; set; }

        [Required, MaxLength(int.MaxValue)]
        public string Genre { get; set; } // CSV

        [Required, MaxLength(4)]
        public int ReleaseYr { get; set; } 

        [Required, MaxLength(64)]
        public string Director { get; set; }

        [MaxLength(int.MaxValue)]
        public string Picture { get; set; } // pic-URL

        [MaxLength(int.MaxValue)]
        public string Trailer { get; set; } // yt-link

        // Relations
        public int FranchiseId { get; set; } // FK, doesn't have to be in a franchise, so nullable/optional
        public Franchise Franchise { get; set; }
        public ICollection<MovieCharacter> MovieCharacter { get; set; }
    }
}
