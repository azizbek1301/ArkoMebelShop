using ArkoMebel.Domain.Entites;
using ArkoMebel.Service.UseCases.Portfolios.Queries;
using ArkoMebel.WebAPI.ViewModel;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace ArkoMebel.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ParfolioController : ControllerBase
    {
        private readonly IMediator _mediatr;
        private readonly IMemoryCache _memoryCache;

        public ParfolioController(IMediator mediatr, IMemoryCache memoryCache)
        {
            _mediatr = mediatr;
            _memoryCache = memoryCache;
        }


        [HttpPost]
        public async ValueTask<IActionResult> CreatePartfolioAsync(PartfolioDto model)
        {
            var command = new Portfolio()
            {
                PhotoPath = model.PhotoPath,
                CategoryId = model.CategoryId,
            };
            await _mediatr.Send(command);
            return Ok("Yasaldi");
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetAllPartfolioAsync()
        {
            var res = _memoryCache.Get("Id");
            if (res == null)
            {
                var portfolio = await _mediatr.Send(new GetAllPortfolioQuery());
                _memoryCache.Set(key: "Id", value: portfolio);
            }
            return Ok(_memoryCache.Get(key: "Id") as List<Portfolio>);
        }
    }
}
