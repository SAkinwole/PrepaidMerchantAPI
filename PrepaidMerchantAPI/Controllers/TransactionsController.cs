using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrepaidMerchantAPI.DTOs;
using PrepaidMerchantAPI.Entities;
using PrepaidMerchantAPI.Services.Interface;
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

        [HttpGet("search-transanctions")]
        public IActionResult SearchTransactions(string searchString)
        {
            if (!ModelState.IsValid) return BadRequest();
            var transactions = _transectionService.SearchTransaction(searchString);
            return Ok(transactions);
        }

        [HttpGet("filter-transanction-by-date")]
        public IActionResult FilterTransactions(DateTime startDate, DateTime endDate)
        {
            if (!ModelState.IsValid) return BadRequest();
            var transactions = _transectionService.FindTransactionByDate(startDate, endDate);
            return Ok(transactions);
        }
    }
}
