using AutoMapper;
using RestaurantApp.DtoLayer.ContactDto;
using RestaurantApp.EntityLayer.Entities;

namespace RestaurantAppApi.Mapping
{
    public class ContactMapping:Profile
    {
        public ContactMapping()
        {
            CreateMap<Contact,ResultContactDto>().ReverseMap();
            CreateMap<Contact,CreateContactDto>().ReverseMap();
            CreateMap<Contact,UpdateContactDto>().ReverseMap();
            CreateMap<Contact,GetContactDto>().ReverseMap();
        }
    }
}
