using ArkoMebel.Domain.Entites;
using ArkoMebel.Service.UseCases.Photos.Command;
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
        public async ValueTask<IActionResult> CreatePhotoAsync([FromForm]CreatePhotoCommand model)
        {
           
            await _mediatr.Send(model);
            return Ok("Yasaldi");
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetAllPhotoAsync()
        {
            var res = await _mediatr.Send(new GetAllPhotoQuery());
            return Ok(res);
        }
    }
}
