using PrepaidMerchantAPI.Entities;

namespace PrepaidMerchantAPI.Repository.Interface
{
    public interface ITransactionRepo
    {
        IList<Transaction> SearchTransaction(string searchTerm);
        IList<Transaction> GetAllTransactions();
        IList<Transaction> GetAllApprovedTransactions();
        IList<Transaction> GetAllFailedTransactions();
        Transaction FindTransactionByDate(DateTime startDate, DateTime endDate);
    }
}
