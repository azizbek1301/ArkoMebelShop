using ArkoMebel.Domain.Entites;
using ArkoMebel.Service.Abstraction;
using ArkoMebel.Service.UseCases.ProductBoxes.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ArkoMebel.Service.UseCases.ProductBoxes.Handler
{
    public class GetAllProductBoxHandler : IRequestHandler<GetAllProductBoxQuery, List<Prodact_Box>>
    {
        private readonly IApplicationDbContext _context;

        public GetAllProductBoxHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Prodact_Box>> Handle(GetAllProductBoxQuery request, CancellationToken cancellationToken)
        {
            return await _context.Prodact_Boxes.ToListAsync();
        }
    }
}
