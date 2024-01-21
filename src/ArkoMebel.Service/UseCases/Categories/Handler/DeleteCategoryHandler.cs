using ArkoMebel.Service.Abstraction.DataAccess;
using ArkoMebel.Service.Abstraction.File;
using ArkoMebel.Service.UseCases.Categories.Command;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ArkoMebel.Service.UseCases.Categories.Handler
{
    public class DeleteCategoryHandler : IRequestHandler<DeleteCategoryCommand, bool>
    {
        private readonly IApplicationDbContext _context;
        private readonly IFileService _fileService;

        public DeleteCategoryHandler(IApplicationDbContext context, IFileService fileService)
        {
            _context = context;
            _fileService = fileService;
        }

        public async Task<bool> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            var command = await _context.Categories.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (command == null)
            {
                throw new DirectoryNotFoundException("Ma'lumot topilmadi");
            }
            try
            {
                
                await _fileService.DeleteImageAsync(command.PhotoPath);
                
            }
            catch(Exception ex) 
            {
                throw new Exception();
            }

            _context.Categories.Remove(command);
            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
