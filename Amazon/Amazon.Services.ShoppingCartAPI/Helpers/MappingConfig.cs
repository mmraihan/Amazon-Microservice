using Amazon.Services.ShoppingCartAPI.Dtos;
using Amazon.Services.ShoppingCartAPI.Models;
using AutoMapper;

namespace Amazon.Services.ShoppingCartAPI.Helpers
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CartHeader, CartHeaderDto>().ReverseMap();
                config.CreateMap<CartDetails, CartDetailsDto>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
