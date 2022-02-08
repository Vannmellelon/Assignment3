namespace Assignment3.Models.DTOs.Franchise
{
    public class FranchiseCreateDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int[] Movies { get; set; }
    }
}
