using ArkoMebel.Service.Abstraction.DataAccess;
using ArkoMebel.Service.UseCases.Users.Command;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ArkoMebel.Service.UseCases.Users.Handler
{
    public class DeleteAddressHandler : IRequestHandler<DeleteUserCommand, bool>
    {
        private readonly IApplicationDbContext _context;

        public DeleteAddressHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == request.Id);
            if(user == null)
            {
                return false;
            }
            else
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync(cancellationToken);
                return true;
            }
        }
    }
}
