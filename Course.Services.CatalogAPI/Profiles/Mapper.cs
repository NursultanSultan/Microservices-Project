using AutoMapper;
using CourseApp.Services.CatalogAPI.Dtos;
using CourseApp.Services.CatalogAPI.Entities;

namespace CourseApp.Services.CatalogAPI.Profiles
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Course, CourseCreateDto>().ReverseMap();
            CreateMap<Course, CourseUpdateDto>().ReverseMap();


            CreateMap<Category, CategoryCreateDto>().ReverseMap();
            CreateMap<Category, CategoryUpdateDto>().ReverseMap();


        }
    }
}
