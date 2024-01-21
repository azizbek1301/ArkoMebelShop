using ArkoMebel.Domain.Entites;
using ArkoMebel.Service.Abstraction.DataAccess;
using ArkoMebel.Service.UseCases.Addresses.Commands;
using MediatR;

namespace ArkoMebel.Service.UseCases.Addresses.Handler
{
    public class CreateAddressHandler:AsyncRequestHandler<CreateAddressCommand>
    {
        private readonly IApplicationDbContext _context;

        public CreateAddressHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        protected override async Task Handle(CreateAddressCommand request, CancellationToken cancellationToken)
        {
            var address = new Address()
            {
                City = request.City,
                Home = request.Home,
            };

            await _context.Addresses.AddAsync(address);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
