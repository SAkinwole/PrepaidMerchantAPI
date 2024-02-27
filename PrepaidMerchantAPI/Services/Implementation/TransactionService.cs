using Microsoft.EntityFrameworkCore;
using PrepaidMerchantAPI.DTOs;
using PrepaidMerchantAPI.Entities;
using PrepaidMerchantAPI.Repository.Interface;
using PrepaidMerchantAPI.Services.Interface;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PrepaidMerchantAPI.Services.Implementation
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepo _repo;
        public TransactionService(ITransactionRepo repo)
        {
            _repo = repo;
        }

        public Response CreateNewTransaction(Transaction transaction)
        {
            Response response = new Response();

            response.ResponseCode = "00";
            response.ResponseMessage = "Transaction Created Successfully";
            response.Data = null;

            return response;
        }
        public Response FindTransactionByDate(DateTime startDate, DateTime endDate)
        {
            Response response = new Response();
            var transaction = _repo.FindTransactionByDate(startDate, endDate);

            response.ResponseCode = "00";
            response.ResponseMessage = "Successful";
            response.Data = transaction;

            return response;
        }
        public Response SearchTransaction(string searchTerm)
        {
            Response response = new Response();
            var transaction = _repo.SearchTransaction(searchTerm);


            response.ResponseCode = "00";
            response.ResponseMessage = "Successful";
            response.Data = transaction;

            return response;
        }
        public Response GetAllApprovedTransactions()
        {
            Response response = new Response();
            var transaction = _repo.GetAllApprovedTransactions();

            response.ResponseCode = "00";
            response.ResponseMessage = "Successful";
            response.Data = transaction;

            return response;
        }
        public Response GetAllFailedTransactions()
        {
            Response response = new Response();
            var transaction = _repo.GetAllFailedTransactions();

            response.ResponseCode = "00";
            response.ResponseMessage = "Successful";
            response.Data = transaction;

            return response;
        }
        public Response GetAllTransaction()
        {
            Response response = new Response();
            var transaction = _repo.GetAllTransactions();

            response.ResponseCode = "00";
            response.ResponseMessage = "Successful";
            response.Data = transaction;

            return response;
        }
    }
}
