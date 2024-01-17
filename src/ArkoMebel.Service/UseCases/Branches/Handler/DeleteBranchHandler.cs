using ArkoMebel.Service.Abstraction;
using ArkoMebel.Service.UseCases.Branches.Command;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ArkoMebel.Service.UseCases.Branches.Handler
{
    public class DeleteBranchHandler : IRequestHandler<DeleteBranchCommand, bool>
    {
        private readonly IApplicationDbContext _context;

        public DeleteBranchHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(DeleteBranchCommand request, CancellationToken cancellationToken)
        {
            var command= await _context.Branches.FirstOrDefaultAsync(x=>x.Id==request.Id);
            if (command==null)
            {
                return false;
            }
            else
            {
                _context.Branches.Remove(command);
                await _context.SaveChangesAsync(cancellationToken);
                return true;
            }
        }
    }
}
