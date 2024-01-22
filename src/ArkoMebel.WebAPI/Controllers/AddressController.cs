using ArkoMebel.Domain.Entites;
using ArkoMebel.Service.UseCases.Addresses.Commands;
using ArkoMebel.Service.UseCases.Addresses.Queries;
using ArkoMebel.WebAPI.ViewModel;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace ArkoMebel.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IMediator _mediatr;
        private readonly IMemoryCache _memoryCache;

        public AddressController(IMediator mediatr, IMemoryCache memoryCache)
        {
            _mediatr = mediatr;
            _memoryCache = memoryCache;
        }

        [HttpPost]
        public async ValueTask<IActionResult>CreateAddressAsync(AddressDto model)
        {
            var command = new CreateAddressCommand()
            {
                City = model.City,
                Home = model.Home,
            };
            await _mediatr.Send(command);
            return Ok("Yasaldi");
        }
        [HttpGet]
        public async ValueTask<IActionResult>GetAllAddressAsync()
        {
           var res=await _mediatr.Send(new GetAllAddressCommand());
            return Ok(res); 
        }

        [HttpDelete]
        public async ValueTask<IActionResult> DeleteByIdAsync(int Id)
        {
            var command = new DeleteAddressCommand
            {
                Id = Id
            };
            bool result = await _mediatr.Send(command);
            return Ok(result);
        }
        [HttpPut]
        public async ValueTask<IActionResult> UpdateAddressAsync(AddressDto model,int Id)
        {
            var address = new UpdateAddressCommand()
            {
                Id = Id,
                City = model.City,
                Home = model.Home,
            };
            await _mediatr.Send(address);
            return Ok("Update");
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetAddressById(int Id)
        {
            var res = await _mediatr.Send(new GetAddressByIdCommand { Id = Id });
            return Ok(res);
        }
    }
}
