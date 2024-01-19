using ArkoMebel.Domain.Entites;
using ArkoMebel.Service.UseCases.Comments.Queries;
using ArkoMebel.Service.UseCases.Portfolios.Queries;
using ArkoMebel.WebAPI.ViewModel;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace ArkoMebel.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CommentController : ControllerBase
    {

        private readonly IMemoryCache _memoryCache;
        private readonly IMediator _mediatr;

        public CommentController(IMemoryCache memoryCahse, IMediator mediatr)
        {
            _memoryCache = memoryCahse;
            _mediatr = mediatr;
        }

        [HttpPost]
        public async ValueTask<IActionResult> CreateCommentAsync(CommentDto model)
        {
            var command = new Comment()
            {
                UserName = model.UserName,
                Text = model.Text,
                PhotoPath = model.PhotoPath,
                ProductId = model.ProductId,
            };
            await _mediatr.Send(command);
            return Ok("Yasaldi");
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetAllCommentAsync()
        {
            var res = _memoryCache.Get("Id");
            if (res == null)
            {
                var comment = await _mediatr.Send(new GetAllCommentQuery());
                _memoryCache.Set(key: "Id", value: comment);
            }
            return Ok(_memoryCache.Get(key: "Id") as List<Comment>);
        }
    }
}
