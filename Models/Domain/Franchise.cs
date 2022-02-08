using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment3.Models
{
    [Table("Franchise")]
    public class Franchise
    {
        // PK
        public int Id { get; set; }

        // Fields
        [Required, MaxLength(64)]
        public string Name { get; set; }

        [Required, MaxLength(int.MaxValue)]
        public string Description { get; set; }

        // Relations
        public ICollection<Movie> Movies { get; set; }
    }
}
