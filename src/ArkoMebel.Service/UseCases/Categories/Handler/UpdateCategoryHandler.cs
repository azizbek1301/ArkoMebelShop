using ArkoMebel.Service.Abstraction.DataAccess;
using ArkoMebel.Service.Abstraction.File;
using ArkoMebel.Service.UseCases.Categories.Command;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ArkoMebel.Service.UseCases.Categories.Handler
{
    public class UpdateCategoryHandler : IRequestHandler<UpdateCategoryCommand, bool>
    {
        private readonly IApplicationDbContext _context;
        private readonly IFileService _fileService;

        public UpdateCategoryHandler(IApplicationDbContext context, IFileService fileService)
        {
            _context = context;
            _fileService = fileService;
        }

        public async  Task<bool> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = await _context.Categories.FirstOrDefaultAsync(x =>x.Id == request.Id);
            category.Name = request.Name;
            if(request.PhotoPath != null)
            {
                await _fileService.DeleteImageAsync(category.PhotoPath);
                category.PhotoPath = await _fileService.UploadImageAsync(request.PhotoPath);
            }
            

            _context.Categories.Update(category);
            var res = await _context.SaveChangesAsync(cancellationToken);
            return res > 0;
        }
    }
}
