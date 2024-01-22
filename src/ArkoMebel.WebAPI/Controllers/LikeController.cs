using ArkoMebel.Domain.Entites;
using ArkoMebel.Service.UseCases.Like.Queries;
using ArkoMebel.WebAPI.ViewModel;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace ArkoMebel.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LikeController : ControllerBase
    {
        private readonly IMemoryCache _memoryCache;
        private readonly IMediator _mediatr;


        public LikeController(IMemoryCache memoryCache, IMediator mediator)
        {
            _memoryCache = memoryCache;
            _mediatr = mediator;
        }

        [HttpPut]
        public async ValueTask<IActionResult> CreateLikeAsync(LikeDto model)
        {
            var command = new Likes()
            {
                UserId = model.UserId,
                ProductId = model.ProductId,
            };
            await _mediatr.Send(command);
            return Ok("Yasaldi");
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetAllLikes()
        {
            var res =await _mediatr.Send(new GetAllLikeQuery());
            return Ok(res);
           
        }
    }
}
