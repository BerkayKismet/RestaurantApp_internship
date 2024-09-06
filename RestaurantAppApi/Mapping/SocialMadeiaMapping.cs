using AutoMapper;
using RestaurantApp.DtoLayer.SocialMediaDto;
using RestaurantApp.EntityLayer.Entities;

namespace RestaurantAppApi.Mapping
{
    public class SocialMadeiaMapping:Profile
    {
        public SocialMadeiaMapping()
        {
            CreateMap<SocialMedia,CreateSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia,UpdateSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia,GetSocialMediaDto>().ReverseMap();
            CreateMap<SocialMedia, ResultSocialMediaDto>().ReverseMap();

        }
    }
}
