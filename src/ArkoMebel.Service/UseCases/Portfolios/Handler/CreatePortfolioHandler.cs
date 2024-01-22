using ArkoMebel.Domain.Entites;
using ArkoMebel.Service.Abstraction.DataAccess;
using ArkoMebel.Service.Abstraction.File;
using ArkoMebel.Service.UseCases.Portfolios.Command;
using MediatR;

namespace ArkoMebel.Service.UseCases.Portfolios.Handler
{
    public class CreatePortfolioHandler : AsyncRequestHandler<CreatePortfolioCommand>
    {
        private readonly IApplicationDbContext _context;
        private readonly IFileService _fileService;

        public CreatePortfolioHandler(IApplicationDbContext context, IFileService fileService)
        {
            _context = context;
            _fileService = fileService;
        }

        protected override async Task Handle(CreatePortfolioCommand request, CancellationToken cancellationToken)
        {
            var command = new Portfolio()
            {
                PhotoPath = await _fileService.UploadImageAsync(request.PhotoPath),
                CategoryId = request.CategoryId,
           
            };

            _context.Portfolio.Add(command);
            await _context.SaveChangesAsync(cancellationToken);

        }
    }
}
