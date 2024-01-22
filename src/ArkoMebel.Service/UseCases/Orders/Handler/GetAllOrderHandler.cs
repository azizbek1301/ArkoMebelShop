using ArkoMebel.Domain.Entites;
using ArkoMebel.Service.Abstraction.DataAccess;
using ArkoMebel.Service.UseCases.Orders.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ArkoMebel.Service.UseCases.Orders.Handler
{
    public class GetAllOrderHandler : IRequestHandler<GetAllOrderQuery, List<Order>>
    {
        private readonly IApplicationDbContext _context;

        public GetAllOrderHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Order>> Handle(GetAllOrderQuery request, CancellationToken cancellationToken)
        {
            return await _context.Orders.ToListAsync();
        }
    }
}
