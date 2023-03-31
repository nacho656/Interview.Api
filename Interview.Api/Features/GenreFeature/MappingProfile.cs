using AutoMapper;
using Interview.Api.Domain;
using Interview.Api.Features.GenreFeature.Models;

namespace Interview.Api.Features.Genres
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Genre, GenreDto>();
        }
    }
}
