using AutoMapper;
using FoodyProject.DtoLayer.BlogDto;
using FoodyProject.EntityLayer.Entities;

namespace FoodyProject.WebApi.Mapping
{
    public class BlogMapping:Profile
    {
        public BlogMapping()
        {
            CreateMap<Blog, ResultBlogDto>().ReverseMap();
            CreateMap<Blog, CreateBlogDto>().ReverseMap();
            CreateMap<Blog, UpdateBlogDto>().ReverseMap();
            CreateMap<Blog, GetBlogDto>().ReverseMap();
        }
    }
}
