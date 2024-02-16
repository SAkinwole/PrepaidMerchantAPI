using PrepaidMerchantAPI.DTOs;
using PrepaidMerchantAPI.Entities;

namespace PrepaidMerchantAPI.Services
{
    public interface ITransactionService
    {
        Response GetAllTransaction();
        Response CreateNewTransaction(Transaction transaction);
        Response FindTransactionByDate(DateTime date);
        Response GetAllApprovedTransactions();
        Response GetAllFailedTransactions();

    }
}
