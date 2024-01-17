using ArkoMebel.Domain.Entites;
using ArkoMebel.Service.UseCases.Branches.Command;
using ArkoMebel.Service.UseCases.Branches.Queries;
using ArkoMebel.WebAPI.ViewModel;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace ArkoMebel.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMemoryCache _memoryCache;

        public BranchController(IMediator mediator, IMemoryCache memoryCache)
        {
            _mediator = mediator;
            _memoryCache = memoryCache;
        }
        [HttpPost]
        public async ValueTask<IActionResult> CreateBranchAsync(BranchDto model)
        {
            var command = new CreateBranchCommand()
            {
                Name = model.Name,
                OpenAt = new TimeOnly(model.OpenAt,0),
                CloseAt = new TimeOnly(model.CloseAt,0),
                PhoneNumber = model.PhoneNumber,
                Email = model.Email,
                AddressId = model.AddressId,
                Link = model.Link,
            };
            await _mediator.Send(command);
            return Ok("Yasaldi");
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetAllBranchAsync()
        {
            var value = _memoryCache.Get("Id");
            if(value== null)
            {
                var branch = await _mediator.Send(new GetAllBranchQuery());
                _memoryCache.Set(key: "Id", value: branch); 
            }
            return Ok(_memoryCache.Get(key: "Id") as List<Branch>);
        }

        [HttpDelete]
        public async ValueTask<IActionResult> DeleteByIdAsync(int Id)
        {
            var command = new DeleteBranchCommand()
            {
                Id = Id
            };
            bool result=await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPut]
        public async ValueTask<IActionResult> UpdateBranchAsync(BranchDto model,int Id)
        {
            var branch = new UpdateBranchCommand()
            {
                Id = Id,
                Name = model.Name,
                OpenAt = new TimeOnly(model.OpenAt,0),
                CloseAt = new TimeOnly(model.CloseAt,0),
                PhoneNumber = model.PhoneNumber,
                Email = model.Email,
                AddressId = model.AddressId,
                Link = model.Link,
            };
            await _mediator.Send(branch);
            return Ok("Update");
        }

        [HttpGet]
        public async ValueTask<IActionResult> GetBranchByIdAsync(int Id)
        {
            var res =await _mediator.Send(new GetBranchByIdQuery { Id = Id });
            return Ok(res);
        }

    }
}
