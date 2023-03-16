using Mango.Web.Models;

namespace Mango.Web.Services.IServices
{
    public interface IBaseService :IDisposable
    {
        ResponseDTO responseModel { get; set; }
        Task<T> SendASync<T>(APIRequest apiRequest);

    }
}
