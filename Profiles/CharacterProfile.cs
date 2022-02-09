using System.Linq;
using Assignment3.Models;
using Assignment3.Models.DTOs.Character;
using AutoMapper;

namespace Assignment3.Profiles
{
    public class CharacterProfile : Profile
    {
        public CharacterProfile()
        {

            CreateMap<Character, CharacterCreateDTO>()
                .ReverseMap();

            // Mapping movie IDs, m2m
            CreateMap<Character, CharacterEditDTO>()
                .ForMember(cdto => cdto.Movies, opt => opt
                .MapFrom(c => c.MovieCharacter.Select(mc => mc.MovieId).ToList()))
                .ReverseMap();

            CreateMap<Character, CharacterReadDTO>()
                .ForMember(cdto => cdto.Movies, opt => opt
                .MapFrom(c => c.MovieCharacter.Select(mc => mc.MovieId).ToList()))
                .ReverseMap();
        }
    }
}
