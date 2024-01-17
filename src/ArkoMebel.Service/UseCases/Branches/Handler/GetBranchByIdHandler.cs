using ArkoMebel.Domain.Entites;
using ArkoMebel.Service.Abstraction;
using ArkoMebel.Service.UseCases.Branches.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ArkoMebel.Service.UseCases.Branches.Handler
{
    public class GetBranchByIdHandler : IRequestHandler<GetBranchByIdQuery, Branch>
    {
        private readonly IApplicationDbContext _context;

        public GetBranchByIdHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Branch> Handle(GetBranchByIdQuery request, CancellationToken cancellationToken)
        {
            var command=await _context.Branches.FirstOrDefaultAsync(x=>x.Id==request.Id);
            if(command!=null)
            {
                return command;

            }
            else
            {
                throw new ArgumentNullException("Topilamdi");
            }
        }
    }
}
