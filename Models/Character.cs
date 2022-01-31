using System.Collections.Generic;

namespace Assignment3.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; } // nullable
        public char Gender { get; set; }
        public string Picture { get; set; } // pic-URL, nullable
        public ICollection<MovieCharacter> MovieCharacter { get; set; }

    }
}
