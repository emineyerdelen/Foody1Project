﻿using AutoMapper;
using FoodyProject.BusinessLayer.Abstract;
using FoodyProject.DataAccessLayer.Abstract;
using FoodyProject.DtoLayer.TestimonialDto;
using FoodyProject.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;
        private readonly IMapper _mapper;

        public TestimonialController(ITestimonialService testimonialService, IMapper mapper)
        {
            _testimonialService = testimonialService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult TestimonialList()
        {
            var value = _mapper.Map<List<ResultTestimonialDto>>(_testimonialService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateTestimonial(CreateTestimonialDto createTestimonialDto)
        {
            _testimonialService.TAdd(new Testimonial()
            {
                Comment=createTestimonialDto.Comment,
                ImageUrl=createTestimonialDto.ImageUrl,
                Name=createTestimonialDto.Name,
                TestimonialStatus=createTestimonialDto.TestimonialStatus,
                Title=createTestimonialDto.Title
            });
            return Ok("Referans Eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTestimonial(int id)
        {
            var value = _testimonialService.TGetByID(id);
            _testimonialService.TDelete(value);
            return Ok("Referans Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetTestimonial(int id)
        {
            var value = _testimonialService.TGetByID(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            _testimonialService.TUpdate(new Testimonial()
            {
               TestimonialID=updateTestimonialDto.TestimonialID,
               Comment=updateTestimonialDto.Comment,
               ImageUrl=updateTestimonialDto.ImageUrl,
               Name= updateTestimonialDto.Name,
               Title= updateTestimonialDto.Title,
               TestimonialStatus = updateTestimonialDto.TestimonialStatus
            });
            return Ok("Referans Güncellendi");

        }
    }
}
