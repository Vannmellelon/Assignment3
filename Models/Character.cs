using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment3.Models
{
    [Table("Character")]
    public class Character
    {
        // PK
        public int Id { get; set; }

        // Fields
        [Required, MaxLength(64)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Alias { get; set; }

        public char Gender { get; set; }

        [MaxLength(int.MaxValue)]
        public string Picture { get; set; } 

        // Relations
        public ICollection<MovieCharacter> MovieCharacter { get; set; }

    }
}
