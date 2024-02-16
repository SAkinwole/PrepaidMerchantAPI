using Microsoft.EntityFrameworkCore;
using PrepaidMerchantAPI.DTOs;
using PrepaidMerchantAPI.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PrepaidMerchantAPI.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly AppDbContext _context;
        public TransactionService(AppDbContext context)
        {
            _context = context;
        }

        public Response CreateNewTransaction(Transaction transaction)
        {
            Response response = new Response();

            _context.Transactions.Add(transaction);
            _context.SaveChanges();

            response.ResponseCode = "00";
            response.ResponseMessage = "Transaction Created Successfully";
            response.Data = null;

            return response;
        }
        public Response FindTransactionByDate(DateTime date)
        {
            Response response = new Response();
            var transaction = _context.Transactions.Where(x => x.TransactionDate == date).ToList();

            response.ResponseCode = "00";
            response.ResponseMessage = "Successful";
            response.Data = transaction;

            return response;
        }
        public Response GetAllApprovedTransactions()
        {
            Response response = new Response();
            var transaction = _context.Transactions.Where(x => x.TransactionStatus == TranStatus.Approved).ToList();

            response.ResponseCode = "00";
            response.ResponseMessage = "Successful";
            response.Data = transaction;

            return response;
        }
        public Response GetAllFailedTransactions()
        {
            Response response = new Response();
            var transaction = _context.Transactions.Where(x => x.TransactionStatus == TranStatus.Failed).ToList();

            response.ResponseCode = "00";
            response.ResponseMessage = "Successful";
            response.Data = transaction;

            return response;
        }
        public Response GetAllTransaction()
        {
            Response response = new Response();
            var transaction = _context.Transactions.ToList();

            response.ResponseCode = "00";
            response.ResponseMessage = "Successful";
            response.Data = transaction;

            return response;
        }
    }
}
