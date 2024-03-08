using Microsoft.EntityFrameworkCore;
using PrepaidMerchantAPI.DTOs;
using PrepaidMerchantAPI.Entities;
using PrepaidMerchantAPI.Repository.Interface;
using PrepaidMerchantAPI.Services.Interface;

namespace PrepaidMerchantAPI.Services.Implementation
{
    public class RequestManagementService : IRequestManagementService
    {
        private readonly IRequestManagemetRepo _repo;
        public RequestManagementService(IRequestManagemetRepo repo)
        {
            _repo = repo;
        }
        public Response CreateNewRequest(CreateRequestDto entity)
        {
            Response response = new Response();

            _repo.Create(entity);

            response.ResponseCode = "00";
            response.ResponseMessage = "Created Successfully";
            response.Data = null;

            return response;
        }
        public Response GetAllRequests(int page, int pagesize)
        {
            Response response = new Response();

            var result = _repo.GetAll(page, pagesize);

            response.ResponseCode = "00";
            response.ResponseMessage = "Successful";
            response.Data = result;

            return response;
        }
        public Response GetAllPendingRequests()
        {
            Response response = new Response();

            var result = _repo.GetAllPending();

            response.ResponseCode = "00";
            response.ResponseMessage = "Successful";
            response.Data = result;

            return response;
        }
        public Response GetAllInProgressRequests()
        {
            Response response = new Response();

            var result = _repo.GetAllInProgressRequests();

            response.ResponseCode = "00";
            response.ResponseMessage = "Successful";
            response.Data = result;

            return response;
        }
        public Response GetAllDeliveredRequests()
        {
            Response response = new Response();

            var result = _repo.GetAllDeliveredRequests();

            response.ResponseCode = "00";
            response.ResponseMessage = "Successful";
            response.Data = result;

            return response;
        }
        public Response GetAllReadyRequests()
        {
            Response response = new Response();

            var result = _repo.GetAllReadyRequests();

            response.ResponseCode = "00";
            response.ResponseMessage = "Successful";
            response.Data = result;

            return response;
        }
    }
}
