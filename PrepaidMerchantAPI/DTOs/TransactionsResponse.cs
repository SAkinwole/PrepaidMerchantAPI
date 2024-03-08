using PrepaidMerchantAPI.Entities;

namespace PrepaidMerchantAPI.DTOs
{
    public class TransactionsResponse
    {
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
        public int Pages { get; set; }
        public int CurrentPage { get; set; }
    }
}
