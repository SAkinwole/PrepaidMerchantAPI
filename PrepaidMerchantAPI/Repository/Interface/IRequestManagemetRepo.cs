using PrepaidMerchantAPI.DTOs;
using PrepaidMerchantAPI.Entities;

namespace PrepaidMerchantAPI.Repository.Interface
{
    public interface IRequestManagemetRepo
    {
        void Create(CreateRequestDto entity);
        //IList<RequestManagement> GetAll();
        RequestManagementResponse GetAll(int page, int pageSize);
        IList<RequestManagement> GetAllReadyRequests();
        IList<RequestManagement> GetAllPending();
        IList<RequestManagement> GetAllInProgressRequests();
        IList<RequestManagement> GetAllDeliveredRequests();
    }
}
