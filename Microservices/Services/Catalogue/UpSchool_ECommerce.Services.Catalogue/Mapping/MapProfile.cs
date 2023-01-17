using AutoMapper;
using System;
using UpSchool_ECommerce.Services.Catalogue.Dtos;
using UpSchool_ECommerce.Services.Catalogue.Models;

namespace UpSchool_ECommerce.Services.Catalogue.Mapping
{
    public class MapProfile : Profile
    {
        protected MapProfile()
        {
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();

            // veya .ReverseMap(); tersini de dahil ediyor

            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();

        }

        protected internal MapProfile(string profileName) : base(profileName)
        {
        }

        protected internal MapProfile(string profileName, Action<IProfileExpression> configurationAction) : base(profileName, configurationAction)
        {
        }
    }
}
