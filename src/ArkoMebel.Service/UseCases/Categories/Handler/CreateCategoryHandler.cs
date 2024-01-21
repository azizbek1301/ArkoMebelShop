using ArkoMebel.Domain.Entites;
using ArkoMebel.Service.Abstraction.DataAccess;
using ArkoMebel.Service.Abstraction.File;
using ArkoMebel.Service.UseCases.Categories.Command;
using MediatR;

namespace ArkoMebel.Service.UseCases.Categories.Handler
{
    public class CreateCategoryHandler:AsyncRequestHandler<CreateCategoryCommand>
    {
        private readonly IApplicationDbContext _context;
        private readonly IFileService _fileService;

        public CreateCategoryHandler(IApplicationDbContext context, IFileService fileService)
        {
            _context = context;
            _fileService = fileService;
        }



        protected override async Task Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {


            var category = new Category()
            {
                Name = request.Name,
                PhotoPath = await _fileService.UploadImageAsync(request.PhotoPath),
            };
            _context.Categories.Add(category);

            await _context.SaveChangesAsync(cancellationToken);
          
        }
    }
}
