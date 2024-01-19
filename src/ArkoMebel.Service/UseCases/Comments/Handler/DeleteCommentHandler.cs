using ArkoMebel.Service.Abstraction;
using ArkoMebel.Service.UseCases.Comments.Command;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ArkoMebel.Service.UseCases.Comments.Handler
{
    public class DeleteCommentHandler : IRequestHandler<DeleteCommentCommand, bool>
    {
        private readonly IApplicationDbContext _context;

        public DeleteCommentHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(DeleteCommentCommand request, CancellationToken cancellationToken)
        {
            var command=await _context.Comments.FirstOrDefaultAsync(x=>x.Id==request.Id);
            if(command == null)
            {
                return false;
            }
            else
            {
                _context.Comments.Remove(command);
                await _context.SaveChangesAsync(cancellationToken);
                return true;
            }
        }
    }
}
