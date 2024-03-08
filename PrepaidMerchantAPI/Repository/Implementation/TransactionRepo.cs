using PrepaidMerchantAPI.DTOs;
using PrepaidMerchantAPI.Entities;
using PrepaidMerchantAPI.Repository.Interface;

namespace PrepaidMerchantAPI.Repository.Implementation
{
    public class TransactionRepo : ITransactionRepo
    {
        private readonly AppDbContext _context;
        public TransactionRepo(AppDbContext context)
        {
            _context = context;
        }

        public IList<Transaction> SearchTransaction(string searchTerm)
        {
            var transaction = _context.Transactions.Where(x => x.CardNumber.Contains(searchTerm) || x.MerchantInfo.Contains(searchTerm)
                                                || x.TerminalId.Contains(searchTerm) || x.TransactionAmount.Contains(searchTerm)).ToList();
            return transaction;
        }
        public TransactionsResponse GetAllTransactions(int page, int pageSize)
        {
            //var pageSize = 10;
            var totalCount = _context.Transactions.Count();
            var pageCount = (int)Math.Ceiling((double)totalCount / pageSize);

            var result = _context.Transactions
                                .OrderBy(t => t.Id) 
                                .Skip((page - 1) * pageSize)
                                .Take(pageSize)
                                .ToList();
            var response = new TransactionsResponse
            {
                Transactions = result,
                Pages = (int)pageCount,
                CurrentPage = page
            };
            return response;
        }
        public IList<Transaction> GetAllApprovedTransactions()
        {
            var transaction = _context.Transactions.Where(x => x.TransactionStatus == TranStatus.Approved).ToList();
            return transaction;
        }
        public IList<Transaction> GetAllFailedTransactions()
        {
            var transaction = _context.Transactions.Where(x => x.TransactionStatus == TranStatus.Failed).ToList();
            return transaction;
        }
        public Transaction FindTransactionByDate(DateTime startDate, DateTime endDate)
        {
            var result = _context.Transactions.Where(x => x.TransactionDate >= startDate && x.TransactionDate <= endDate).FirstOrDefault();
            return result;
        }
    }
}
