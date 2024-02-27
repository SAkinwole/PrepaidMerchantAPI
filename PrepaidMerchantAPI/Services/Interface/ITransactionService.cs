using PrepaidMerchantAPI.DTOs;
using PrepaidMerchantAPI.Entities;

namespace PrepaidMerchantAPI.Services.Interface
{
    public interface ITransactionService
    {
        Response GetAllTransaction();
        Response CreateNewTransaction(Transaction transaction);
        Response SearchTransaction(string searchTerm);
        Response FindTransactionByDate(DateTime startDate, DateTime endDate);
        Response GetAllApprovedTransactions();
        Response GetAllFailedTransactions();

    }
}
