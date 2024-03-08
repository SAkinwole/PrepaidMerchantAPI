using PrepaidMerchantAPI.DTOs;
using PrepaidMerchantAPI.Entities;

namespace PrepaidMerchantAPI.Repository.Interface
{
    public interface ITransactionRepo
    {
        IList<Transaction> SearchTransaction(string searchTerm);
        //IList<Transaction> GetAllTransactions();
        TransactionsResponse GetAllTransactions(int page, int pageSize);
        //TransactionsResponse GetAllTransactions(int page);
        IList<Transaction> GetAllApprovedTransactions();
        IList<Transaction> GetAllFailedTransactions();
        Transaction FindTransactionByDate(DateTime startDate, DateTime endDate);
    }
}
