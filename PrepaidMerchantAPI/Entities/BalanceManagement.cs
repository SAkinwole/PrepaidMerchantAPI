namespace PrepaidMerchantAPI.Entities
{
    public class BalanceManagement
    {
        public long Id { get; set; }
        public string Balance { get; set; }
        public string ReferenceNumber { get; set; }
        public string AccountName { get; set; }
        public decimal Amount { get; set; }
        public string Recipient { get; set; }
        public string AccountNumber { get; set; }
        public string Narration { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public Trantype Type { get; set; }
        public string Bank { get; set; }
        public long CustomerId { get; set; }

        public enum Trantype
        {
            Out = 1,
            In
        }
    }

}
