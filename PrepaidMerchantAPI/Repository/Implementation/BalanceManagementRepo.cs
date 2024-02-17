using PrepaidMerchantAPI.Entities;
using PrepaidMerchantAPI.Repository.Interface;

namespace PrepaidMerchantAPI.Repository.Implementation
{
    public class BalanceManagementRepo : IBalanceManagementRepo
    {
        private readonly AppDbContext _context;
        public BalanceManagementRepo(AppDbContext context)
        {
            _context = context;
        }
        public BalanceManagement GetBalanceManagement(long cusId)
        {
            var result = _context.BalanceManagements.Where(x => x.CustomerId == cusId).FirstOrDefault();
            return result;
        }
        public IList<BalanceManagement> GetAllBalanceHistory(DateTime startDate, DateTime endDate)
        {
            var result = _context.BalanceManagements.Where(x =>x.Date >= startDate && x.Date <= endDate).ToList();
            return result;
        }
    }
}
