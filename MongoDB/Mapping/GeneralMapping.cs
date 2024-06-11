using AutoMapper;
using MongoDB.Dtos.CategoryDtos;
using MongoDB.Dtos.ProductDtos;
using MongoDB.Entities;

namespace MongoDB.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping() 
        {
            CreateMap<Category, ResultCategoryDto>().ReverseMap(); 
            CreateMap<Category, CreateCategoryDto>().ReverseMap(); 
            CreateMap<Category, UpdateCategoryDto>().ReverseMap(); 
            CreateMap<Category, GetByIdCategoryDto>().ReverseMap();
            
            CreateMap<Product,ResultProductDto>().ReverseMap();
            CreateMap<Product,UpdateProductDto>().ReverseMap();
            CreateMap<Product,CreateProductDto>().ReverseMap();
            CreateMap<Product,GetByIdProductDto>().ReverseMap();
        }
    }
}
