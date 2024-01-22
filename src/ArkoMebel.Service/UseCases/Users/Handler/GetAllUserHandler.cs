using ArkoMebel.Domain.Entites;
using ArkoMebel.Service.Abstraction.DataAccess;
using ArkoMebel.Service.UseCases.Users.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ArkoMebel.Service.UseCases.Users.Handler
{
    public class GetAllUserHandler : IRequestHandler<GetAllUserCommand, List<User>>
    {
        private readonly IApplicationDbContext _context;

        public GetAllUserHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<User>> Handle(GetAllUserCommand request, CancellationToken cancellationToken)
        {
            return await _context.Users.ToListAsync();
        }
    }
}
