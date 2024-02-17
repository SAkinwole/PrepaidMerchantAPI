using PrepaidMerchantAPI.Entities;

namespace PrepaidMerchantAPI.Repository.Interface
{
    public interface ICardRepo
    {
        IList<Card> GetAllCards(long customerId);
    }
}
