using ArkoMebel.Domain.Entites;
using ArkoMebel.Service.Abstraction;
using ArkoMebel.Service.UseCases.Photos.Command;
using MediatR;

namespace ArkoMebel.Service.UseCases.Photos.Handler
{
    public class CreatePhotoHandler : AsyncRequestHandler<CreatePhotoCommand>
    {
        private readonly IApplicationDbContext _context;

        public CreatePhotoHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        protected override async Task Handle(CreatePhotoCommand request, CancellationToken cancellationToken)
        {
            var command = new Photo()
            {
                PhotoPath = request.PhotoPath,
                ProductId = request.ProductId,
            };
        }
    }
}
