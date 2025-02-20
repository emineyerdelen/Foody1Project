using AutoMapper;
using FoodyProject.DtoLayer.ContactDto;

namespace FoodyProject.WebApi.Mapping
{
    public class ContactMapping:Profile
    {
        public ContactMapping()
        {
            CreateMap<ContactMapping, ResultContactDto>().ReverseMap();
            CreateMap<ContactMapping, UpdateContactDto>().ReverseMap();
            CreateMap<ContactMapping, CreateContactDto>().ReverseMap();
            CreateMap<ContactMapping, GetContactDto>().ReverseMap();
        }
    }
}
