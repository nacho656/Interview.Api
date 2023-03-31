using AutoMapper;
using Interview.Api.Domain;
using Interview.Api.Features.MediaFeature.Models;

namespace Interview.Api.Features.MediaFeature
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Media, MediaDto>()
                .ForMember(dest => dest.Genre, opts => opts.MapFrom(x => x.Genre.Name));
        }
    }
}
