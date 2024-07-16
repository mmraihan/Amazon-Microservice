using Amazon.Web.Models;

namespace Amazon.Web.Service.IService
{
    public interface IBaseService
    {
        Task <ResponseDto?> SendAsync(RequestDto requestDto); 
    }
}
