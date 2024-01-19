using ArkoMebel.Service.Abstraction;
using ArkoMebel.Service.UseCases.Categories.Command;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ArkoMebel.Service.UseCases.Categories.Handler
{
    public class DeleteCategoryHandler : IRequestHandler<DeleteCategoryCommand, bool>
    {
        private readonly IApplicationDbContext _context;

        public DeleteCategoryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            var command = await _context.Categories.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (command == null)
            {
                return false;
            }
            else
            {
                _context.Categories.Remove(command);
                await _context.SaveChangesAsync(cancellationToken);
                return true;
            }
        }
    }
}
