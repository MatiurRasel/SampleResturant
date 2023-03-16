using AutoMapper;
using Mango.Services.ProductAPI.Models;
using Mango.Services.ProductAPI.Models.Dtos;

namespace Mango.Services.ProductAPI.Mapping
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingconfig = new MapperConfiguration(configure =>
            {
                configure.CreateMap<ProductDTO, Product>();
                //configure.CreateMap<ProductDTO, Product>().ReverseMap();
                configure.CreateMap<Product, ProductDTO>();
            });
            return mappingconfig;
        }
    }
}
