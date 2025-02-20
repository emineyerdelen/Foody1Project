using AutoMapper;
using FoodyProject.DtoLayer.SocialMediaDto;
using FoodyProject.EntityLayer.Entities;

namespace FoodyProject.WebApi.Mapping
{
    public class SocialMediaMapping:Profile
    {
        public SocialMediaMapping()
        {
            CreateMap<SocialMedia,ResultSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia,CreateSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia,UpdateSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia,GetSocialMediaDto>().ReverseMap();
        }
    }
}
