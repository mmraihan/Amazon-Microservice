using Amazon.Services.CouponApi.Model;
using Amazon.Services.CouponApi.Model.Dto;
using AutoMapper;

namespace Amazon.Services.CouponApi
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps() 
        {
            var mappingCofig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>();
                config.CreateMap<Coupon, CouponDto>();
            });
            return mappingCofig;
        }
    }
}
