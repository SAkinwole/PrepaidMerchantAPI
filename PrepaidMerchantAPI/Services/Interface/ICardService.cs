using PrepaidMerchantAPI.Entities;

namespace PrepaidMerchantAPI.Services.Interface
{
    public interface ICardService
    {
        Response GetAllCards(long cusId);
        Response GetCardDashboardCount();
    }
}
