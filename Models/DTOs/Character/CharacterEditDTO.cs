namespace Assignment3.Models.DTOs.Character
{
    public class CharacterEditDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Alias { get; set; }
        public char Gender { get; set; }
        public string Picture { get; set; }
        public int Movie { get; set; }
    }
}
