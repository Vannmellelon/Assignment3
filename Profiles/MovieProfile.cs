using System.Linq;
using Assignment3.Models;
using Assignment3.Models.DTOs.Movie;
using AutoMapper;

namespace Assignment3.Profiles
{
    public class MovieProfile :Profile
    {
        public MovieProfile()
        {
            CreateMap<Movie, MovieCreateDTO>()
                // Mapping franchise ID one2many
                .ForMember(mdto => mdto.Franchise, opt => opt
                .MapFrom(m => m.FranchiseId))
                .ReverseMap();

            CreateMap<Movie, MovieEditDTO>()
                .ForMember(mdto => mdto.Franchise, opt => opt
                .MapFrom(m => m.FranchiseId))
                // character IDs m2m
                .ForMember(mdto => mdto.Characters, opt => opt
                .MapFrom(m => m.MovieCharacter.Select(mc => mc.CharacterId).ToList()))
                .ReverseMap();

            CreateMap<Movie, MovieReadDTO>()
                .ForMember(mdto => mdto.Franchise, opt => opt
                .MapFrom(m => m.FranchiseId))
                .ForMember(mdto => mdto.Characters, opt => opt
                .MapFrom(m => m.MovieCharacter.Select(mc => mc.CharacterId).ToList()))
                .ReverseMap();
        }
    }
}
