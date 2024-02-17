using PrepaidMerchantAPI.Entities;
using PrepaidMerchantAPI.Repository.Interface;
using PrepaidMerchantAPI.Services.Interface;

namespace PrepaidMerchantAPI.Services.Implementation
{
    public class BalanceManagementService : IBalanceManagementService
    {
        private readonly IBalanceManagementRepo _balanceManagementRepo;
        public BalanceManagementService(IBalanceManagementRepo balanceManagementRepo)
        {
            _balanceManagementRepo = balanceManagementRepo;
        }

        public Response GetBalance(long cusId)
        {
            Response response = new Response();

            var result = _balanceManagementRepo.GetBalanceManagement(cusId);

            response.ResponseMessage = "successful";
            response.Data = result;
            response.ResponseCode = "00";

            return response;
        }
        public Response FilterBalanceByDate(DateTime startDate, DateTime endDate)
        {
            Response response = new Response();
            var result = _balanceManagementRepo.GetAllBalanceHistory(startDate, endDate);

            response.Data = result;
            response.ResponseMessage = "Successful";
            response.ResponseCode = "00";

            return response;
        
        
        }
    }
}
