using ArkoMebel.Domain.Entites;
using ArkoMebel.Service.Abstraction;
using ArkoMebel.Service.UseCases.Addresses.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ArkoMebel.Service.UseCases.Addresses.Handler
{
    public class GetAllAddressHandler : IRequestHandler<GetAllAddressCommand, List<Address>>
    {
        private readonly IApplicationDbContext _context;

        public GetAllAddressHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Address>> Handle(GetAllAddressCommand request, CancellationToken cancellationToken)
        {
            return await _context.Addresses.ToListAsync();
        }
    }
}
