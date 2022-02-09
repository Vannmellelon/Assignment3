using System.Collections.Generic;

namespace Assignment3.Models.DTOs.Character
{
    public class CharacterReadDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public char Gender { get; set; }
        public string Picture { get; set; }
        public List<int> Movies { get; set; }
    }
}
