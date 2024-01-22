using ArkoMebel.Domain.Entites;
using ArkoMebel.Service.UseCases.Portfolios.Queries;
using ArkoMebel.Service.UseCases.ProductBoxes.Queries;
using ArkoMebel.WebAPI.ViewModel;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace ArkoMebel.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductBoxController : ControllerBase
    {
        private readonly IMediator _mediatr;
        private readonly IMemoryCache _memoryCache;

        public ProductBoxController(IMediator mediatr, IMemoryCache memoryCache)
        {
            _mediatr = mediatr;
            _memoryCache = memoryCache;
        }


        [HttpPost]
        public async ValueTask<IActionResult> CreateProductBoxAsync(ProductBoxDto model)
        {
            var res = await _mediatr.Send(new GetAllProductBoxQuery());
            return Ok(res);
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetAllProductBoxAsync()
        {
            var res = _memoryCache.Get("Id");
            if (res == null)
            {
                var portfolio = await _mediatr.Send(new GetAllProductBoxQuery());
                _memoryCache.Set(key: "Id", value: portfolio);
            }
            return Ok(_memoryCache.Get(key: "Id") as List<Portfolio>);
        }
    }
}
