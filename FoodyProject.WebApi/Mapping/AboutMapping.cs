using AutoMapper;
using FoodyProject.DtoLayer.AboutDto;
using FoodyProject.EntityLayer.Entities;

namespace FoodyProject.WebApi.Mapping
{
    public class AboutMapping:Profile
    {
        public AboutMapping()
        {
            CreateMap<About, ResultAboutDto>().ReverseMap();
            CreateMap<About, CreateAboutDto>().ReverseMap();
            CreateMap<About, UpdateAboutDto>().ReverseMap();
            CreateMap<About, GetAboutDto>().ReverseMap();
        }
    }
}
