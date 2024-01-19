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
            var res = _memoryCache.Get("Id");
            if (res == null)
            {
                var order = await _mediatr.Send(new GetAllOrderQuery());
                _memoryCache.Set(key: "Id", value: order);
            }
            return Ok(_memoryCache.Get(key: "Id") as List<Order>);
        }
    }
}
