using ArkoMebel.Domain.Entites;
using ArkoMebel.Service.Abstraction.DataAccess;
using ArkoMebel.Service.UseCases.Admins.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ArkoMebel.Service.UseCases.Admins.Handlers
{
    public class GetAllAdminHandler : IRequestHandler<GetAllAdminQuery, List<Admin>>
    {
        private readonly IApplicationDbContext _context;

        public GetAllAdminHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        async Task<List<Admin>> IRequestHandler<GetAllAdminQuery, List<Admin>>.Handle(GetAllAdminQuery request, CancellationToken cancellationToken)
        {
            var admins=await _context.Admins.ToListAsync(cancellationToken);
            return admins;
        }
    }
}
