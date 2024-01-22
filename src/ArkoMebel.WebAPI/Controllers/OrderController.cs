using ArkoMebel.Domain.Entites;
using ArkoMebel.Service.UseCases.Orders.Queries;
using ArkoMebel.WebAPI.ViewModel;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace ArkoMebel.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMemoryCache _memoryCache;
        private readonly IMediator _mediatr;

        public OrderController(IMemoryCache memoruCache, IMediator mediatr)
        {
            _memoryCache = memoruCache;
            _mediatr = mediatr;
        }

        [HttpPut]
        public async ValueTask<IActionResult> CreateOrderAsync(OrderDto model)
        {
            var command = new Order()
            {
                AddressId = model.AddressId,
                BoxId = model.BoxId,
            };

            await _mediatr.Send(command);
            return Ok("Yasaldi");
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetAllOrderResult()
        {
            var res = await _mediatr.Send(new GetAllOrderQuery());
            return Ok(res);
        }
    }
}
