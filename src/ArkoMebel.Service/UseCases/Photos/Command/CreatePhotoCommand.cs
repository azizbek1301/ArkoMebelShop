using MediatR;
using Microsoft.AspNetCore.Http;

namespace ArkoMebel.Service.UseCases.Photos.Command
{
    public class CreatePhotoCommand : IRequest
    {
        public IFormFile PhotoPath { get; set; }
        public int ProductId { get; set; }
    }
}
