using ArkoMebel.Domain.Entites;
using ArkoMebel.Service.UseCases.Photos.Queries;
using ArkoMebel.WebAPI.ViewModel;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace ArkoMebel.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PhotoController : ControllerBase
    {
        private readonly IMemoryCache _memoryCache;
        private readonly IMediator _mediatr;

        public PhotoController(IMemoryCache memoryCache, IMediator mediator)
        {
            _memoryCache = memoryCache;
            _mediatr = mediator;
        }

        [HttpPost]
        public async ValueTask<IActionResult> CreatePhotoAsync(PhotoDto model)
        {
            var command = new Photo()
            {
                PhotoPath = model.PhotoPath,
                ProductId = model.ProductId,
            };
            await _mediatr.Send(command);
            return Ok("Yasaldi");
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetAllPhotoAsync()
        {
            var res = _memoryCache.Get("Id");
            if (res == null)
            {
                var photo = await _mediatr.Send(new GetAllPhotoQuery());
                _memoryCache.Set(key: "Id", value: photo);
            }
            return Ok(_memoryCache.Get(key: "Id") as List<Photo>);
        }
    }
}
