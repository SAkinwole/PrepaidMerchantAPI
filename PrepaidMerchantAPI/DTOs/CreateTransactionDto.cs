using PrepaidMerchantAPI.Entities;

namespace PrepaidMerchantAPI.DTOs
{
    public class CreateTransactionDto
    {
        public TranType TransactionType { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal TransactionAmount { get; set; }
    }
}
