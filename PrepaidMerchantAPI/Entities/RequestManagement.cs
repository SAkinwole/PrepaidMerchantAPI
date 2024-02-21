namespace PrepaidMerchantAPI.Entities
{
    public class RequestManagement
    {
        public int Id { get; set; }
        public string BatchNumber { get; set; }
        public int Quantity { get; set; }
        public CardType Type { get; set; }
        public string CardScheme { get; set; }
        public Currency Currency { get; set; }
        public Status Status { get; set; }

        public RequestManagement()
        {
            BatchNumber = GenerateRandomBatchNumber();
        }

        private string GenerateRandomBatchNumber()
        {
            Random random = new Random();
            int randomNumber = random.Next(20000, 29999);
            return randomNumber.ToString();
        }
    }

    public enum CardType
    {
        Physical = 1,
        Virtual
    }
    public enum CardScheme
    {
        MasterCard = 1,
        Visa,
        Verve
    }
    public enum Currency
    {
        NGN = 1,
        USD
    }
    public enum Status
    {
        Pending = 1,
        InProgress,
        ReadyForDelivery,
        Delivered
    }


}
