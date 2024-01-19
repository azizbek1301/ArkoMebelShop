using ArkoMebel.Domain.Entites;
using ArkoMebel.Service.Abstraction;
using ArkoMebel.Service.UseCases.Orders.Command;
using MediatR;

namespace ArkoMebel.Service.UseCases.Orders.Handler
{
    public class CreateOrderHandler : AsyncRequestHandler<CreateOrderCommand>
    {
        private readonly IApplicationDbContext _context;

        public CreateOrderHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        protected override async Task Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var command = new Order()
            {
                BoxId = request.BoxId,
                AddressId = request.AddressId,
            };
        }
    }
}
