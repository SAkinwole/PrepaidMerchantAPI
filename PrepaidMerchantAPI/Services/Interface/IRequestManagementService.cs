using PrepaidMerchantAPI.DTOs;
using PrepaidMerchantAPI.Entities;

namespace PrepaidMerchantAPI.Services.Interface
{
    public interface IRequestManagementService
    {
        Response CreateNewRequest(CreateRequestDto entity);
        Response GetAllRequests();
        Response GetAllPendingRequests();
        Response GetAllInProgressRequests();
        Response GetAllDeliveredRequests();
        Response GetAllReadyRequests();

    }
}
