using PrepaidMerchantAPI.Entities;

namespace PrepaidMerchantAPI.DTOs
{
    public class CreateRequestDto
    {
        public int Quantity { get; set; }
        public CardType Type { get; set; }
        public string CardScheme { get; set; }
        public Currency Currency { get; set; }
    }
}
