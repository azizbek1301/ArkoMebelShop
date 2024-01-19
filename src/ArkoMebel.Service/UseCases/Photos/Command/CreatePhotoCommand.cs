using MediatR;

namespace ArkoMebel.Service.UseCases.Photos.Command
{
    public class CreatePhotoCommand : IRequest
    {
        public string PhotoPath { get; set; }
        public int ProductId { get; set; }
    }
}
