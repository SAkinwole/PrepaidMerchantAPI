using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrepaidMerchantAPI.Services.Interface;

namespace PrepaidMerchantAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardsController : ControllerBase
    {
        private readonly ICardService _CardService;
        public CardsController(ICardService cardService)
        {
            _CardService = cardService;
        }

        [HttpGet]
        public IActionResult GetCards(long customerId)
        {
            var result = _CardService.GetAllCards(customerId);
            return Ok(result);
        }
    }
}
