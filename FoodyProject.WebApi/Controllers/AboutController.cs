using FoodyProject.BusinessLayer.Abstract;
using FoodyProject.DtoLayer.AboutDto;
using FoodyProject.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace FoodyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }
        [HttpGet]
        public IActionResult AboutList()
        {
            var value = _aboutService.TGetListAll();
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateAbout(CreateAboutDto createAboutDto)
        {
            About about = new About()
            {
                Title = createAboutDto.Title,
                Description = createAboutDto.Description,
                ImageUrl = createAboutDto.ImageUrl,
            };
            _aboutService.TAdd(about);
            return Ok("Hakkımda Kısmı başarılı bir şekilde eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteAbout(int id)
        {
            var value = _aboutService.TGetByID(id);
            _aboutService.TDelete(value);
            return Ok("Hakkımda alanı silindi");
        }


        [HttpPut]
        public IActionResult UpdateAbout(UpdateAboutDto updateAboutDto)
        {
            About about = new About()
            {
                AboutID = updateAboutDto.AboutID,
                Title = updateAboutDto.Title,
                Description = updateAboutDto.Description,
                ImageUrl = updateAboutDto.ImageUrl,
            };
            _aboutService.TUpdate(about);
            return Ok("Hakkımda Alanı Güncellendi");
        }

        [HttpGet("GetAbout")]
       public IActionResult GetAbout(int id)
        {
            var value=_aboutService.TGetByID(id);
            return Ok(value);
        }
        
    }
}