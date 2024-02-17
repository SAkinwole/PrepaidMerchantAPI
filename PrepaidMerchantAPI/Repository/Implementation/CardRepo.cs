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
    }
}
