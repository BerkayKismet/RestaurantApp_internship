using AutoMapper;
using RestaurantApp.DtoLayer.FeatureDto;
using RestaurantApp.EntityLayer.Entities;

namespace RestaurantAppApi.Mapping
{
    public class FeatureMapping:Profile
    {
        public FeatureMapping()
        {
            CreateMap<Feature,ResultFeatureDto>().ReverseMap();
            CreateMap<Feature,CreateFeatureDto>().ReverseMap();
            CreateMap<Feature,UpdateFeatureDto>().ReverseMap();
            CreateMap<Feature,GetFeatureDto>().ReverseMap();
        }
    }
}
