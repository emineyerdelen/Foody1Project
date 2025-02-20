using AutoMapper;
using FoodyProject.DtoLayer.CategoryDto;
using FoodyProject.EntityLayer.Entities;

namespace FoodyProject.WebApi.Mapping
{
    public class CategoryMapping:Profile
    {
        public CategoryMapping()
        {
            CreateMap<Category,ResultCategoryDto>().ReverseMap();
            CreateMap<Category,CreateCategoryDto>().ReverseMap();
            CreateMap<Category,UpdateCategoryDto>().ReverseMap();
            CreateMap<Category,GetCategoryDto>().ReverseMap();
        }
    }
}
