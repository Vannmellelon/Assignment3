namespace Assignment3.Models.DTOs.Movie
{
    public class MovieEditDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int ReleaseYr { get; set; }
        public string Director { get; set; }
        public string Picture { get; set; }
        public string Trailer { get; set; }
        public int Franchise { get; set; }
        public int[] Characters { get; set; }
    }
}
