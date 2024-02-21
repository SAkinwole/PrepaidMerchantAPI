using PrepaidMerchantAPI.Entities;
using PrepaidMerchantAPI.Repository.Interface;
using PrepaidMerchantAPI.Services.Interface;

namespace PrepaidMerchantAPI.Services.Implementation
{
    public class CardService : ICardService
    {
        private readonly ICardRepo _cardRepo;
        public CardService(ICardRepo cardRepo, AppDbContext context)
        {
            _cardRepo = cardRepo;
        }

        public Response GetAllCards(long cusId)
        {
            Response response = new Response();
            var cards = _cardRepo.GetAllCards(cusId);

            response.Data = cards;
            response.ResponseCode = "00";
            response.ResponseMessage = "List of Customer Cards returned successfully";

            return response;
        }

       // public Response 
    }

}
