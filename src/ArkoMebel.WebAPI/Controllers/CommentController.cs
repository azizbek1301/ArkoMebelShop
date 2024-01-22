using ArkoMebel.Domain.Entites;
using ArkoMebel.Service.UseCases.Comments.Command;
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
        public async ValueTask<IActionResult> CreateCommentAsync([FromForm]CreateCommentCommand model)
        {
           
            await _mediatr.Send(model);
            return Ok("Yasaldi");
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetAllCommentAsync()
        {
            var res = await _mediatr.Send(new GetAllCommentQuery());
            return Ok(res);
        }
    }
}
