using System.Collections.Generic;

namespace Assignment3.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; } // CSV
        public int ReleaseYr { get; set; } // DateTime?? njaa
        public string Director { get; set; }
        public string Picture { get; set; } // pic-URL, nullable
        public string Trailer { get; set; } // yt-link, nullable
        public int FranchiseId { get; set; } // FK
        public Franchise Franchise { get; set; }
        public ICollection<MovieCharacter> MovieCharacter { get; set; }

    }
}
