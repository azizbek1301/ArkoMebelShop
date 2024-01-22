using ArkoMebel.Domain.Entites;
using ArkoMebel.Service.Abstraction.DataAccess;
using ArkoMebel.Service.UseCases.Portfolios.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ArkoMebel.Service.UseCases.Portfolios.Handler
{
    public class GetAllPortfolioHandler : IRequestHandler<GetAllPortfolioQuery, List<Portfolio>>
    {
        private readonly IApplicationDbContext _context;

        public GetAllPortfolioHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Portfolio>> Handle(GetAllPortfolioQuery request, CancellationToken cancellationToken)
        {
            return await _context.Portfolio.ToListAsync(cancellationToken);
        }
    }
}
