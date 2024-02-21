using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrepaidMerchantAPI.DTOs;
using PrepaidMerchantAPI.Services.Interface;

namespace PrepaidMerchantAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestManagementsController : ControllerBase
    {
        private readonly IRequestManagementService _service;
        public RequestManagementsController(IRequestManagementService service)
        {
            _service = service;
        }

        [HttpPost("CreateNewRequest")]
        public IActionResult Create(CreateRequestDto entity)
        {
            if (!ModelState.IsValid) return BadRequest();
            var result = _service.CreateNewRequest(entity);
            return Ok(result);
        }

        [HttpGet("get-allrequests")]
        public IActionResult GetAll()
        {
            if (!ModelState.IsValid) return BadRequest();
            var result = _service.GetAllRequests();
            return Ok(result);
        }
        [HttpGet("get-allpendingrequests")]
        public IActionResult GetAllPendingRequests()
        {
            if (!ModelState.IsValid) return BadRequest();
            var result = _service.GetAllPendingRequests();
            return Ok(result);
        }
        [HttpGet("get-allinprogressrequests")]
        public IActionResult GetAllInProgressRequests()
        {
            if (!ModelState.IsValid) return BadRequest();
            var result = _service.GetAllInProgressRequests();
            return Ok(result);
        }
        [HttpGet("get-allreadyrequests")]
        public IActionResult GetAllReadyRequests()
        {
            if (!ModelState.IsValid) return BadRequest();
            var result = _service.GetAllReadyRequests();
            return Ok(result);
        }
        [HttpGet("get-alldeliveredrequests")]
        public IActionResult GetAllDeliveredRequests()
        {
            if (!ModelState.IsValid) return BadRequest();
            var result = _service.GetAllDeliveredRequests();
            return Ok(result);
        }
    }
}
