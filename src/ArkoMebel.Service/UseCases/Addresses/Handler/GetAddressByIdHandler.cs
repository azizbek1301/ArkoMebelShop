using ArkoMebel.Domain.Entites;
using ArkoMebel.Service.Abstraction;
using ArkoMebel.Service.UseCases.Addresses.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ArkoMebel.Service.UseCases.Addresses.Handler
{
    public class GetAddressByIdHandler : IRequestHandler<GetAddressByIdCommand, Address>
    {
        private readonly IApplicationDbContext _context;

        public GetAddressByIdHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Address> Handle(GetAddressByIdCommand request, CancellationToken cancellationToken)
        {
            var address = await _context.Addresses.FirstOrDefaultAsync(x => x.Id == request.Id);
            return address;
        }
    }
}
