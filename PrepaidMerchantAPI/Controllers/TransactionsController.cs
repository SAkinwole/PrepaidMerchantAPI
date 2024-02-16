using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrepaidMerchantAPI.DTOs;
using PrepaidMerchantAPI.Entities;
using PrepaidMerchantAPI.Services;
using System.Web.Http.ModelBinding;

namespace PrepaidMerchantAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        private readonly ITransactionService _transectionService;
        public TransactionsController(ITransactionService transactionService)
        {
            _transectionService = transactionService;
        }

        //[HttpPost]
        //[Route("create-new-transaction")]
        //public IActionResult CreateNewTransaction([FromBody] CreateTransactionDto request)
        //{
        //    if (!ModelState.IsValid) return BadRequest(request);
        //    var transaction = new Transaction
        //    {
        //        TerminalId = request.
        //    }

        //    return Ok(_service.CreateNewTransaction(transaction));
        //}

        [HttpGet("get-alltransactions")]
        public IActionResult GetAllTransactions()
        {
            if (!ModelState.IsValid) return BadRequest();
            var transactions = _transectionService.GetAllTransaction();
            return Ok(transactions);
        }

        [HttpGet("get-allapprovedtransactions")]
        public IActionResult GetAllApprovedTransactions()
        {
            if (!ModelState.IsValid) return BadRequest();
            var transactions = _transectionService.GetAllApprovedTransactions();
            return Ok(transactions);
        }

        [HttpGet("get-allfailedtransactions")]
        public IActionResult GetAllFailedTransactions()
        {
            if (!ModelState.IsValid) return BadRequest();
            var transactions = _transectionService.GetAllFailedTransactions();
            return Ok(transactions);
        }
    }
}
