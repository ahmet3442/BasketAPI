using Business.Abstract;
using Entity.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Consumes("application/json")]
    public class BasketController : ControllerBase
    {
        private readonly IBasketService _basketService;
        public BasketController(IBasketService basketService)
        {
            _basketService = basketService;
        }

        [HttpPost]
        [Route("UpdateBasket")]
        public async Task<ActionResult> UpdateBasket(UpdateBasketDto dto, CancellationToken cancellation)
        {
            var response = await _basketService.UpdateBasket(dto,cancellation);
            return Ok(new { response });
        }
        [HttpPost]
        [Route("ConfirmBasket")]
        public async Task<ActionResult> ConfirmBasket(CancellationToken cancellation)
        {
            var response = await _basketService.ConfirmBasket(cancellation);
            return Ok(new { response });
        }
        [HttpPost]
        [Route("CreateBasket")]
        public async Task<ActionResult> CreateBasket(CancellationToken cancellation)
        {
            var response = await _basketService.CreateBasket(cancellation);
            return Ok(new { response });
        }
        [HttpPost]
        [Route("DeleteBasket")]
        public async Task<ActionResult> DeleteBasket(CancellationToken cancellation)
        {
            var response = await _basketService.DeleteBasket(cancellation);
            return Ok(new { response });
        }
        [HttpGet]
        [Route("GetBasket")]
        public async Task<ActionResult> GetBasket(CancellationToken cancellation)
        {
            var response = await _basketService.GetBasket(cancellation);
            return Ok(new { response });
        }
    }
}
