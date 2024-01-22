using ArkoMebel.Service.Abstraction.DataAccess;
using ArkoMebel.Service.Abstraction.File;
using ArkoMebel.Service.UseCases.Comments.Command;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ArkoMebel.Service.UseCases.Comments.Handler
{
    public class DeleteCommentHandler : IRequestHandler<DeleteCommentCommand, bool>
    {
        private readonly IApplicationDbContext _context;
        private readonly IFileService _fileService;

        public DeleteCommentHandler(IApplicationDbContext context, IFileService fileService)
        {
            _context = context;
            _fileService = fileService;
        }

        public async Task<bool> Handle(DeleteCommentCommand request, CancellationToken cancellationToken)
        {
            var command=await _context.Comments.FirstOrDefaultAsync(x=>x.Id==request.Id);
            if(command == null)
            {
                return false;
            }
            try
            {

                await _fileService.DeleteImageAsync(command.PhotoPath);
                _context.Comments.Remove(command);
                await _context.SaveChangesAsync(cancellationToken);
                return true;
            }
            catch(Exception ex)
            {
                
            }

            _context.Comments.Remove(command);
            await _context.SaveChangesAsync(cancellationToken);
            return true;


        }
    }
}
