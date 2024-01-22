using ArkoMebel.Domain.Entites;
using ArkoMebel.Service.Abstraction.DataAccess;
using ArkoMebel.Service.UseCases.Productes.Command;
using MediatR;

namespace ArkoMebel.Service.UseCases.Productes.Handler
{
    public class CreateProductHandler : AsyncRequestHandler<CreateProductCommand>
    {
        private readonly IApplicationDbContext _context;

        public CreateProductHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        protected override async Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var command = new Product()
            {
                Name = request.Name,
                Color = request.Color,  
                Description = request.Description,
                Price = request.Price,
                CategoryId = request.CategoryId,
             
            };
            _context.Products.Add(command);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
