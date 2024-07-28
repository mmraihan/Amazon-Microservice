using Amazon.Services.ProductAPI.Dtos;
using Amazon.Services.ProductAPI.Models;
using AutoMapper;

namespace Amazon.Services.ProductAPI.Helpers
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>();
                config.CreateMap<Product, ProductDto>();
            });
            return mappingConfig;
        }
    }
}
