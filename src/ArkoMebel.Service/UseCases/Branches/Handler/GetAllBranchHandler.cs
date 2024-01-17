using ArkoMebel.Domain.Entites;
using ArkoMebel.Service.Abstraction;
using ArkoMebel.Service.UseCases.Branches.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ArkoMebel.Service.UseCases.Branches.Handler
{
    public class GetAllBranchHandler : IRequestHandler<GetAllBranchQuery, List<Branch>>
    {
        private readonly IApplicationDbContext _context;

        public GetAllBranchHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Branch>> Handle(GetAllBranchQuery request, CancellationToken cancellationToken)
        {
            return await _context.Branches.ToListAsync();
        }
    }
}
