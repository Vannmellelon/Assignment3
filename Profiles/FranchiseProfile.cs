using System.Linq;
using Assignment3.Models;
using Assignment3.Models.DTOs.Franchise;
using AutoMapper;

namespace Assignment3.Profiles
{
    public class FranchiseProfile : Profile
    {
        public FranchiseProfile()
        {
            CreateMap<Franchise, FranchiseCreateDTO>()
                // Mapping movie IDs, one2many
                .ForMember(fdto => fdto.Movies, opt => opt
                .MapFrom(f => f.Movies.Select(m => m.Id).ToList()))
                .ReverseMap();

            CreateMap<Franchise, FranchiseEditDTO>()
                .ForMember(fdto => fdto.Movies, opt => opt
                .MapFrom(f => f.Movies.Select(m => m.Id).ToList()))
                .ReverseMap();

            CreateMap<Franchise, FranchiseReadDTO>()
                .ForMember(fdto => fdto.Movies, opt => opt
                .MapFrom(f => f.Movies.Select(m => m.Id).ToList()))
                .ReverseMap();
        }
    }
}
