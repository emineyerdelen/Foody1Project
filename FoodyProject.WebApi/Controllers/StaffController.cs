using AutoMapper;
using FoodyProject.BusinessLayer.Abstract;
using FoodyProject.DataAccessLayer.Abstract;
using FoodyProject.DtoLayer.StaffDto;
using FoodyProject.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;
        private readonly IMapper _mapper;

        public StaffController(IStaffService staffService, IMapper mapper)
        {
            _staffService = staffService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult StaffList()
        {
            var value = _mapper.Map<List<ResultStaffDto>>(_staffService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateStaff(CreateStaffDto createStaffDto)
        {
            _staffService.TAdd(new Staff()
            {
             Name=createStaffDto.Name,
             Title=createStaffDto.Title
            });
            return Ok("Hizmet Eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStaff(int id)
        {
            var value = _staffService.TGetByID(id);
            _staffService.TDelete(value);
            return Ok("Hizmet Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetStaff(int id)
        {
            var value = _staffService.TGetByID(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateStaff(UpdateStaffDto updateStaffDto)
        {
            _staffService.TUpdate(new Staff()
            {
               StaffID=updateStaffDto.StaffID,
               Name=updateStaffDto.Name,
               Title=updateStaffDto.Title
            });
            return Ok("Hizmet Güncellendi");

        }
    }
}
