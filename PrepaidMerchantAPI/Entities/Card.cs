namespace PrepaidMerchantAPI.Entities
{
    public class Card
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Balance { get; set; }
        public string CardNumber { get; set; }
        public string AccountNumber { get; set; }
        public string Expiry { get; set; }
        public long CustomerId { get; set; }
    }
}
