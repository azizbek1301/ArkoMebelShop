using ArkoMebel.Domain.Entites;
using ArkoMebel.Service.UseCases.Productes.Command;
using ArkoMebel.Service.UseCases.Productes.Queries;
using ArkoMebel.WebAPI.ViewModel;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace ArkoMebel.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediatr;
        private readonly IMemoryCache _memoryCache;

        public ProductController(IMediator mediatr,IMemoryCache memoryCache)
        {
            _mediatr = mediatr;
            _memoryCache = memoryCache;
            
        }

        [HttpPost]
        public async ValueTask<IActionResult> CreateProductAsync(ProductDto model)
        {
            var command = new CreateProductCommand
            {
                Name = model.Name,
                Description = model.Description,
                Price = model.Price,
                Color = model.Color,
                CategoryId = model.CategoryId,
            };

            await _mediatr.Send(command);
            
            return Ok("Yasaldi");
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetAllProductAsync()
        {
            var res = await _mediatr.Send(new GetAllProductQuery());
            return Ok(res);
        }
    }
}
