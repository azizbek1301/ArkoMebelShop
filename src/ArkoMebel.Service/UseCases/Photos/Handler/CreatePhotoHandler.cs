using ArkoMebel.Domain.Entites;
using ArkoMebel.Service.Abstraction.DataAccess;
using ArkoMebel.Service.Abstraction.File;
using ArkoMebel.Service.UseCases.Photos.Command;
using MediatR;

namespace ArkoMebel.Service.UseCases.Photos.Handler
{
    public class CreatePhotoHandler : AsyncRequestHandler<CreatePhotoCommand>
    {
        private readonly IApplicationDbContext _context;
        private readonly IFileService _fileService;

        public CreatePhotoHandler(IApplicationDbContext context, IFileService fileService)
        {
            _context = context;
            _fileService = fileService;
        }

        protected override async Task Handle(CreatePhotoCommand request, CancellationToken cancellationToken)
        {
            var command = new Photo()
            {
                PhotoPath = await _fileService.UploadImageAsync(request.PhotoPath),
                ProductId = request.ProductId,
            };

            _context.Photos.Add(command);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
