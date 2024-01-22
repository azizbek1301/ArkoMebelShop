using ArkoMebel.Domain.Entites;
using ArkoMebel.Service.Abstraction.DataAccess;
using ArkoMebel.Service.UseCases.ProductBoxes.Command;
using MediatR;

namespace ArkoMebel.Service.UseCases.ProductBoxes.Handler
{
    public class CreateProductBoxHandler : AsyncRequestHandler<CreateProductBoxCommand>
    {
        private readonly IApplicationDbContext _context;

        public CreateProductBoxHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        protected override async Task Handle(CreateProductBoxCommand request, CancellationToken cancellationToken)
        {
            var command = new Prodact_Box()
            {
                ProductId = request.ProductId,
                BoxId = request.BoxId,
                Status = request.Status,
            };
            await _context.Prodact_Boxes.AddAsync(command);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
