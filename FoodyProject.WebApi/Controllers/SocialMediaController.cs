﻿using AutoMapper;
using FoodyProject.BusinessLayer.Abstract;
using FoodyProject.DtoLayer.SocialMediaDto;
using FoodyProject.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController : ControllerBase
    {
        private readonly ISocialMediaService _socialMediaService;
        private readonly IMapper _mapper;

        public SocialMediaController(ISocialMediaService socialMediaService, IMapper mapper)
        {
            _socialMediaService = socialMediaService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult SocialMediaList()
        {
            var value = _mapper.Map<List<ResultSocialMediaDto>>(_socialMediaService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateSocialMedia(CreateSocialMediaDto createSocialMediaDto)
        {
            _socialMediaService.TAdd(new SocialMedia()
            {
              Title=createSocialMediaDto.Title,
              Url=createSocialMediaDto.Url,
              İcon=createSocialMediaDto.İcon
            });
            return Ok("Sosyal Medya Eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSocialMedia(int id)
        {
            var value = _socialMediaService.TGetByID(id);
            _socialMediaService.TDelete(value);
            return Ok("Sosyal Medya Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetSocialMedia(int id)
        {
            var value = _socialMediaService.TGetByID(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateSocialMedia(UpdateSocialMediaDto updateSocialMediaDto)
        {
            _socialMediaService.TUpdate(new SocialMedia()
            {
              SocialMediaID=updateSocialMediaDto.SocialMediaID,
              Title=updateSocialMediaDto.Title,
              Url=updateSocialMediaDto.Url,
              İcon=updateSocialMediaDto.İcon
            });
            return Ok("Sosyal Medya Güncellendi");

        }
    }
}
