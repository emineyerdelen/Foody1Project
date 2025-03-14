using AutoMapper;
using FoodyProject.BusinessLayer.Abstract;
using FoodyProject.DtoLayer.BlogDto;
using FoodyProject.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IBlogService _blogService;
        private readonly IMapper _mapper;

        public BlogController(IBlogService blogService, IMapper mapper)
        {
            _blogService = blogService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult BlogList()
        {
            var value = _mapper.Map<List<ResultBlogDto>>(_blogService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateBlog(CreateBlogDto createBlogDto)
        {
            _blogService.TAdd(new Blog()
            {
                BlogAuthor = createBlogDto.BlogAuthor,
                BlogContent=createBlogDto.BlogContent,
                BlogDate=createBlogDto.BlogDate,
                BlogImageUrl= createBlogDto.BlogImageUrl,
                BlogTitle= createBlogDto.BlogTitle
            });

            return Ok("Blog Eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBlog(int id)
        {
            var value = _blogService.TGetByID(id);
            _blogService.TDelete(value);
            return Ok("Blog Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetBlog(int id)
        {
            var value = _blogService.TGetByID(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateBlog(UpdateBlogDto updateBlogDto)
        {
            _blogService.TUpdate(new Blog()
            {
            BlogID=updateBlogDto.BlogID,
            BlogAuthor=updateBlogDto.BlogAuthor,
            BlogContent=updateBlogDto.BlogContent,
            BlogDate=updateBlogDto.BlogDate,
            BlogImageUrl= updateBlogDto.BlogImageUrl,
            BlogTitle = updateBlogDto.BlogTitle
            });
            return Ok("Blog Güncellendi");

        }
    }
}
