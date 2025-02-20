using AutoMapper;
using FoodyProject.DtoLayer.StaffDto;
using FoodyProject.EntityLayer.Entities;

namespace FoodyProject.WebApi.Mapping
{
    public class StaffMapping:Profile
    {
        public StaffMapping()
        {
            CreateMap<Staff,ResultStaffDto>().ReverseMap();
            CreateMap<Staff,CreateStaffDto>().ReverseMap();
            CreateMap<Staff,UpdateStaffDto>().ReverseMap();
            CreateMap<Staff,GetStaffDto>().ReverseMap();
        }
    }
}
