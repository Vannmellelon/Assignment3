﻿namespace Assignment3.Models.DTOs.Franchise
{
    public class FranchiseReadDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int[] Movies { get; set; }
    }
}
