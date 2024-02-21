using Microsoft.EntityFrameworkCore;
using PrepaidMerchantAPI.DTOs;
using PrepaidMerchantAPI.Entities;
using PrepaidMerchantAPI.Services.Interface;

namespace PrepaidMerchantAPI.Services.Implementation
{
    public class RequestManagementService : IRequestManagementService
    {
        private readonly AppDbContext _context;
        public RequestManagementService(AppDbContext context)
        {
            _context = context;
        }
        public Response CreateNewRequest(CreateRequestDto entity)
        {
            Response response = new Response();

            var res = _context.RequestManagements.Add(new RequestManagement
            {
                CardScheme = entity.CardScheme,
                Currency = entity.Currency,
                Quantity = entity.Quantity,
                Type = entity.Type,
                Status = Status.Pending
            });
            _context.SaveChanges();

            response.ResponseCode = "00";
            response.ResponseMessage = "Created Successfully";
            response.Data = res;

            return response;
        }
        public Response GetAllRequests()
        {
            Response response = new Response();

            var result = _context.RequestManagements.ToList();

            response.ResponseCode = "00";
            response.ResponseMessage = "Successful";
            response.Data = result;

            return response;
        }
        public Response GetAllPendingRequests()
        {
            Response response = new Response();

            var result = _context.RequestManagements.Where(x => x.Status == Status.Pending );

            response.ResponseCode = "00";
            response.ResponseMessage = "Successful";
            response.Data = result;

            return response;
        }
        public Response GetAllInProgressRequests()
        {
            Response response = new Response();

            var result = _context.RequestManagements.Where(x => x.Status == Status.InProgress);

            response.ResponseCode = "00";
            response.ResponseMessage = "Successful";
            response.Data = result;

            return response;
        }
        public Response GetAllDeliveredRequests()
        {
            Response response = new Response();

            var result = _context.RequestManagements.Where(x => x.Status == Status.Delivered);

            response.ResponseCode = "00";
            response.ResponseMessage = "Successful";
            response.Data = result;

            return response;
        }
        public Response GetAllReadyRequests()
        {
            Response response = new Response();

            var result = _context.RequestManagements.Where(x => x.Status == Status.ReadyForDelivery);

            response.ResponseCode = "00";
            response.ResponseMessage = "Successful";
            response.Data = result;

            return response;
        }
    }
}
