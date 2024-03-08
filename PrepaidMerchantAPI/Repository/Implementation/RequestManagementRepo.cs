using PrepaidMerchantAPI.DTOs;
using PrepaidMerchantAPI.Entities;
using PrepaidMerchantAPI.Repository.Interface;

namespace PrepaidMerchantAPI.Repository.Implementation
{
    public class RequestManagementRepo : IRequestManagemetRepo
    {
        private readonly AppDbContext _context;
        public RequestManagementRepo(AppDbContext context)
        {
            _context = context;
        }
        public void Create(CreateRequestDto entity)
        {
            _context.RequestManagements.Add(new RequestManagement
            {
                CardScheme = entity.CardScheme,
                Currency = entity.Currency,
                Quantity = entity.Quantity,
                Type = entity.Type,
                Status = Status.Pending

            });
            _context.SaveChanges();
        }
        public RequestManagementResponse GetAll(int page, int pageSize)
        {
            var totalCount = _context.RequestManagements.Count();
            var pageCount = (int)Math.Ceiling((double)totalCount / pageSize);

            var result = _context.RequestManagements
                                .OrderBy(t => t.Id)
                                .Skip((page - 1) * pageSize)
                                .Take(pageSize)
                                .ToList();
            var response = new RequestManagementResponse
            {
                Transactions = result,
                Pages = (int)pageCount,
                CurrentPage = page
            };
            return response;
        }
        public IList<RequestManagement> GetAllPending()
        {
            var result = _context.RequestManagements.Where(x => x.Status == Status.Pending).ToList();
            return result;
        }
        public IList<RequestManagement> GetAllInProgressRequests()
        {
            var result = _context.RequestManagements.Where(x => x.Status == Status.InProgress).ToList();
            return result;
        }
        public IList<RequestManagement> GetAllDeliveredRequests()
        {
            var result = _context.RequestManagements.Where(x => x.Status == Status.Delivered).ToList();
            return result;
        }
        public IList<RequestManagement> GetAllReadyRequests()
        {
            var result = _context.RequestManagements.Where(x => x.Status == Status.ReadyForDelivery).ToList();
            return result;
        }

    }
}
