using Microsoft.EntityFrameworkCore;
using PrepaidMerchantAPI.Entities;
using PrepaidMerchantAPI.Repository.Interface;

namespace PrepaidMerchantAPI.Repository.Implementation
{
    public class CardRepo : ICardRepo
    {
        private readonly AppDbContext _context;
        public CardRepo(AppDbContext context)
        {
            _context = context;
        }

        public IList<Card> GetAllCards(long customerId)
        {
            return _context.Cards.Where(x => x.CustomerId == customerId).ToList();
        }
        public IList<Card> GetAllCards()
        {
            return _context.Cards.ToList();
        }
        public int GetActiveCardCount()
        {
            var result = _context.Cards.Where(x => x.CardStatus == CardStatus.Active);
            return result.Count();
        }
        public int GetInactiveCardCount()
        {
            var result = _context.Cards.Where(x => x.CardStatus == CardStatus.Inactive);
            return result.Count();
        }
        public int GetExpiredCardCount()
        {
            var result = _context.Cards.Where(x => x.CardStatus == CardStatus.Expired);
            return result.Count();
        }
    }
}
