using ArkoMebel.Domain.Entites;
using ArkoMebel.Service.UseCases.Portfolios.Command;
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
        public async ValueTask<IActionResult> CreatePartfolioAsync([FromForm]CreatePortfolioCommand model)
        {
            
            await _mediatr.Send(model);
            return Ok("Yasaldi");
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetAllPartfolioAsync()
        {
            var res = await _mediatr.Send(new GetAllPortfolioQuery());
            return Ok(res);
        }
    }
}
