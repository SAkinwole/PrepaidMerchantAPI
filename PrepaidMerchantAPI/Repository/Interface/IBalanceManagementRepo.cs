using PrepaidMerchantAPI.Entities;

namespace PrepaidMerchantAPI.Repository.Interface
{
    public interface IBalanceManagementRepo
    {
        BalanceManagement GetBalanceManagement(long cusId);
        IList<BalanceManagement> GetAllBalanceHistory(DateTime startDate, DateTime endDate);
    }
}
