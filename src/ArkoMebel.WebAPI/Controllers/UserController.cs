using ArkoMebel.Domain.Entites;
using ArkoMebel.Service.UseCases.Users.Command;
using ArkoMebel.Service.UseCases.Users.Queries;
using ArkoMebel.WebAPI.ViewModel;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace ArkoMebel.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediatr;
        private readonly IMemoryCache _memoryCache;
        public UserController(IMediator mediator, IMemoryCache memoryCache)
        {
            _mediatr = mediator;
            _memoryCache = memoryCache;
        }

        [HttpPost]
        public async ValueTask<IActionResult> CreateUserAsync(UserDto model)
        {
            var command = new CreateUserCommand
            {
                FullName = model.FullName,
                Email = model.Email,
                PasswordHash = model.Password,
                PhoneNumber = model.PhoneNumber,
                RefreshToken = Guid.NewGuid().ToString(),   


            };
            await _mediatr.Send(command);
            return Ok("Yasaldi");
        }

        [Authorize(Roles ="SuperAdmin")]
        [HttpGet]
        public async ValueTask<IActionResult> GetAllUserAsync()
        {
            var res = await _mediatr.Send(new GetAllUserCommand());
            return Ok(res);
        }

        [HttpDelete]
        public async ValueTask<IActionResult> DeleteByIdAsync(int Id)
        {
            var command = new DeleteUserCommand
            {
                Id = Id
            };

            bool result =await _mediatr.Send(command);  
            return Ok(result);
        }

        [HttpPut]
        public async ValueTask<IActionResult> UpdateUserAsync(UserDto model,int Id)
        {
            var user = new UpdateUserCommand()
            {

                Id=Id,
                FullName = model.FullName,
                Email = model.Email,
                PasswordHash = model.Password,
                PhoneNumber=model.PhoneNumber,
                RefreshToken=Guid.NewGuid().ToString(),
            };

            await _mediatr.Send(user);

            return Ok("Updated");
        }
        [HttpGet]
        public async ValueTask<IActionResult> GetUserByIdAsync(int Id)
        {
            var res = await _mediatr.Send(new GetUserByIdCommand { Id = Id });
            return Ok(res);
        }



    }
}
