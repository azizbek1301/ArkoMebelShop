using ArkoMebel.Domain.Entites;
using ArkoMebel.Service.Abstraction;
using ArkoMebel.Service.UseCases.Productes.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ArkoMebel.Service.UseCases.Productes.Handler
{
    public class GetAllProductHandler : IRequestHandler<GetAllProductQuery, List<Product>>
    {
        private readonly IApplicationDbContext _context;

        public GetAllProductHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            return await _context.Products.ToListAsync();
        }
    }
}
