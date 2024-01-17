using ArkoMebel.Service.Abstraction;
using ArkoMebel.Service.UseCases.Addresses.Commands;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ArkoMebel.Service.UseCases.Addresses.Handler
{
    public class DeleteAddressHandler : IRequestHandler<DeleteAddressCommand,bool>
    {
        private readonly IApplicationDbContext _context;

        public DeleteAddressHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(DeleteAddressCommand request, CancellationToken cancellationToken)
        {
            var address = await _context.Addresses.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (address == null)
            {
                return false;
            }
            else
            {
                _context.Addresses.Remove(address);
                await _context.SaveChangesAsync(cancellationToken);
                return true;
            }
        }
    }
}
