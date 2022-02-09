using System.Collections.Generic;

namespace Assignment3.Models.DTOs.Character
{
    public class CharacterCreateDTO
    {
        public string Name { get; set; }
        public string Alias { get; set; }
        public char Gender { get; set; }
        public string Picture { get; set; }
    }
}
