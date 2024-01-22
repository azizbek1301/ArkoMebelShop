using ArkoMebel.Domain.Entites;
using ArkoMebel.Service.Abstraction.DataAccess;
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
            var com = await _context.Products.ToListAsync(cancellationToken);
            return com;
        }
    }
}
