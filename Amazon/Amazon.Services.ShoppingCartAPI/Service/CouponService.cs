using Amazon.Services.ShoppingCartAPI.Dtos;
using Amazon.Services.ShoppingCartAPI.Service.IService;

namespace Amazon.Services.ShoppingCartAPI.Service
{
    public class CouponService : ICouponService
    {
        public Task<CouponDto> GetCoupon(string couponCode)
        {
            throw new NotImplementedException();
        }
    }
}
