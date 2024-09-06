using AutoMapper;
using RestaurantApp.DtoLayer.CategoryDto;
using RestaurantApp.EntityLayer.Entities;

namespace RestaurantAppApi.Mapping
{
    public class CategoryMapping:Profile
    {
        public CategoryMapping()
        {
            CreateMap<Category,ResultCategoryDto>().ReverseMap();
            CreateMap<Category,CreateCategoryDto>().ReverseMap();
            CreateMap<Category,GetCategoryDto>().ReverseMap();
            CreateMap<Category,UpdateCategoryDto>().ReverseMap();
        }
    }
}
