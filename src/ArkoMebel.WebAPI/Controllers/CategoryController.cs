using ArkoMebel.Domain.Entites;
using ArkoMebel.Service.UseCases.Categories.Command;
using ArkoMebel.Service.UseCases.Categories.Queries;
using ArkoMebel.WebAPI.ViewModel;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace ArkoMebel.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediatr;

        private readonly IMemoryCache _memoryCache;

        public CategoryController(IMediator mediatr, IMemoryCache memoryCache)
        {
            _mediatr = mediatr;
            _memoryCache = memoryCache;
        }
        [HttpPost]
        public async ValueTask<IActionResult> CreateCategoryAsync(CategoryDto model)
        {
            var command = new CreateCategoryCommand()
            {
                Name = model.Name,
                PhotoPath = model.PhotoPath,
            };

            await _mediatr.Send(command);
            return Ok("Yasaldi");

        }
        [HttpGet]
        public async ValueTask<IActionResult> GetAllCategoryAsync()
        {
            var value = _memoryCache.Get("Id");
            if(value == null)
            {
                var category = await _mediatr.Send(new GetAllCategoryQuery());
                _memoryCache.Set(key: "Id", value: category);   
            }
            return Ok(_memoryCache.Get(key: "Id") as List<Category>);
        }

        [HttpDelete]
        public async ValueTask<IActionResult>DeleteByIdAsync(int Id)
        {
            var command = new DeleteCategoryCommand
            {
                Id = Id
            };
            bool result= await _mediatr.Send(command);
            return Ok(result);
        }

        [HttpPut]
        public async ValueTask<IActionResult> UpdateCategoryAsync(CategoryDto model,int Id)
        {
            var command = new UpdateCategoryCommand()
            {
                Id = Id,
                Name = model.Name,
                PhotoPath = model.PhotoPath,
            };
            await _mediatr.Send(command);
            return Ok("Update");
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetCategoryById(int Id)
        {
            var res=await _mediatr.Send(new GetCategoryByIdQuery { Id=Id});
            return Ok(res);
        }
    }
}
