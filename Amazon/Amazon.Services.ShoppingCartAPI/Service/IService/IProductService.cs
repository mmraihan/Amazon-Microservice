using Amazon.Services.ShoppingCartAPI.Dtos;

namespace Amazon.Services.ShoppingCartAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
