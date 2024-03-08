using PrepaidMerchantAPI.DTOs;
using PrepaidMerchantAPI.Entities;

namespace PrepaidMerchantAPI.Services.Interface
{
    public interface IRequestManagementService
    {
        Response CreateNewRequest(CreateRequestDto entity);
        //Response GetAllRequests();
        Response GetAllRequests(int page, int pagesize);
        Response GetAllPendingRequests();
        Response GetAllInProgressRequests();
        Response GetAllDeliveredRequests();
        Response GetAllReadyRequests();

    }
}
