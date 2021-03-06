using System.Collections.Generic;

namespace Assignment3.Models.DTOs.Movie
{
    public class MovieReadDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int ReleaseYr { get; set; }
        public string Director { get; set; }
        public string Picture { get; set; }
        public string Trailer { get; set; }
        public int Franchise { get; set; }
        public List<int> Characters { get; set; }
    }
}
